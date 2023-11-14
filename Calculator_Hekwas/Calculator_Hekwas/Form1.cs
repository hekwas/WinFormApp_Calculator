using System.Data;

namespace Calculator_Hekwas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "3";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "*";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "/";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string expresie = txtResult.Text;
            DataTable tabel = new DataTable();
            try
            {
                object rezultat = tabel.Compute(expresie, "");
                txtResult.Text = rezultat.ToString();
            }
            catch (Exception ex)
            {
                txtResult.Text = "Eroare, contine string";
                MessageBox.Show(ex.Message);
            }



        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "(";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + ")";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";


        }
    }
}