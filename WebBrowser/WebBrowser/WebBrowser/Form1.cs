using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class webBrowser : Form
    {
        public webBrowser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            surf.GoForward();
        }

        private void home_Click(object sender, EventArgs e)
        {
            surf.GoHome();

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            surf.Refresh();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            surf.Stop();
        }

        private void go_Click(object sender, EventArgs e)
        {
            surf.Navigate(url.Text);
        }

        private void surf_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            url.Text = e.Url.ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            surf.GoBack();
        }
    }
}
