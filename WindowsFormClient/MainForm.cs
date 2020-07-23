using System;
using System.Windows.Forms;
using WindowsFormClient.ClientController;

namespace WindowsFormClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Btn_Fibonacci_Click(object sender, EventArgs e)
        {
            // Check input validity
            if (!int.TryParse(TB_Input_Fibonacci.Text, out _))
            {
                TB_Input_Fibonacci.Text = string.Empty;
                MessageBox.Show("Veuillez entrer un entier valide pour Fibonacci");
                return;
            }

            // Get Fibunacci result and display a loading dialog
            LoadingController.ShowLoading(this, ContextEnum.Fibunacci);
        }

        private void Btn_XmlToJson_Click(object sender, EventArgs e)
        {
            // Get XmlToJson result and display a loading dialog
            LoadingController.ShowLoading(this, ContextEnum.XmlToJson);
        }
    }
}
