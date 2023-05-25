using OOP.GemiClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.GemiOdev
{
    public partial class SeferDetay : Form
    {
        public SeferDetay()
        {
            InitializeComponent();
        }

        private void UrunCesitleriYukle()
        {
            List<Urun> UrunCesitleri = new List<Urun>() { new Urun { UrunAdi = "Katı" }, new Urun { UrunAdi = "Sıvı" }, new Urun { UrunAdi = "Gaz" } };
            foreach (var item in UrunCesitleri)
            {
                cmbUrun.Items.Add(item.UrunAdi);
            }

            //AddRange liste ekler.
        }
        List<Urun> UrunListesi = new List<Urun>();
        List<Gemi> Gemiler = new List<Gemi>();
        List<Sefer> Seferler = new List<Sefer>();
        private void GemiYukle()
        {
            List<Gemi> demo = new List<Gemi>() {
                new Gemi { GemiAdi = "KaptanKamil" , MaxGemiTon=10},
                new Gemi { GemiAdi = "KaptanBuğra" ,MaxGemiTon=5},
                new Gemi { GemiAdi = "KaptanEge" ,MaxGemiTon=3} ,
                new Gemi { GemiAdi = "KaptanYılmaz" ,MaxGemiTon=2} };
            Gemiler.AddRange(demo);
            foreach (var item in Gemiler)
            {
                cmbGemiAdi.Items.Add(item.GemiAdi);
            }
        }
        private void btnSiparis_Click(object sender, EventArgs e)
        {
            Sefer sefer = new Sefer();
            Urun urun = new Urun();
            urun.UrunAdi = txtUrunAdi.Text;
            urun.UrunCesidi = cmbUrun.SelectedItem.ToString();
            urun.UrunTon = numTon.Value;
            UrunListesi.Add(urun);
            Gemi gemi = new Gemi();
            gemi.GemiAdi = cmbGemiAdi.Text;
            gemi.MaxGemiTon = Convert.ToDecimal(lblGemiTon.Text);
            Gemiler.Add(gemi);
            sefer.SeferUrun = urun;
            sefer.SeferGemi = gemi;

            if (sefer.SeferGemi.MaxGemiTon < sefer.SeferUrun.UrunTon)
            {
                MessageBox.Show("taşınmaz");
            }
            else
            {
                Seferler.Add(sefer);
            }

            // listBox1.Items.Add(urun.UrunAdi+ urun.UrunCesidi+ urun.UrunTon);
        }
        private void SeferDetay_Load(object sender, EventArgs e)
        {
            UrunCesitleriYukle();
            GemiYukle();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in Seferler)
            {
                listBox1.Items.Add(item.SeferGemi.GemiAdi + " " + item.SeferGemi.MaxGemiTon + " " + item.SeferUrun.UrunAdi + " " + item.SeferUrun.UrunCesidi + " " + item.SeferUrun.UrunTon);

            }


        }

        private void cmbGemiAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in Gemiler)
            {
                if (cmbGemiAdi.SelectedItem.ToString() == item.GemiAdi)
                {
                    lblGemiTon.Text = item.MaxGemiTon.ToString();
                }
            }
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            Rapor frmrapor = new Rapor(Seferler);
            frmrapor.Show();
        }
    }
}
