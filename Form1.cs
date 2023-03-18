namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Calculul IMC

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String cm, kg;
                cm = textBox1.Text;
                kg = textBox2.Text;

                double centi = Convert.ToDouble(cm);
                double kilo = Convert.ToDouble(kg);

                if (centi > 0 && kilo > 0)
                {
                    double imc = kilo / (centi * centi);

                    if (imc < 18.5)
                    {
                        rez.Text = "Indexul este " + imc + ". Subponderal.";
                        return;
                    }
                    else
                          if (imc >= 18.5 && imc <= 25)
                    {
                        rez.Text = "Indexul este " + imc + ". Greutate normala.";
                        return;
                    }
                    else
                          if (imc >= 25 && imc <= 30)
                    {
                        rez.Text = "Indexul este " + imc + ". Exces de greutate.";
                        return;
                    }
                    else
                          if (imc >= 30)
                    {
                        rez.Text = "Indexul este " + imc + ". Obezitate.";
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Introduceti variabile pozitive !!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Date incorecte.");
            }
        }

        // Butonul de resetare

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            rez.Text = " ";
        }
    }
}