using Gestiune_haine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_3
{
    public partial class Form1 : Form
    {
        private string ProducatorAdaugat = "";
        private string TipAdaugat = "";
        private string MarimeSelectata;
        private string PretSelectat;
        private List<Haine> hainele = new List<Haine>();
        public Form1()
        {

            InitializeComponent();
          

        }
        
         private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_S_CheckedChanged(object sender, EventArgs e)
        {
            MarimeSelectata = "Marimea S";
        }

        private void btn_M_CheckedChanged(object sender, EventArgs e)
        {
            MarimeSelectata = "Marimea M";
        }

        private void btn_L_CheckedChanged(object sender, EventArgs e)
        {
            MarimeSelectata = "Marimea L";
        }

        private void btn_iarna_CheckedChanged(object sender, EventArgs e)
        {
            TipAdaugat = "Haine de iarna";
        }

        private void tip_vara_CheckedChanged(object sender, EventArgs e)
        {
            TipAdaugat = "Haine de vara";
        }

        private void add_click_Click(object sender, EventArgs e)
        {
            if (producator.Text == string.Empty || TipAdaugat == string.Empty || MarimeSelectata == string.Empty || pret.Text == string.Empty)
                return;
            var haine = new Haine(producator.Text, pret.Text, TipAdaugat, MarimeSelectata);
            hainele.Add(haine);

            ProducatorAdaugat = producator.Text;
            PretSelectat = pret.Text;
            producator.ResetText();
            pret.ResetText();
            return;
        }

        private void afisare_Click_Click(object sender, EventArgs e)
        {
            if (hainele.Count == 0)
                return;

            dataGrid.Columns.Clear();
            dataGrid.Columns.Add("Producator", "Producator");
            dataGrid.Columns.Add("Tip", "Tip");
            dataGrid.Columns.Add("Marime", "Marime");
            dataGrid.Columns.Add("Magazin", "Magazin");

            foreach (var haine in hainele)
            {
                int randNou = dataGrid.Rows.Add();
                dataGrid.Rows[randNou].Cells[0].Value = haine.Producator;
                dataGrid.Rows[randNou].Cells[1].Value = haine.Tip;
                dataGrid.Rows[randNou].Cells[2].Value = haine.Marime;
                dataGrid.Rows[randNou].Cells[3].Value = haine.Pret;
            }
        }
    }
    
}
