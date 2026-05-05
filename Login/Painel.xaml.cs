using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Login;

public partial class Painel : Window
{


    public Painel()
    {
        InitializeComponent();

    }

    private void BotaoBuscarImagem(object sender, RoutedEventArgs e)
    {
        string nomeEstudante = tbEstudanteNome.Text;

        // Estrutura Switch - Case
        switch (nomeEstudante.ToLower())
        {
            case "rebeca spinola":
               
                imagemAluna.Source = CriarImagem("https://doogspet.com/wp-content/uploads/freepik_edit-19-1.jpg");
                break;
            case "sarah":
                imagemAluna.Source =
                    CriarImagem(
                        "https://premierpet.com.br/wp-content/uploads/2025/04/model-banner-dicasprimeirocachorro-desktop-v1-768x213.png.webp");
                break;
            case"yatra":
                imagemAluna.Source = CriarImagem("https://admin.cnnbrasil.com.br/wp-content/uploads/sites/12/2025/05/gato-laranja-e1748043537291.jpg?w=1200&h=630&crop=1");
                break;
            case"maria":
                imagemAluna.Source = CriarImagem("https://img.olx.com.br/images/18/183586304678119.jpg");
                break;
            case"laura":
                imagemAluna.Source =
                    CriarImagem(
                        "https://png.pngtree.com/png-clipart/20241117/original/pngtree-black-panther-clipart-illustration-realistic-animal-for-digital-projects-png-image_17166894.png");
                break;
            case "isabela":
                imagemAluna.Source =
                    CriarImagem(
                        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS3t3tEdZ5dYGB1BNk9T6NvY6DvZMKwJIz6fl_eb6eaMYh3LXMuFF6i_lSxBfpSBf2oyoFZeDHtFvrcWETZM251X94di09PbDnUj_lyUg&s=10");
                break;
                case "adrielly":
                imagemAluna.Source =
                    CriarImagem("https://www.infoescola.com/wp-content/uploads/2008/05/capivara-119654188.jpg");
                    break;
                case "rebecca":
                    imagemAluna.Source =
                    CriarImagem("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRjy2jkGg019HoXnsiZV8ffbmc_EAK5lDYqrw&s") ;
                    break;
                case "joyce":
                imagemAluna.Source =
                    CriarImagem(
                        "https://noticiasdatv.uol.com.br/media/_versions/artigos/tom-holland-homem-aranha-longe-de-casa-sony-pictures_fixed_large.jpg");
                    break;
                default:
                imagemAluna.Source = CriarImagem("pack://application:,,,/images/padrao.jpg");
                    break;
        }
        
    }

    private static BitmapImage CriarImagem(string url)
    {
        var ImageBitmap = new BitmapImage();
        ImageBitmap.BeginInit();
        ImageBitmap.UriSource= new Uri(url);
        ImageBitmap.EndInit();
        return ImageBitmap;
            
    }
}   