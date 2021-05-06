namespace Cambios
{
    using Cambios.Servicos;
    using Modelos;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        #region Atributos

        private List<Rate> Rates;

        private NetworkService networkService;

        private ApiService apiService;

        private DialogService dialogService;

        private DataService dataService;
        #endregion

        public Form1()
        {
            InitializeComponent();
            networkService = new NetworkService();
            apiService = new ApiService();
            dialogService = new DialogService();
            dataService = new DataService();
            LoadRates();
        }

        private async void LoadRates()
        {
            bool load;

            lbl_Resultado.Text = "A atualizar taxas...";

            var connection = networkService.CheckConnection();

            if (!connection.IsSuccess)
            {
                LoadLocalRates();
                load = false;
            }
            else
            {
                await LoadApiRates();
                load = true;
            }

            if (Rates.Count == 0)
            {
                lbl_Resultado.Text = "Não há ligação á Internet" + Environment.NewLine +
                    "e não foram prévimente carregadas as taxas." + Environment.NewLine +
                    "Tente mais tarde!";

                lbl_Status.Text = "Primeira inicialização deverá ter ligação á Internet";
                return;
            }


            combo_Origem.DataSource = Rates;
            combo_Origem.DisplayMember = "Name";

            combo_Destino.BindingContext = new BindingContext();

            combo_Destino.DataSource = Rates;
            combo_Destino.DisplayMember = "Name";

            progressBar1.Value = 100;

            btn_Convert.Enabled = true;
            btn_Troca.Enabled = true;

            lbl_Resultado.Text = "Taxas atualizadas...";

            if (load)
            {
                lbl_Status.Text = string.Format("Taxas carregadas da internet em {0:F}", DateTime.Now);
            }
            else
            {
                lbl_Status.Text = string.Format("Taxas carregadas da Base de Dados.");
            }

        }

        private void LoadLocalRates()
        {
            Rates = dataService.GetData();
        }

        private async Task LoadApiRates()
        {
            progressBar1.Value = 0;

            var response = await apiService.GetRates("http://cambios.somee.com", "/api/Rates");

            Rates = (List<Rate>)response.Result;

            dataService.DeleteData();
            dataService.SaveData(Rates);
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            Converter();
        }

        private void Converter()
        {
            if (string.IsNullOrEmpty(txt_Valor.Text))
            {
                dialogService.ShowMessage("Erro", "Insira um valor a converter");
                return;
            }

            decimal valor;
            if (!decimal.TryParse(txt_Valor.Text, out valor))
            {
                dialogService.ShowMessage("Erro de conversão", "Valor terá que ser numérico");
                return;
            }

            if (combo_Origem.SelectedItem == null)
            {
                dialogService.ShowMessage("Erro", "Tem de escolher uma moeda a converter");
            }

            if (combo_Destino.SelectedItem == null)
            {
                dialogService.ShowMessage("Erro", "Tem de escolher uma moeda de destino a converter");
            }

            var taxaOrigem = (Rate)combo_Origem.SelectedItem;
            var taxaDestino = (Rate)combo_Destino.SelectedItem;
            var valorConvertido = valor / (decimal)taxaOrigem.TaxRate * (decimal)taxaDestino.TaxRate;

            lbl_Resultado.Text = string.Format("{0} {1:C2} = {2} {3:C2}", taxaOrigem.Code, valor, taxaDestino.Code, valorConvertido);
        }

        private void btn_Troca_Click(object sender, EventArgs e)
        {
            Troca();
        }

        private void Troca()
        {
            var aux = combo_Origem.SelectedItem;
            combo_Origem.SelectedItem = combo_Destino.SelectedItem;
            combo_Destino.SelectedItem = aux;
            Converter();
        }
    }
}
