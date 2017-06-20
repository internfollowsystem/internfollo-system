using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StajyerTakip
{
    public partial class FrmIslem : Form
    {
        Connect i_add = new Connect();
        Intern yenikisi = new Intern();
        byte[] byteResim = { 0x20 };

        String yol = "c:\\";
        String klasör = "Stajer Takip";
        public FrmIslem()
        {
            InitializeComponent();

            bttn_guncelle.Enabled = false;
            bttn_kayitsil.Enabled = false;
        }

        

        private void bttnStajyerGtr_Click(object sender, EventArgs e)
        {
            bttn_guncelle.Enabled = true;
            bttn_kayitsil.Enabled = true;
        }
        
        private void bttn_kayitekle_Click(object sender, EventArgs e)
        {
            try
            {
                i_add.Baglan();

                yenikisi.tcNo = textBox1.Text;
                yenikisi.AdSoyad = textBox2.Text;
                yenikisi.BabaAd = textBox3.Text;
                yenikisi.AnneAd = textBox4.Text;
                yenikisi.DogumYeri = textBox5.Text;
                yenikisi.DogumTarihi = dateTimePicker1.Text;
                yenikisi.Uyrugu = textBox7.Text;
                yenikisi.Cinsiyet = comboBox1.Text;
                yenikisi.EvTelefonu = textBox8.Text;
                yenikisi.CepTelefonu = textBox6.Text;
                yenikisi.Ikametgah = textBox9.Text;
                yenikisi.EPosta = textBox10.Text;
                yenikisi.WebAdress = textBox11.Text;
                yenikisi.Boy = textBox12.Text;
                yenikisi.Agirlik = textBox13.Text;
                yenikisi.KanGrubu = comboBox2.Text;

                yenikisi.acl_AdSoyad = textBox14.Text;
                yenikisi.acl_Ikametgah = textBox15.Text;
                yenikisi.acl_Akrabalik = textBox16.Text;
                yenikisi.acl_Telefon = textBox17.Text;
                yenikisi.acl_EPosta = textBox18.Text;
                yenikisi.resim = byteResim.ToString();
                i_add.Add(yenikisi);
                MessageBox.Show("başarılı1");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            try { 

                yenikisi.OkulTuru = comboBox3.Text;
                yenikisi.OkulAdi = textBox20.Text;
                yenikisi.Sehir = textBox21.Text;
                yenikisi.BolumAdi = textBox22.Text;
                yenikisi.Sinif = comboBox4.Text;
                yenikisi.OkulNo = textBox23.Text;
                yenikisi.OkulPuani = textBox24.Text;
                yenikisi.Sigorta = comboBox8.Text;

                yenikisi.StjKabulDurum = comboBox5.Text;
                yenikisi.StjBasvuruTuru = textBox19.Text;
                yenikisi.StjYili = comboBox6.Text;
                yenikisi.StjDonemi = comboBox7.Text;
                yenikisi.StjKonusu = textBox25.Text;
                yenikisi.BslmSuresi = dateTimePicker2.Text;
                yenikisi.BtsSuresi = dateTimePicker3.Text;
                yenikisi.StjSuresi = textBox26.Text;
                yenikisi.KlnSuresi = textBox27.Text;
                yenikisi.StjDurumu = textBox28.Text;
                yenikisi.StjIcerigi = textBox29.Text;

                i_add.Add(yenikisi);
                MessageBox.Show("başarılı2");

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog fdialog = new OpenFileDialog();
                fdialog.Filter = "Pictures|*.jpg";
                fdialog.InitialDirectory = "C://";
                if (DialogResult.OK == fdialog.ShowDialog())
                {

                    string resimYol = fdialog.FileName;
                    pictureBox1.Image = Image.FromFile(resimYol);
                    byteResim = null;

                    FileInfo fInfo = new FileInfo(resimYol);
                    long sayac = fInfo.Length;
                    System.IO.FileStream fStream = new System.IO.FileStream(resimYol, FileMode.Open, FileAccess.Read);
                    BinaryReader bReader = new BinaryReader(fStream);
                    byteResim = bReader.ReadBytes((int)sayac);

                }

            }
            finally
            {

            }
            Directory.CreateDirectory(yol + "\\" + klasör);

        }
    }
}

