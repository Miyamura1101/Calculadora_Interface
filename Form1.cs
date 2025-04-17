using MARS.Models.Opera��es.Inteiro;
using MARS.Models.Opera��es.Float;
using MARS.Models.Convers�es;
using MARS.Models.Temperatura;
namespace Calculadora_Interface
{
    public partial class Calculadora : Form
    {
        private float Resultado { get; set; }
        private float Valor { get; set; }
        private Ope OperacaoSelecionada { get; set; }
        private enum Ope
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        private Temperatura TemperaturaSelecionada { get; set; }
        private enum Temperatura
        {
            Celsius,
            Fahrenheit,
            Kelvin
        }
        private Conversao ConversaoSelecionada { get; set; }
        private enum Conversao
        {
            Hexadecimal,
            Decimal,
            Octal,
            Binario
        }
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
            txtResultado_T.Text += "0";
            txtResultado_P.Text += "0";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
            txtResultado_T.Text += "1";
            txtResultado_P.Text += "1";

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
            txtResultado_T.Text += "2";
            txtResultado_P.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
            txtResultado_T.Text += "3";
            txtResultado_P.Text += "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
            txtResultado_T.Text += "4";
            txtResultado_P.Text += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
            txtResultado_T.Text += "5";
            txtResultado_P.Text += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
            txtResultado_T.Text += "6";
            txtResultado_P.Text += "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
            txtResultado_T.Text += "7";
            txtResultado_P.Text += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
            txtResultado_T.Text += "8";
            txtResultado_P.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
            txtResultado_T.Text += "9";
            txtResultado_P.Text += "9";
        }
        private void btA_Click(object sender, EventArgs e)
        {
            txtResultado_P.Text += "A";
        }

        private void btB_Click(object sender, EventArgs e)
        {
            txtResultado_P.Text += "B";
        }

        private void btC_Click(object sender, EventArgs e)
        {
            txtResultado_P.Text += "C";
        }

        private void btD_Click(object sender, EventArgs e)
        {
            txtResultado_P.Text += "D";
        }

        private void btE_Click(object sender, EventArgs e)
        {

            txtResultado_P.Text += "E";
        }

        private void btF_Click(object sender, EventArgs e)
        {
            txtResultado_P.Text += "F";
        }
        private void Adicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Ope.Adicao;
            Valor = float.Parse(txtResultado.Text);
            txtResultado.Text = "";
            Logica.Text = "+";
        }

        private void Subtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Ope.Subtracao;
            Valor = float.Parse(txtResultado.Text);
            txtResultado.Text = "";
            Logica.Text = "-";
        }

        private void Multiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Ope.Multiplicacao;
            Valor = float.Parse(txtResultado.Text);
            txtResultado.Text = "";
            Logica.Text = "*";
        }

        private void Divisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Ope.Divisao;
            Valor = float.Parse(txtResultado.Text);
            txtResultado.Text = "";
            Logica.Text = "/";
        }
        private void btVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
                txtResultado_T.Text += ",";
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            txtResultado_T.Text = "";
            txtResultado_P.Text = "";
            Logica.Text = "";
        }

        private void igual_Click(object sender, EventArgs e)
        {

            float SegundoValor = float.Parse(txtResultado.Text);

            switch (OperacaoSelecionada)
            {
                case Ope.Adicao:
                    Resultado = Soma_F.Operacao(Valor, SegundoValor);
                    break;
                case Ope.Subtracao:
                    Resultado = Diminui��o_F.Operacao(Valor, SegundoValor);
                    break;
                case Ope.Divisao:
                    Resultado = Divis�o_F.Operacao(Valor, SegundoValor);
                    break;
                case Ope.Multiplicacao:
                    Resultado = Multiplica��o_F.Operacao(Valor, SegundoValor);
                    break;
            }

            Logica.Text = "=";
            txtResultado.Text = Resultado.ToString("0.##");
        }

        private void btCelsius_Click(object sender, EventArgs e)
        {
            TemperaturaSelecionada = Temperatura.Celsius;
            Cel.Text = "|C�";
            Fa.Text = "F�";
            Kel.Text = "K�";
        }

        private void btFahrenheit_Click(object sender, EventArgs e)
        {
            TemperaturaSelecionada = Temperatura.Fahrenheit;
            Cel.Text = "C�";
            Fa.Text = "|F�";
            Kel.Text = "K�";
        }

        private void btKelvin_Click(object sender, EventArgs e)
        {
            TemperaturaSelecionada = Temperatura.Kelvin;
            Cel.Text = "C�";
            Fa.Text = "F�";
            Kel.Text = "|K�";
        }

        private void btIgual_T_Click(object sender, EventArgs e)
        {
            switch (TemperaturaSelecionada)
            {
                case Temperatura.Celsius:
                    Celsius.Text = txtResultado_T.Text;
                    Fahrenheit.Text = Celsius_Fahrenheit.Operacao(float.Parse(txtResultado_T.Text));
                    Kelvin.Text = Celsius_Kelvin.Operacao(float.Parse(txtResultado_T.Text));
                    break;
                case Temperatura.Kelvin:
                    Celsius.Text = Kelvin_Celsius.Operacao(float.Parse(txtResultado_T.Text));
                    Fahrenheit.Text = Kelvin_Fahrenheit.Operacao(float.Parse(txtResultado_T.Text));
                    Kelvin.Text = txtResultado_T.Text;
                    break;
                case Temperatura.Fahrenheit:
                    Celsius.Text = fahrenheit_celsius.Operacao(float.Parse(txtResultado_T.Text));
                    Fahrenheit.Text = txtResultado_T.Text;
                    Kelvin.Text = fahrenheit_kelvin.Operacao(float.Parse(txtResultado_T.Text));
                    break;
            }
        }

        private void btHexadecimal_Click(object sender, EventArgs e)
        {
            txtResultado_P.Text = "";

            ConversaoSelecionada = Conversao.Hexadecimal;
            HEX.Text = "|HEX";
            DEC.Text = "DEC";
            OCT.Text = "OCT";
            BIN.Text = "BIN";

            bt0_P.Enabled = true;
            bt0_P.BackColor = Color.Transparent;

            bt1_P.Enabled = true;
            bt1_P.BackColor = Color.Transparent;

            bt2_P.Enabled = true;
            bt2_P.BackColor = Color.Transparent;

            bt3_P.Enabled = true;
            bt3_P.BackColor = Color.Transparent;

            bt4_P.Enabled = true;
            bt4_P.BackColor = Color.Transparent;

            bt5_P.Enabled = true;
            bt5_P.BackColor = Color.Transparent;

            bt6_P.Enabled = true;
            bt6_P.BackColor = Color.Transparent;

            bt7_P.Enabled = true;
            bt7_P.BackColor = Color.Transparent;

            bt8_P.Enabled = true;
            bt8_P.BackColor = Color.Transparent;

            bt9_P.Enabled = true;
            bt9_P.BackColor = Color.Transparent;

            btA.Enabled = true;
            btA.BackColor = Color.Transparent;

            btB.Enabled = true;
            btB.BackColor = Color.Transparent;

            btC.Enabled = true;
            btC.BackColor = Color.Transparent;

            btD.Enabled = true;
            btD.BackColor = Color.Transparent;

            btE.Enabled = true;
            btE.BackColor = Color.Transparent;

            btF.Enabled = true;
            btF.BackColor = Color.Transparent;
        }

        private void btDecimal_Click(object sender, EventArgs e)
        {
            txtResultado_P.Text = "";

            ConversaoSelecionada = Conversao.Decimal;
            HEX.Text = "HEX";
            DEC.Text = "|DEC";
            OCT.Text = "OCT";
            BIN.Text = "BIN";

            bt0_P.Enabled = true;
            bt0_P.BackColor = Color.Transparent;

            bt1_P.Enabled = true;
            bt1_P.BackColor = Color.Transparent;

            bt2_P.Enabled = true;
            bt2_P.BackColor = Color.Transparent;

            bt3_P.Enabled = true;
            bt3_P.BackColor = Color.Transparent;

            bt4_P.Enabled = true;
            bt4_P.BackColor = Color.Transparent;

            bt5_P.Enabled = true;
            bt5_P.BackColor = Color.Transparent;

            bt6_P.Enabled = true;
            bt6_P.BackColor = Color.Transparent;

            bt7_P.Enabled = true;
            bt7_P.BackColor = Color.Transparent;

            bt8_P.Enabled = true;
            bt8_P.BackColor = Color.Transparent;

            bt9_P.Enabled = true;
            bt9_P.BackColor = Color.Transparent;

            btA.Enabled = false;

            btB.Enabled = false;

            btC.Enabled = false;

            btD.Enabled = false;

            btE.Enabled = false;

            btF.Enabled = false;
        }

        private void btOctal_Click(object sender, EventArgs e)
        {
            txtResultado_P.Text = "";

            ConversaoSelecionada = Conversao.Octal;
            HEX.Text = "HEX";
            DEC.Text = "DEC";
            OCT.Text = "|OCT";
            BIN.Text = "BIN";

            bt0_P.Enabled = true;
            bt0.BackColor = Color.Transparent;

            bt1_P.Enabled = true;
            bt1_P.BackColor = Color.Transparent;

            bt2_P.Enabled = true;
            bt2_P.BackColor = Color.Transparent;

            bt3_P.Enabled = true;
            bt3_P.BackColor = Color.Transparent;

            bt4_P.Enabled = true;
            bt4_P.BackColor = Color.Transparent;

            bt5_P.Enabled = true;
            bt5_P.BackColor = Color.Transparent;

            bt6_P.Enabled = true;
            bt6_P.BackColor = Color.Transparent;

            bt7_P.Enabled = true;
            bt7_P.BackColor = Color.Transparent;

            bt8_P.Enabled = false;

            bt9_P.Enabled = false;

            btA.Enabled = false;

            btB.Enabled = false;

            btC.Enabled = false;

            btD.Enabled = false;

            btE.Enabled = false;

            btF.Enabled = false;
        }

        private void tbBinario_Click(object sender, EventArgs e)
        {
            txtResultado_P.Text = "";

            ConversaoSelecionada = Conversao.Binario;
            HEX.Text = "HEX";
            DEC.Text = "DEC";
            OCT.Text = "OCT";
            BIN.Text = "|BIN";

            bt0_P.Enabled = true;
            bt0.BackColor = Color.Transparent;

            bt1_P.Enabled = true;
            bt1_P.BackColor = Color.Transparent;

            bt2_P.Enabled = false;

            bt3_P.Enabled = false;

            bt4_P.Enabled = false;

            bt5_P.Enabled = false;

            bt6_P.Enabled = false;

            bt7_P.Enabled = false;

            bt8_P.Enabled = false;

            bt9_P.Enabled = false;

            btA.Enabled = false;

            btB.Enabled = false;

            btC.Enabled = false;

            btD.Enabled = false;

            btE.Enabled = false;

            btF.Enabled = false;
        }

        private void btIgual_P_Click(object sender, EventArgs e)
        {
            switch (ConversaoSelecionada)
            {
                case Conversao.Hexadecimal:
                    Hexadecimal.Text = txtResultado_P.Text;
                    Bin_Label.Text = Hexa.Hexa_Bin(txtResultado_P.Text);
                    Octal_Label.Text = Hexa.Hexa_Octal(txtResultado_P.Text);
                    Decimal.Text = Hexa.Hexa_Decimal(txtResultado_P.Text);
                    break;
                case Conversao.Octal:
                    Octal_Label.Text = txtResultado_P.Text;
                    Bin_Label.Text = Octal.Octal_Bin(txtResultado_P.Text);
                    Hexadecimal.Text = Octal.Octal_Hexa(txtResultado_P.Text);
                    Decimal.Text = Octal.Octal_Decimal(txtResultado_P.Text);
                    break;
                case Conversao.Binario:
                    Bin_Label.Text = txtResultado_P.Text;
                    Octal_Label.Text = Binario.Bin_Octal(txtResultado_P.Text);
                    Hexadecimal.Text = Binario.Bin_Hexa(txtResultado_P.Text);
                    Decimal.Text = Binario.Bin_Decimal(txtResultado_P.Text);
                    break;
                case Conversao.Decimal:
                    Decimal.Text = txtResultado_P.Text;
                    Bin_Label.Text = Decimal_1.Decimal_Bin(txtResultado_P.Text);
                    Hexadecimal.Text = Decimal_1.Decimal_Hexa(txtResultado_P.Text);
                    Octal_Label.Text = Decimal_1.Decimal_Octal(txtResultado_P.Text);
                    break;
            }
        }
    }
}
