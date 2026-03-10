using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppAdoNetCRUD;

namespace WindowsFormsApp1EntityFrameworkCRUD
{
    public partial class UrunYonetimi : Form
    {
        public UrunYonetimi()
        {
            InitializeComponent();
        }
        DatabaseContext context = new DatabaseContext();
        void Yukle()
        {
            dgvUrunler.DataSource = context.Products.ToList();
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }
        private void UrunYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                MessageBox.Show("Ürün adı boş geçilemez!");
                return;
            }
            var urun = new Product
            {
                CreateDate = DateTime.Now,
                Name = txtUrunAdi.Text,
                Description = txtAciklama.Text,
                IsActive = cbDurum.Checked,
                Price = Convert.ToDecimal(txtUrunFiyati.Text),
                Stock = Convert.ToInt32(txtStok.Text)
            };
            try
            {
                context.Products.Add(urun);
                var sonuc = context.SaveChanges();
                if (sonuc > 0)
                {
                    Yukle();
                    MessageBox.Show("Kayıt başarılı");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Text = dgvUrunler.CurrentRow.Cells[1].Value.ToString();
            txtAciklama.Text = dgvUrunler.CurrentRow.Cells[2].Value.ToString();
            cbDurum.Checked = (bool)dgvUrunler.CurrentRow.Cells[3].Value;
            txtStok.Text = dgvUrunler.CurrentRow.Cells[5].Value.ToString();
            txtUrunFiyati.Text = dgvUrunler.CurrentRow.Cells[6].Value.ToString();

            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                MessageBox.Show("Ürün adı boş geçilemez!");
                return;
            }

            var id = (int)dgvUrunler.CurrentRow.Cells[0].Value;
            var kayit = context.Products.Find(id);

            kayit.CreateDate = DateTime.Now;
            kayit.Name = txtUrunAdi.Text;
            kayit.Description = txtAciklama.Text;
            kayit.IsActive = cbDurum.Checked;
            kayit.Price = Convert.ToDecimal(txtUrunFiyati.Text);
            kayit.Stock = Convert.ToInt32(txtStok.Text);

            try
            {
                var sonuc = context.SaveChanges();

                if (sonuc > 0)
                {
                    Yukle();
                    MessageBox.Show("Kayıt başarılı!");
                }
            }
            catch (Exception)
            {

                 MessageBox.Show("Hata oluştu!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var id = (int)dgvUrunler.CurrentRow.Cells[0].Value;
            var kayit = context.Products.Find(id);

            context.Products.Remove(kayit);

            try
            {
                var sonuc = context.SaveChanges();

                if (sonuc > 0)
                {
                    Yukle();
                    MessageBox.Show("Kayıt silme başarılı!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu!");
            }
        }
    }
}
