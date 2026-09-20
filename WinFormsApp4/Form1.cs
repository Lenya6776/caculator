namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>();
        string s = "";
        int oper = 0;


        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            s = textBox1.Text;
            textBox1.Text = "";
            if (s.Contains('+'))
            {
                list = s.Split('+').ToList();
                foreach (string i in list)
                {
                    oper += Convert.ToInt32(i);
                }
                textBox1.Text = oper.ToString();
                oper = 0;
                list.RemoveAll(s => s.Contains("+"));
            }
            else if (s.Contains('-'))
            {
                list = s.Split("-").ToList();
                foreach (string i in list)
                {
                    oper += Convert.ToInt32(i);
                    break;
                }
                oper -= Convert.ToInt32(list[1]);
                textBox1.Text = oper.ToString();
                oper = 0;
                list.RemoveAll(s => s.Contains("-"));
            }
            else if (s.Contains('*'))
            {
                list = s.Split("*").ToList();
                foreach (string i in list)
                {
                    oper += Convert.ToInt32(i);
                    break;
                }
                oper *= Convert.ToInt32(list[1]);
                textBox1.Text = oper.ToString();
                oper = 0;
                list.RemoveAll(s => s.Contains("*"));
            }
            else if (s.Contains('/'))
            {
                list = s.Split("/").ToList();
                foreach (string i in list)
                {
                    oper += Convert.ToInt32(i);
                    break;
                }
                if (Convert.ToInt32(list[1]) != 0)
                {
                    oper /= Convert.ToInt32(list[1]);
                    textBox1.Text = oper.ToString();
                }
                else
                {
                    Delete();
                }
                if (Convert.ToInt32(list[1]) > oper)
                {
                    oper /= Convert.ToInt32(list[1]);
                }
                oper = 0;
                list.RemoveAll(s => s.Contains("/"));
            }
            

        }

        async void Delete()
        {
            textBox1.Text = "Hа ноль меня не учили делить";

            await Task.Delay(2000);

            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }
    }
}
