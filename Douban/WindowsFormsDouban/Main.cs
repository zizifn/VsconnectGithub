using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDouban
{
    public partial class Main : Form
    {
        public Main()
        {

            InitializeComponent();

        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void wbDouban_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            (sender as WebBrowser).Document.Window.Error += Window_Error;
        }

        void Window_Error(object sender, HtmlElementErrorEventArgs e)
        {
            e.Handled = true;
        }

        private void wbDouban_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
           // (sender as WebBrowser).Document.Window.Error += Window_Error;
        }

      

       
    }
}
