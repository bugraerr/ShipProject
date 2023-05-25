using OOP.GemiClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.GemiOdev
{
    public partial class Rapor : Form
    {
        List<Sefer> sefers = new List<Sefer>();

        public Rapor(List<Sefer> seferler)
        {
            sefers=seferler;
            InitializeComponent();
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in sefers)
            {
                listBox1.Items.Add(item.SeferGemi.GemiAdi + " " + item.SeferGemi.MaxGemiTon + " " + item.SeferUrun.UrunAdi + " " + item.SeferUrun.UrunCesidi + " " + item.SeferUrun.UrunTon);

            }
        }
    }
}
