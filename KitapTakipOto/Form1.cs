using AdoNetHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapTakipOto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string baglantiCumlesi = "Server=TRAINER; Database=KitapciDB; User Id=sa; Password=wissen";



        private void GetDataMusteri()
        {
            cmbMusteriKitap.Items.Clear();
            Database db = new Database(baglantiCumlesi);
            string q = "select * from Musteriler";

            DataTable sonucTablo = db.GetTable(q, null);

            foreach (DataRow row in sonucTablo.Rows)
            {
                Musteriler musteri = new Musteriler();

                musteri.Id = (int)row["Id"];
                musteri.Ad = row["Ad"].ToString();
                musteri.Soyad = row["Soyad"].ToString();
                musteri.EPosta = row["EPosta"].ToString();
                musteri.Telefon = row["Telefon"].ToString();

                cmbMusteriKitap.Items.Add(musteri);

            }

        }
        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            Database db = new Database(baglantiCumlesi);
            string q = "insert into Musteriler(Ad , Soyad, EPosta, Telefon) values(@Ad, @Soyad, @EPosta, @Telefon)";

            List<SqlParameter> par = new List<SqlParameter>();

            par.Add(new SqlParameter("@Ad", txtMusteriAdi.Text));
            par.Add(new SqlParameter("@Soyad", txtMusteriSoyad.Text));
            par.Add(new SqlParameter("@EPosta", txtMusteriEPosta.Text));
            par.Add(new SqlParameter("@Telefon", txtMusteriTelefon.Text));

            db.RunQuery(q, par);

            MessageBox.Show("Müsteri kaydedildi...");
            GetDataMusteri();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Database db = new Database(baglantiCumlesi);
            string q = "insert into Kitaplar(Yazar,Kategori,Fiyat,VarMi,KitapAdi, MusteriId) values(@Yazar,@Kategori,@Fiyat,@VarMi,@KitapAdi,@MusteriId)";
            Musteriler seciliMusteri = cmbMusteriKitap.SelectedItem as Musteriler;

            List<SqlParameter> par = new List<SqlParameter>();

            par.Add(new SqlParameter("@MusteriId", seciliMusteri.Id));
            par.Add(new SqlParameter("@Yazar", txtYazar.Text));
            par.Add(new SqlParameter("@Kategori", txtKategori.Text));
            par.Add(new SqlParameter("@Fiyat", nudFiyat.Value));
            par.Add(new SqlParameter("@KitapAdi", txtKitapAdi.Text));
            par.Add(new SqlParameter("@VarMi", chkVarMi.Checked));

            db.RunQuery(q, par);
            MessageBox.Show("Kitap Kaydedildi... ");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetDataMusteri();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Database db = new Database(baglantiCumlesi);

            string q = "update Kitaplar set KitapAdi=@KA, Yazar=@Y,Kategori=@K,Fiyat=@F, VarMi=@V where Id=@KitapId";

            List<SqlParameter> par = new List<SqlParameter>();

            Kitaplar seciliKitap = lstKitap.SelectedItem as Kitaplar;
            par.Add(new SqlParameter("@KitapId", seciliKitap.Id));

            par.Add(new SqlParameter("@Y", txtYazar.Text));
            par.Add(new SqlParameter("@K", txtKategori.Text));
            par.Add(new SqlParameter("@F", nudFiyat.Value));
            par.Add(new SqlParameter("@KA", txtKitapAdi.Text));
            par.Add(new SqlParameter("@V", chkVarMi.Checked));

            db.RunQuery(q, par);
            MessageBox.Show("Kitap  güncellendi...");
        }

        private void cmbMusteriKitap_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstKitap.Items.Clear();
            if (cmbMusteriKitap.SelectedIndex > -1)
            {

                Database db = new Database(baglantiCumlesi);

                string q = "select * from Kitaplar where MusteriId=@Id";

                List<SqlParameter> par = new List<SqlParameter>();

                Musteriler secliMusteri = cmbMusteriKitap.SelectedItem as Musteriler;
                par.Add(new SqlParameter("@Id", secliMusteri.Id));

                DataTable sonucTablo = db.GetTable(q, par);

                foreach (DataRow row in sonucTablo.Rows)
                {
                    Kitaplar kitap = new Kitaplar();

                    kitap.Id = (int)row["Id"];
                    kitap.KitapAdi = row["KitapAdi"].ToString();
                    kitap.Yazar = row["Yazar"].ToString();
                    kitap.Kategori = row["Kategori"].ToString();
                    kitap.Fiyat = (int)row["Fiyat"];
                    kitap.VarMi = (bool)row["VarMi"];

                    lstKitap.Items.Add(kitap);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKitap.SelectedIndex > -1)
            {
                Database db = new Database(baglantiCumlesi);
                string q = "delete from Kitaplar where Id=@seciliId";

                List<SqlParameter> par = new List<SqlParameter>();
                Kitaplar seciliKitap = lstKitap.SelectedItem as Kitaplar;

                par.Add(new SqlParameter("@seciliId", seciliKitap.Id));
                db.RunQuery(q, par);
            }

        }

        private void lstKitap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKitap.SelectedIndex > -1)
            {
                Kitaplar seciliKitap = lstKitap.SelectedItem as Kitaplar;

                txtKitapAdi.Text = seciliKitap.KitapAdi;
                txtYazar.Text = seciliKitap.Yazar;
                txtKategori.Text = seciliKitap.Kategori;
                nudFiyat.Value = seciliKitap.Fiyat;
                chkVarMi.Checked = seciliKitap.VarMi;
            }
        }
    }
}
