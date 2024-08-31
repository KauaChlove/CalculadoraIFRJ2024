using CalculadoraJKP.Utilidades;

namespace CalculadoraJKP
{
    public partial class Form1 : Form
    {
        //--> Cria��o das vari�veis utilizadas na calculadora
        double n1, n2;
        int verif = 0, nB = 0; //A verifica��o � necess�ria para n�o inserir mais de 2 n�meros, o nB para bin�rio
        string operacao = "";
        Calculadora calculos = new Calculadora();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //--> Configura��o dos bot�es de n�mero
        private void btn1_Click(object sender, EventArgs e)
        {
            txtTela.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtTela.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtTela.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTela.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTela.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTela.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTela.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTela.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTela.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTela.Text += "0";
        }

        //--> Configura��o do bot�o para decimal
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtTela.Text += ",";
        }


        //--> Configura��o dos bot�es de opera��es
        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (verif == 0)
            {
                n1 = Convert.ToDouble(txtTela.Text);
                txtTela.Text = "";
                verif = 1;
                operacao = "+";
            }
            else
            {
                MessageBox.Show("Opa! Parece que 2 valores j� foram inseridos.\nPor favor, apague ou conclua a opera��o.");
            }
        }
        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (verif == 0)
            {
                n1 = Convert.ToDouble(txtTela.Text);
                txtTela.Text = "";
                verif = 1;
                operacao = "-";
            }
            else
            {
                MessageBox.Show("Opa! Parece que 2 valores j� foram inseridos.\n Por favor, apague ou conclua a opera��o.");
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (verif == 0)
            {
                n1 = Convert.ToDouble(txtTela.Text);
                txtTela.Text = "";
                verif = 1;
                operacao = "/";
            }
            else
            {
                MessageBox.Show("Opa! Parece que 2 valores j� foram inseridos.\nPor favor, apague ou conclua a opera��o.");
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (verif == 0)
            {
                n1 = Convert.ToDouble(txtTela.Text);
                txtTela.Text = "";
                verif = 1;
                operacao = "x";
            }
            else
            {
                MessageBox.Show("Opa! Parece que 2 valores j� foram inseridos.\nPor favor, apague ou conclua a opera��o.");
            }
        }
        private void btnFatorial_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtTela.Text);
            txtTela.Text = Convert.ToString(Math.Round(calculos.Fatorial(n1), 2));
            verif = 0;
            operacao = "";
        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtTela.Text);
            txtTela.Text = Convert.ToString(Math.Round(calculos.Seno(n1), 2));
            verif = 0;
            operacao = "";
        }

        private void btnCosseno_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtTela.Text);
            txtTela.Text = Convert.ToString(Math.Round(calculos.Cosseno(n1), 2));
            verif = 0;
            operacao = "";
        }

        private void btnTangente_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtTela.Text);
            txtTela.Text = Convert.ToString(Math.Round(calculos.Tangente(n1), 2));
            verif = 0;
            operacao = "";
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            nB = Convert.ToInt32(txtTela.Text);
            txtTela.Text = Convert.ToString(calculos.Binario(nB));
            verif = 0;
            operacao = "";
        }


        //--> Configura��o do bot�o que ir�, propriamente, efetuar a opera��o com switch case
        private void btnIgual_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(txtTela.Text);

            switch (operacao)
            {
                case "+":
                    txtTela.Text = Convert.ToString(Math.Round(calculos.Soma(n1, n2), 2));

                    break;
                case "-":
                    txtTela.Text = Convert.ToString(Math.Round(calculos.Subtracao(n1, n2), 2));
                    break;
                case "/":
                    txtTela.Text = Convert.ToString(Math.Round(calculos.Divisao(n1, n2), 2));
                    break;
                case "x":
                    txtTela.Text = Convert.ToString(Math.Round(calculos.Multiplicacao(n1, n2), 2));
                    break;
                default:

                    break;
            }
            verif = 0;
            operacao = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text.Substring(0, txtTela.Text.Length - 1);
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtTela.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtTela.Text = "";
            operacao = "";
            verif = 0;
            n1 = 0;
            n2 = 0;
        }
    }
}
