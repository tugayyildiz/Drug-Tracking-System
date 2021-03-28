using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giris_form
{
    public partial class giris_form : Form
    {
        public giris_form()
        {
            InitializeComponent();
        }

        private void btnBursa_Click(object sender, EventArgs e)
        {
            ilac_ekle_form ekle = new ilac_ekle_form();
            ekle.Visible = true;
        }
    }
}
