using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Proiect;

namespace Formular
{
    public partial class Form4 : Form
    {
        Dictionary<int, double> sumaPerAn;
        Color[] culori = { Color.Pink, Color.SkyBlue, Color.ForestGreen, Color.IndianRed, Color.MediumPurple };
        Font font = new Font(FontFamily.GenericSerif, 12);
        const int margine = 40;

        public Form4(List<Client> clienti)
        {
            InitializeComponent();
            sumaPerAn = new Dictionary<int, double>();

            // Preluare date din lista de clienti 
            foreach (var client in clienti)
            {
                if (client.Asigurari != null)
                {
                    foreach (var asig in client.Asigurari)
                    {
                        int an = asig.Inceput.Year;
                        if (sumaPerAn.ContainsKey(an))
                            sumaPerAn[an] += asig.Suma;
                        else
                            sumaPerAn[an] = asig.Suma;
                    }
                }
            }

            panel1.Paint += panel1_Paint;
            panel1.Invalidate();
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Graphics gr = e.Graphics;
            if (sumaPerAn.Count == 0)
            {
                gr.DrawString("Nu exista date pentru grafic.", font, Brushes.Black, 10, 10);
                return;
            }

            int latime = panel1.ClientSize.Width - 2 * margine;
            int inaltime = panel1.ClientSize.Height - 2 * margine;
            int n = sumaPerAn.Count;
            int latimeBara = Math.Max(10, latime / (2 * n));

            double sumaMax = sumaPerAn.Values.Max();

            int i = 0;
            foreach (var kvp in sumaPerAn.OrderBy(x => x.Key))
            {
                int x = margine + i * 2 * latimeBara;
                int h = (int)(inaltime * kvp.Value / sumaMax);
                int y = margine + inaltime - h;

                Brush br = new SolidBrush(culori[i % culori.Length]);
                gr.FillRectangle(br, x, y, latimeBara, h);

                // Deseneaza anul sub bara
                gr.DrawString(kvp.Key.ToString(), font, Brushes.Black, x, margine + inaltime + 5);

                // Deseneaza suma deasupra barei
                gr.DrawString(kvp.Value.ToString("0.##"), font, Brushes.Black, x, y - 20);

                i++;
            }

            gr.DrawLine(Pens.Black, margine, margine, margine, margine + inaltime);
            gr.DrawLine(Pens.Black, margine, margine + inaltime, margine + latime, margine + inaltime);

            gr.DrawString("Ani", font, Brushes.Black, margine + latime / 2, margine + inaltime + 30);
            gr.DrawString("Sume asigurate", font, Brushes.Black, 5, margine - 30);
        }
            

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_print);

            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }

        private void pd_print(object sender, PrintPageEventArgs e)
        {
            Graphics gr = e.Graphics;
            if (sumaPerAn.Count == 0)
            {
                gr.DrawString("Nu exista date pentru grafic.", font, Brushes.Black, 10, 10);
                return;
            }

            int marginePrint = 40;
            int latime = e.MarginBounds.Width - 2 * marginePrint;
            int inaltime = e.MarginBounds.Height - 2 * marginePrint;
            int n = sumaPerAn.Count;
            int latimeBara = Math.Max(10, latime / (2 * n));
            double sumaMax = sumaPerAn.Values.Max();
            int i = 0;
            foreach (var cheie in sumaPerAn.OrderBy(x => x.Key))
            {
                int x = e.MarginBounds.Left + marginePrint + i * 2 * latimeBara;
                int h = (int)(inaltime * cheie.Value / sumaMax);
                int y = e.MarginBounds.Top + marginePrint + inaltime - h;

                Brush br = new SolidBrush(culori[i % culori.Length]);
                gr.FillRectangle(br, x, y, latimeBara, h);

                gr.DrawString(cheie.Key.ToString(), font, Brushes.Black, x, e.MarginBounds.Top + marginePrint + inaltime + 5);
                gr.DrawString(cheie.Value.ToString("0.##"), font, Brushes.Black, x, y - 20);

                i++;
            }
            gr.DrawLine(Pens.Black, e.MarginBounds.Left + marginePrint, e.MarginBounds.Top + marginePrint, e.MarginBounds.Left + marginePrint, e.MarginBounds.Top + marginePrint + inaltime);
            gr.DrawLine(Pens.Black, e.MarginBounds.Left + marginePrint, e.MarginBounds.Top + marginePrint + inaltime, e.MarginBounds.Left + marginePrint + latime, e.MarginBounds.Top + marginePrint + inaltime);
            gr.DrawString("Ani", font, Brushes.Black, e.MarginBounds.Left + marginePrint + latime / 2, e.MarginBounds.Top + marginePrint + inaltime + 30);
            gr.DrawString("Sume asigurate", font, Brushes.Black, e.MarginBounds.Left + 5, e.MarginBounds.Top + marginePrint - 30);
        }
    }
}