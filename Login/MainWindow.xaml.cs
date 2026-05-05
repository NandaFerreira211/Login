using System.Windows;

namespace Login;

public partial class MainWindow : Window

{
    // Início Main
    private const string USUARIO_PADRAO = "admin";
    private const string SENHA_PADRAO = "admin";

    public MainWindow()
    {
        InitializeComponent();
    }

    private void BotaoLogin(object sender, RoutedEventArgs e)
    {
        // Início BotaoLogin
        var usuarioDigitado = tbUsuario.Text;
        var senhaDigitada = tbSenha.Text;

        if (string.IsNullOrWhiteSpace(usuarioDigitado) || string.IsNullOrWhiteSpace(senhaDigitada))
        {
            MessageBox.Show("Usuário e senha precisam ser informados", "Informação pendente");
            return;
        }

        if (usuarioDigitado != USUARIO_PADRAO || senhaDigitada != SENHA_PADRAO)
        {
            // True 

            MessageBox.Show("Usuario e/ou senha estão errados", "Erro");
            return;
        }

        MessageBox.Show("Boas vindas , Admin ");
        var novaJanela = new Painel();
        novaJanela.Show();
    } // Fim BotaoLogin


    private void BotaoCadastro(object sender, RoutedEventArgs e)
    {
        var novaJanela = new Cadastro();
        novaJanela.Show();
    }
} // Fim Main