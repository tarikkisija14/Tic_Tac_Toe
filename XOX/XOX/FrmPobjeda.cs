using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOX
{
    public partial class FrmPobjeda : Form
    {
        private System.Windows.Forms.Timer timer;
        public FrmPobjeda()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();

            timer.Interval = 1000; 
            timer.Tick += new EventHandler(Timer_Tick);
            this.Load += new EventHandler(FrmPobjeda_Load);

            BackColor = Color.Gray;
            TransparencyKey=Color.Gray;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPobjeda_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop(); // Zaustavi Timer
            this.Close(); // Zatvori formu
        }
    }
}
