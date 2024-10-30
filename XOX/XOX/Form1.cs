namespace XOX
{
    public partial class Form1 : Form
    {
        public string Igrac1 { get; set; }
        public string Igrac2 { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            novaIgra();
        }

        public int BrojacPoteza { get; set; }



        private void button1_Click(object sender, EventArgs e)
        {
            KliknaDugme(sender);

        }

        private void KliknaDugme(object sender)
        {

            if (sender is Button button && button.Text == "")
            {
                if (BrojacPoteza % 2 == 0)
                {
                    button.Text = "X";
                }
                else
                    button.Text = "O";
                Text=BrojacPoteza%2==0?Igrac1 : Igrac2;   
                if (Pobjeda())
                {
                    new FrmPobjeda().ShowDialog();

                    Zavrsi(false);
                }
                BrojacPoteza++;
            }
        }

        private void Zavrsi(bool enabled,bool Tekst=false,bool Boja=false)
        {
            foreach (var control in Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = enabled;
                    if (Tekst)
                    {
                        button.Text = "";
                    }
                    if (Boja)
                    {
                        button.UseVisualStyleBackColor = true;  
                    }
                }
            }
        }

        private bool Pobjeda()
        {
            return ProvjeriRedove() || provjeriKolone() || ProvjeriDijagonalu(); ; 
        }

        private bool ProvjeriDijagonalu()
        {
            return ProvjeriPobjedu(button1, button5, button9) ||
               ProvjeriPobjedu(button3, button5, button7);
               
        }

        private bool provjeriKolone()
        {
            return ProvjeriPobjedu(button1, button4, button7) ||
               ProvjeriPobjedu(button2, button5, button8) ||
               ProvjeriPobjedu(button3, button6, button9);
        }

        private bool ProvjeriRedove()
        {
            return ProvjeriPobjedu(button1, button2, button3) ||
                ProvjeriPobjedu(button4, button5, button6) ||
                ProvjeriPobjedu(button7, button8, button9);
        }

        private bool ProvjeriPobjedu(Button button1, Button button2, Button button3)
        {
            bool pobjeda = button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text;
            if (pobjeda)
            {
                button1.BackColor = button2.BackColor = button3.BackColor = Color.Yellow;
            }
            return pobjeda;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KliknaDugme(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KliknaDugme(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KliknaDugme(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KliknaDugme(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            KliknaDugme(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KliknaDugme(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            KliknaDugme(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            KliknaDugme(sender);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novaIgra();
            
        }

        private void novaIgra()
        {
            BrojacPoteza = 0;
            Zavrsi(true, true, true);
            var igraci=new FrmIgraci();
            igraci.ShowDialog();

            Igrac1=igraci.Igrac1;
            Igrac2=igraci.Igrac2;
        }
    }
}
