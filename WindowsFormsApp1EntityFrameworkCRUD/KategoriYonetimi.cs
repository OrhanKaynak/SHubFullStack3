using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppAdoNetCRUD;

namespace WindowsFormsApp1EntityFrameworkCRUD
{
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }
        DatabaseContext context = new DatabaseContext();
        void Yukle()
        {
            dgvKategoriler.DataSource = context.Categories.ToList();
            // butonları sıfırla
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            // input alanlarını sıfırla
            txtAciklama.Text = string.Empty;
            txtKategoriAdi.Text = string.Empty;
            cbDurum.Checked = false;
        }
        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez!");
                return;
            }
            var kategori = new Category
            {
                CreateDate = DateTime.Now,
                Name = txtKategoriAdi.Text,
                Description = txtAciklama.Text,
                IsActive = cbDurum.Checked
            };
            context.Categories.Add(kategori); // ef de kategorilere add metodu ile ekleme yapıyoruz
            var sonuc = context.SaveChanges(); // ef de savechanges metodu vardır ve bu metot context üzerinde yapılan ekleme güncelleme silme vb işlemleri veritabanına işler ve db den etkilenen kayıt sayısını getirir.
            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kayıt başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt başarısız!");
            }
        }

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKategoriAdi.Text = dgvKategoriler.CurrentRow.Cells[1].Value.ToString();
            txtAciklama.Text = dgvKategoriler.CurrentRow.Cells[2].Value.ToString();
            cbDurum.Checked = (bool)dgvKategoriler.CurrentRow.Cells[3].Value;

            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez!");
                return;
            }
            var id = (int)dgvKategoriler.CurrentRow.Cells[0].Value; // seçilen kaydın id değerini al
            var kayit = context.Categories.Find(id); // db deb bu id li kaydı bulan ef metodu find

            kayit.Name = txtKategoriAdi.Text;
            kayit.Description = txtAciklama.Text;
            kayit.IsActive = cbDurum.Checked;
            // değişiklikleri db ye işle
            var sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kayıt başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt başarısız!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var id = (int)dgvKategoriler.CurrentRow.Cells["Id"].Value; // seçilen kaydın id si
            var kayit = context.Categories.Find(id); // db den kaydı bul
            context.Categories.Remove(kayit); // kaydı silinecek olarak işaretle

            // değişiklikleri db ye işle

            var sonuc = context.SaveChanges();

            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kayıt Silme Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt Silme Başarısız!");
            }
        }
    }
}
