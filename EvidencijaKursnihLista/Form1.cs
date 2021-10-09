using EvidencijaKursnihLista.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidencijaKursnihLista
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<StavkeKL> stavkes = new List<StavkeKL>();

            stavkes.Add(new StavkeKL()
            {
                NazivZemlje = "EMU",
                OznakaValuce = "EUR",
                SifraValute = "987",
                SrednjiKurs = 117.5496m,
                VaziZa = 1
            });

            stavkes.Add(new StavkeKL()
            {
                NazivZemlje = "Australija",
                OznakaValuce = "AUD",
                ProdajniKurs = 0,
                SifraValute = "36",
                SrednjiKurs = 74.2528m,
                VaziZa = 1
            });

            stavkes.Add(new StavkeKL()
            {
                NazivZemlje = "Kanada",
                OznakaValuce = "CAD",
                SifraValute = "124",
                SrednjiKurs = 81.0575m,
                VaziZa = 1
            });

            stavkes.Add(new StavkeKL()
            {
                NazivZemlje = "Kina",
                OznakaValuce = "CNY",
                SifraValute = "156",
                SrednjiKurs = 15.7755m,
                VaziZa = 1
            });

            stavkes.Add(new StavkeKL()
            {
                NazivZemlje = "Hrvatska",
                OznakaValuce = "HRK",
                SifraValute = "191",
                SrednjiKurs = 15.6322m,
                VaziZa = 1
            });

            stavkes.Add(new StavkeKL()
            {
                NazivZemlje = "Češka Republika",
                OznakaValuce = "CZK",
                SifraValute = "203",
                SrednjiKurs = 4.6159m,
                VaziZa = 1
            });

            stavkes.Add(new StavkeKL()
            {
                NazivZemlje = "Danska",
                OznakaValuce = "DKK",
                SifraValute = "208",
                SrednjiKurs = 15.7920m,
                VaziZa = 1
            });

            stavkes.Add(new StavkeKL()
            {
                NazivZemlje = "Mađarska",
                OznakaValuce = "HUN",
                SifraValute = "348",
                SrednjiKurs = 32.7518m,
                VaziZa = 100
            });

            stavkes.Add(new StavkeKL()
            {
                NazivZemlje = "Japan",
                OznakaValuce = "JPY",
                SifraValute = "392",
                SrednjiKurs = 90.9193m,
                VaziZa = 100
            });

            stavkes.Add(new StavkeKL()
            {
                NazivZemlje = "Kuvajt",
                OznakaValuce = "KWD",
                SifraValute = "392",
                SrednjiKurs = 336.8183m,
                VaziZa = 1
            });

            foreach (var item in stavkes)
            {
                item.KupovniKurs = item.SrednjiKurs - item.SrednjiKurs * 0.1m;
                item.ProdajniKurs = item.SrednjiKurs + item.SrednjiKurs * 0.1m;
            }

            stavkeKLBindingSource.DataSource = stavkes;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
