using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrtanjeKruznice
{
    public partial class Form1 : Form
    {
        // public bool crtaj = false;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        public void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        public void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Kruznica.srediste = this.PointToClient(MousePosition);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Kruznica.obodnaTocka = this.PointToClient(MousePosition);

            labelOpseg.Text = "Opseg kruznice: " + Kruznica.Opseg().ToString();
            labelPovrsina.Text = "Povrsina kruznice = " + Kruznica.Povrsina().ToString();

            Graphics g = this.CreateGraphics();
            Kruznica.IscrtajKruznicu(g);
        }


    }
}
