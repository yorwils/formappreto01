using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formappreto01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "reto1xdxd";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < 10; j++)
            {
            
                lblSerie.Text = lblSerie.Text + "\n" + j;


            }
        }
    }
}
