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
    public partial class ilac_ekle_form : Form
    {
        Database database = null;
        IlacDal ilacdal = null;
        public ilac_ekle_form()
        {
            this.database = new Database();
            this.ilacdal = new IlacDal(this.database);

            InitializeComponent();
        }
        private void LoadProduct()
        {
            dgwIlac.DataSource = ilacdal.GetAll();

        }


        private void ilac_ekle_form_Load(object sender, EventArgs e)
        {
            LoadProduct();

        }

   


        private void button1_Click_1(object sender, EventArgs e)
        {
        
            ilacdal.Add(new Ilac
            {
                ilacAdi = txtAd.Text,
                ilacTuru = txtTur.Text,
                ilacStt = txtTarih.Text,
                ilacEtken = richEtken.Text
            });

            MessageBox.Show("İLAÇ EKLENDİ...");
            LoadProduct();
        }

        private void dgwIlac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGuncelleAd.Text = dgwIlac.CurrentRow.Cells[1].Value.ToString();
            txtGuncelleTur.Text = dgwIlac.CurrentRow.Cells[2].Value.ToString();
            txtGuncelleTarih.Text = dgwIlac.CurrentRow.Cells[3].Value.ToString();
            richGuncelleEtken.Text = dgwIlac.CurrentRow.Cells[4].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ilac ilac = new Ilac
            {
                ilacKodu = Convert.ToInt32(dgwIlac.CurrentRow.Cells[0].Value),
                ilacAdi= txtGuncelleAd.Text,
                ilacTuru= txtGuncelleTur.Text,
                ilacStt = txtGuncelleTarih.Text,
                ilacEtken = richGuncelleEtken.Text
            };
            ilacdal.Update(ilac);
            LoadProduct();
            MessageBox.Show("İLAÇ BİLGİLERİ GÜNCELLENDİ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwIlac.CurrentRow.Cells[0].Value);
            ilacdal.Delete(id);
            LoadProduct();
            MessageBox.Show("İLAÇ SİLİNDİ");
        }

       
    }
}
