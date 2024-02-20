namespace Calculator
{
    public partial class Form1 : Form
    {
        double enterfirstvalue, entersecondvalue;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 360;
            txtResult.Width = 318;
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (num.Text == "0")
                {
                    if (!txtResult.Text.Contains("."))
                        txtResult.Text = txtResult.Text + num.Text;
                }
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;
                }
            }
        }

        private void numberoperator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            enterfirstvalue = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            txtResult.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            entersecondvalue = Convert.ToDouble(txtResult.Text);
            switch (op)
            {
                case "+":
                    txtResult.Text = (enterfirstvalue + entersecondvalue).ToString();
                    break;
                case "-":
                    txtResult.Text = (enterfirstvalue - entersecondvalue).ToString();
                    break;
                case "*":
                    txtResult.Text = (enterfirstvalue * entersecondvalue).ToString();
                    break;
                case "/":
                    txtResult.Text = (enterfirstvalue / entersecondvalue).ToString();
                    break;
                case "Mod":
                    txtResult.Text = (enterfirstvalue % entersecondvalue).ToString();
                    break;
                case "Exp":
                    double i = Convert.ToDouble(txtResult.Text);
                    double j = entersecondvalue;
                    txtResult.Text = Math.Exp(i * Math.Log(j * 4)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";

            string f, s;

            f = Convert.ToString(enterfirstvalue);
            s = Convert.ToString(entersecondvalue);

            f = "";
            s = "";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * q);
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            }

            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 360;
            txtResult.Width = 318;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Confirm that you want to exit", "Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.1605";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtResult.Text);
            logg = Math.Log10(logg);
            txtResult.Text = Convert.ToString(logg);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtResult.Text);
            sq = Math.Sqrt(sq);
            txtResult.Text = Convert.ToString(sq);
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            double x2 = Convert.ToDouble(txtResult.Text);
            x2 = x2 * x2;
            txtResult.Text = Convert.ToString(x2);
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtResult.Width = 674;
            this.Width = 719;
        }

        private void btnx3_Click(object sender, EventArgs e)
        {
            double x3 = Convert.ToDouble(txtResult.Text);
            x3 = x3 * x3 * x3;
            txtResult.Text = Convert.ToString(x3);
        }

        private void bnSinh_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtResult.Text);
            sq = Math.Sinh(sq);
            txtResult.Text = Convert.ToString(sq);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtResult.Text);
            sq = Math.Sin(sq);
            txtResult.Text = Convert.ToString(sq);
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtResult.Text);
            sq = Math.Cosh(sq);
            txtResult.Text = Convert.ToString(sq);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtResult.Text);
            sq = Math.Cos(sq);
            txtResult.Text = Convert.ToString(sq);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtResult.Text);
            sq = Math.Tanh(sq);
            txtResult.Text = Convert.ToString(sq);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtResult.Text);
            sq = Math.Tan(sq);
            txtResult.Text = Convert.ToString(sq);
        }



        private void btn1x_Click(object sender, EventArgs e)
        {
            double a = 1.0 / Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(a);
        }

        private void btnInx_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtResult.Text);
            sq = Math.Log(sq);
            txtResult.Text = Convert.ToString(sq);
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtResult.Text) / Convert.ToDouble(100);
            txtResult.Text = Convert.ToString(a);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txtResult.Text);
            int i2 = (int)dec;
            txtResult.Text = Convert.ToString(i2);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 2);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 8);
        }
    }
}
