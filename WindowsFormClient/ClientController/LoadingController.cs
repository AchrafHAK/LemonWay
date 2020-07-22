using System.Threading;
using System.Windows.Forms;

namespace WindowsFormClient.ClientController
{
    /// <summary>
    /// this Controller has all the actions related to the dialog to display while getting data from web services
    /// </summary>
    public class LoadingController
    {
        /// <summary>
        /// This method add all configurations related to the loading form
        /// </summary>
        /// <param name="originalForm"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        private static BusyForm ConfigureLoading(Form originalForm, ContextEnum context)
        {
            return new BusyForm(context)
            {
                Size = originalForm.Size,
                Left = originalForm.Left,
                Top = originalForm.Top,
                TopMost = true,
                TopLevel = true
            };
        }

        /// <summary>
        /// This method created a new BsyForm then displays it on top while getting data
        /// </summary>
        /// <param name="originalForm"></param>
        /// <param name="context"></param>
        public static void ShowLoading(Form originalForm, ContextEnum context)
        {
            BusyForm loading = ConfigureLoading(originalForm, context);
            loading.ShowDialog(originalForm);
        }
    }
}
