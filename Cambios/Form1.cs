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
        private NetworkService networkService;

        private ApiService apiService;
        #endregion

        List<Rate> Rates { get; set; } = new List<Rate>();

        public Form1()
        {
            InitializeComponent();
            networkService = new NetworkService();
            apiService = new ApiService();
            LoadRates();
        }

        private async void LoadRates()
        {
            //bool load;

            lbl_Resultado.Text = "A atualizar taxas...";

            var connection = networkService.CheckConnection();

            if (!connection.IsSuccess)
            {
                MessageBox.Show(connection.Message);
                return;
            }
            else
            {
                await LoadApiRates();
            }


            combo_Origem.DataSource = Rates;
            combo_Origem.DisplayMember = "Name";

            combo_Destino.BindingContext = new BindingContext();

            combo_Destino.DataSource = Rates;
            combo_Destino.DisplayMember = "Name";

            progressBar1.Value = 100;

            lbl_Resultado.Text = "Taxas carregadas...";

        }

        private async Task LoadApiRates()
        {
            progressBar1.Value = 0;

            var response = await apiService.GetRates("http://cambios.somee.com", "/api/Rates");

            Rates = (List<Rate>)response.Result;
        }
    }
}
