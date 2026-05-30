namespace Atividade_de_recuperacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            int numero1 = 10;
            int numero2 = 20;
            int resultadoInt = numero1 + numero2;

            string texto1 = "10";
            string texto2 = "20";
            string resultadoString = texto1 + texto2;

            MessageBox.Show("Soma de int: " + resultadoInt + " | Soma de string: " + resultadoString + " string vai juntar os dois textos formando 1020");
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNumero1.Text);
            int n2 = int.Parse(txtNumero2.Text);

            int soma = n1 + n2;

            MessageBox.Show("O resultado da soma matemática é: " + soma);
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero3.Text);

            int resto = numero % 2;

            if (resto == 0)
            {
                MessageBox.Show("O número " + numero + " é PAR!");
            }
            else
            {
                MessageBox.Show("O número " + numero + " é ÍMPAR!");
            }
        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            int numeroFixo = 10;

            int numeroDigitado = int.Parse(txtNumero4.Text);

            if (numeroDigitado == numeroFixo)
            {
                MessageBox.Show("Você digitou exatamente o número 10!");
            }
            else
            {
                MessageBox.Show("O número digitado é diferente de 10.");
            }
        }

        private void btnExercicio5_Click(object sender, EventArgs e)
        {
            int limite = int.Parse(txtNumero5.Text);

            string resultadoFor = "Loop FOR (Contagem fixa): ";
            for (int i = 1; i <= limite; i++)
            {
                resultadoFor += i + " ";
            }

            string resultadoWhile = "Loop WHILE (Até a condição mudar): ";
            int numeroAtual = limite;
            while (numeroAtual >= 2)
            {
                resultadoWhile += numeroAtual + " ";
                numeroAtual = numeroAtual / 2;
            }

            MessageBox.Show(resultadoFor + "\n\n" + resultadoWhile);
        }

        private void btnExercicio6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Problema: LOOP INFINITO\n\n" +
                            "O que acontece: Se esquecermos o i++, a condição (i < 5) nunca muda.\n" +
                            "O computador fica preso rodando o mesmo código para sempre.\n" +
                            "No Windows Forms, isso faz a tela CONGELAR e parar de responder.");
        }

        private void btnExercicio7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CONCEITO DE EVENTO\n\n" +
                            "1. O Evento: É o clique que você acabou de dar neste botão.\n\n" +
                            "2. O que acontece: O Windows Forms avisou o programa que o botão foi clicado. " +
                            "O C# veio até o método 'btnExercicio7_Click' e executou este MessageBox!");
        }

        private void btnExercicio8_Click(object sender, EventArgs e)
        {
            string texto = txtNumero6.Text;

            lblResultado.Text = "Resultado da Label: " + texto;

            MessageBox.Show("Resultado na MessageBox: " + texto, "Aviso Interrompido!");
        }
    }
}
