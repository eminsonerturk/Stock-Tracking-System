using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipProgrami
{
    public partial class satisSorgulama : Form
    {
        public satisSorgulama()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            cFilmSatis fs = new cFilmSatis();
            fs.SatislariGetirByTarihlerArasi(lvSatislar, txtToplamAdet, txtToplamTutar, dtpTarih1.Value, dtpTarih2.Value);
            DataTable dt = fs.SatislariGetirByTarihlerArasi(dtpTarih1.Value, dtpTarih2.Value);
            int TopAdet = 0;
            double TopTutar = 0;
            foreach (DataRow dr in dt.Rows)
            {
                TopAdet += Convert.ToInt32(dr["Adet"]);
                TopTutar += Convert.ToDouble(dr["Tutar"]);
            }
            txtToplamAdet.Text = TopAdet.ToString();
            txtToplamTutar.Text = TopTutar.ToString();
        }


    }
}
