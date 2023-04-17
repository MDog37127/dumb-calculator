namespace ohboi
{
    public partial class Form1 : Form
    {
        string calcs = "";
        Solver calculation = new Solver();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " " + Environment.NewLine + "------------------" + Environment.NewLine;
            calcs = "";
            calculation.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = calcs + "1" + Environment.NewLine + "------------------" + Environment.NewLine;
            calcs += "1";
            calculation.Accumulate("1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = calcs + "4" + Environment.NewLine + "------------------" + Environment.NewLine;
            calcs += "4";
            calculation.Accumulate("4");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = calcs + "-" + Environment.NewLine + "------------------" + Environment.NewLine;
            calcs += "-";
            calculation.Accumulate("!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = calcs + "2" + Environment.NewLine + "------------------" + Environment.NewLine;
            calcs += "2";
            calculation.Accumulate("2");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = calcs + "5" + Environment.NewLine + "------------------" + Environment.NewLine;
            calcs += "5";
            calculation.Accumulate("5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = calcs + "7" + Environment.NewLine + "------------------" + Environment.NewLine;
            calcs += "7";
            calculation.Accumulate("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = calcs + "8" + Environment.NewLine + "------------------" + Environment.NewLine;
            calcs += "8";
            calculation.Accumulate("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = calcs + "%" + Environment.NewLine + "------------------" + Environment.NewLine;
            calcs += "%";
            calculation.Accumulate("%");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = calcs + "3" + Environment.NewLine + "------------------" + Environment.NewLine;
            calcs += "3";
            calculation.Accumulate("3");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = calcs + "6" + Environment.NewLine + "------------------" + Environment.NewLine;
            calcs += "6";
            calculation.Accumulate("6");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = calcs + "9" + Environment.NewLine + "------------------" + Environment.NewLine;
            calcs += "9";
            calculation.Accumulate("9");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = calcs + "/" + Environment.NewLine + "------------------" + Environment.NewLine;
            calcs += "/";
            calculation.Accumulate("/");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = calcs + "+" + Environment.NewLine + "------------------" + Environment.NewLine;
            calcs += "+";
            calculation.Accumulate("+");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = calcs + "-" + Environment.NewLine + "------------------" + Environment.NewLine;
            calcs += "-";
            calculation.Accumulate("-");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = calcs + "*" + Environment.NewLine + "------------------" + Environment.NewLine;
            calcs += "*";
            calculation.Accumulate("*");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = calcs + "0" + Environment.NewLine + "------------------" + Environment.NewLine;
            calcs += "0";
            calculation.Accumulate("0");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = calcs + "." + Environment.NewLine + "------------------" + Environment.NewLine;
            calcs += ".";
            calculation.Accumulate(".");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string final = Convert.ToString(calculation.Solve());
            textBox1.Text = calcs + "" + Environment.NewLine + "------------------" + Environment.NewLine + final;
        }
    }
}