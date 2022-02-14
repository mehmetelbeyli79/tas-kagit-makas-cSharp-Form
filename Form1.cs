using tas_kagit_makas.Properties;

namespace tas_kagit_makas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        public void tas_secim()
        {
            pictureBox1.Image = Resources.tas;
            o_secim = "tas";
        }
        public void kagit_secim()
        {
            pictureBox1.Image = Resources.kagit;
            o_secim = "kagit";
        }
        public void makas_secim()
        {
            pictureBox1.Image =Properties.Resources.makas;
            o_secim = "makas";
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tas_secim();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            kagit_secim();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            makas_secim();
        }

        string b_secim;
        string o_secim;
        int b_puan=0;
        int o_puan=0;

        public void Bilgisayar_Secim()
        {
            Random rnd = new Random();
            int rastgele = rnd.Next(0, 3);
            string[] secim = { "tas", "kagit", "makas" };
            b_secim = secim[rastgele];
            if (rastgele == 0)
            {
                pictureBox2.Image = Resources.tas;
            }
            else if (rastgele == 1)
            {
                pictureBox2.Image = Resources.kagit;
            }
            else
            {
                pictureBox2.Image = Resources.makas;
            }
        }

        public string hesapla(string x,string y)
        {
            if(x=="kagit" && y=="tas" || x == "tas" && y == "makas" || x == "makas" && y == "kagit")
            {
                o_puan++;
                //MessageBox.Show("Çalýþýyor");
                return "Oyuncu Kazandý";
            }
            else if(x==y)
            {
                return "Berabere";
            }
            else
            {
                b_puan++;
                return "Bilgisayar Kazandý";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Bilgisayar_Secim();
            string sonuc=hesapla(o_secim, b_secim);
            label7.Text = sonuc;
            label4.Text=Convert.ToString(o_puan);
            label6.Text = Convert.ToString(b_puan); 

            if(o_puan==10 || b_puan==10)
            {
                if(o_puan>b_puan)
                {
                    label7.Text = "Oyuncu KAZANDI...";
                    MessageBox.Show("Oyuncu KAZANDI");
                    
                }
                else
                {
                    label7.Text = "Bilgisayar KAZANDI";
                    MessageBox.Show("Bilgisayar KAZANDI");
                }

                o_puan = 0;
                b_puan = 0;
            }
        }
    }
}