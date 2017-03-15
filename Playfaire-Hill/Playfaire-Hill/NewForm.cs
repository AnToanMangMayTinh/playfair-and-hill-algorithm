using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playfaire
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }
        // private delegate void PassingData(string strData);
        private string strData;
        public void txtPlainText_TextChanged(object sender, EventArgs e)
        {
            if (txtPlainText.Text.Length > 2)
            {
                strData = txtPlainText.Text;
            }
        }

        public string GetDataFromNewForm ()
        {
           return strData ;
        }


    }
}
