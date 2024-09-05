namespace azer_bülbül_başaramadım

{
    public partial class Form1 : Form
    {

        private List<int> bilgisayarSayilari;
        private List<int> oyuncuSayilari;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bilgisayarSayilari = RastgeleSayilarUret(10);
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (OyuncuSayiKontrol())
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                oyuncuSayilari = new List<int>();
                oyuncuSayilari.Add(Convert.ToInt32(textBox1.Text));
                oyuncuSayilari.Add(Convert.ToInt32(textBox2.Text));
                oyuncuSayilari.Add(Convert.ToInt32(textBox3.Text));
                oyuncuSayilari.Add(Convert.ToInt32(textBox4.Text));
                oyuncuSayilari.Add(Convert.ToInt32(textBox5.Text));

                listBox1.Items.AddRange(oyuncuSayilari.Select(x => x.ToString()).ToArray());
                listBox2.Items.AddRange(bilgisayarSayilari.Select(x => x.ToString()).ToArray());

                int eslesmeSayisi = oyuncuSayilari.Intersect(bilgisayarSayilari).Count();
                MessageBox.Show("BİZ KAVUŞTUK " + eslesmeSayisi + " ECE ÇOK MUTLU");
            }
            else
            {
                MessageBox.Show("Lütfen birbirinden farklı 5 sayı girin.");
            }
        }

        private bool OyuncuSayiKontrol()
        {
            List<int> sayilar = new List<int> {
                Convert.ToInt32(textBox1.Text),
                Convert.ToInt32(textBox2.Text),
                Convert.ToInt32(textBox3.Text),
                Convert.ToInt32(textBox4.Text),
                Convert.ToInt32(textBox5.Text)
            };

            if (sayilar.Distinct().Count() == sayilar.Count())
            {
                return true;
            }

            return false;
        }

        private List<int> RastgeleSayilarUret(int sayiSayisi)
        {
            Random rnd = new Random();
            List<int> sayilar = new List<int>();

            while (sayilar.Count < sayiSayisi)
            {
                int rastgeleSayi = rnd.Next(1, 100);

                if (!sayilar.Contains(rastgeleSayi))
                {
                    sayilar.Add(rastgeleSayi);
                }
            }

            return sayilar;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
