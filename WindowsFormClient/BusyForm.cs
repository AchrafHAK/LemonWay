using ConsoleClient.ClientController;
using Newtonsoft.Json.Linq;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormClient.ClientController;

namespace WindowsFormClient
{
    public partial class BusyForm : Form
    {
        private readonly ContextEnum? currentContext = null;

        public BusyForm(ContextEnum context)
        {
            InitializeComponent();

            // set the current context using the parameter passed from the parent form
            currentContext = context;
        }

        private async void BusyForm_Load(object sender, EventArgs e)
        {
            // Perform changes on parent fields depending on the context of action
            switch (currentContext)
            {
                case ContextEnum.Fibunacci:

                    // Get needed fields for Fibonacci actions
                    TextBox fibonacciTextBoxInput = (TextBox)((MainForm)Owner).Controls["TB_Input_Fibonacci"];
                    Label fibonacciLabelOutput = (Label)((MainForm)Owner).Controls["Lbl_Output_Fibonacci"];

                    // Get the Fibonacci result asynchronously
                    string fibonacciBaseResult = await GetFibonacciResult(int.Parse(fibonacciTextBoxInput.Text));

                    // Change result format
                    string fibonacciResult = Regex.Replace(fibonacciBaseResult, "(\\d)(?=(\\d{3})+$)", "$1,");
                    fibonacciResult = $"Fibonacci({fibonacciTextBoxInput.Text}) = " + fibonacciResult;

                    // Display result
                    fibonacciLabelOutput.Visible = true;
                    fibonacciLabelOutput.Text = fibonacciResult;

                    // Set colour depending on result
                    if (fibonacciBaseResult.Equals("-1") || fibonacciBaseResult.Equals("0")) fibonacciLabelOutput.ForeColor = System.Drawing.Color.Red;
                    else fibonacciLabelOutput.ForeColor = System.Drawing.Color.Green;

                    break;

                case ContextEnum.XmlToJson:

                    // Get needed fields for XmlToJson actions
                    RichTextBox xmlToJsonTextBoxInput = (RichTextBox)((MainForm)Owner).Controls["TB_Input_XML"];
                    RichTextBox xmlToJsonLabelOutput = (RichTextBox)((MainForm)Owner).Controls["TB_Output_JSON"];

                    // Get the XmlToJson result asynchronously
                    string xmlToJsonResult = await GetXmlToJsonResult(xmlToJsonTextBoxInput.Text);

                    // Format JSON for pretty output
                    try
                    {
                        xmlToJsonResult = JToken.Parse(xmlToJsonResult).ToString();
                        xmlToJsonLabelOutput.ForeColor = System.Drawing.Color.Black;
                    }
                    catch
                    {
                        xmlToJsonLabelOutput.ForeColor = System.Drawing.Color.Red;
                    }

                    //Display result
                    xmlToJsonLabelOutput.Visible = true;
                    xmlToJsonLabelOutput.Text = xmlToJsonResult;

                    break;
            }

            Dispose();
            Close();
        }

        /// <summary>
        /// This method calls the Fibonacci client controller and displays the output to the console
        /// </summary>
        /// <param name="n"></param>
        static private async Task<string> GetFibonacciResult(int n)
        {
            return await LemonWayClient.FibonacciConsoleClientAsync(n);
        }

        /// <summary>
        /// This method calls the XmlToJson client controller and displays the output to the console
        /// </summary>
        /// <param name="xmlStr"></param>
        static private async Task<string> GetXmlToJsonResult(string xmlStr)
        {
            return await LemonWayClient.XmlToJsonConsoleClientAsync(xmlStr);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // This is used to apply a transparent backgroud with the GIF image
        }
    }
}
