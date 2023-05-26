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
        AdministrareHaine adminHaine;
        AdministareVanzari adminVanzari;

        private Label lblHeaderMarime;
        private Label lblHeaderProducator;
        private Label lblHeaderTip;
        private Label lblHeaderPret;
        private Label lblHeaderNrbucati;

        private Label[] lblsMarime;
        private Label[] lblsProducator;
        private Label[] lblsTip;
        private Label[] lblsPret;
        private Label[] lblsNrbucati;

        private Label lblHeaderID;
        private Label lblHeaderProducator;
        private Label lblHeaderModel;
        private Label lblHeaderCuloare;
        private Label lblHeaderAnFabricare;
        private Label lblHeaderPret;
        private Label lblHeaderStatus;

        private Label[] lblHeaderID;
        private Label[] lblHeaderProducator;
        private Label[] lblHeaderModel;
        private Label[] lblHeaderCuloare;
        private Label[] lblHeaderAnFabricare;
        private Label[] lblHeaderPret;
        private Label[] lblHeaderStatus;

        private const int LATIME_CONTROL = 120;
        private const int DIMENSIUNE_PAS_Y = 20;
        private const int DIMENSIUNE_PAS_X = 120;
        private const int OFFSET_Y = 30;
        private const int OFFSET_X = 500;





        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
