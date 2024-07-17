namespace stajornekler8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (txtsayi1.Text == "" || txtsayi2.Text == "")
            {
                MessageBox.Show("Lütfen sayý deðeri giriniz!");
            }
            else
            {
                double sayi1, sayi2, sonuc;
                sayi1 = Convert.ToDouble(txtsayi1.Text);
                sayi2 = Convert.ToDouble(txtsayi2.Text);

                if (rdbtntopla.Checked)
                {
                    sonuc = (sayi1 + sayi2);
                    lblsonuc.Text = sonuc.ToString();
                }
                if (rdbtncikar.Checked)
                {
                    sonuc = (sayi1 - sayi2);
                    lblsonuc.Text = sonuc.ToString();
                }
                if (rdbtncarp.Checked)
                {
                    sonuc = (sayi1 * sayi2);
                    lblsonuc.Text = sonuc.ToString();
                }
                if (rdbtnbol.Checked)
                {
                    sonuc = (sayi1 / sayi2);
                    lblsonuc.Text = sonuc.ToString();
                }
            }

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtsayi1.Clear();
            txtsayi2.Clear();

            lblsonuc.Text = "";
        }
    }
}