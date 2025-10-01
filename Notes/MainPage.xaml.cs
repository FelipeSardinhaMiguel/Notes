namespace Notes
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string caminho = Path.Combine(FileSystem.AppDataDirectory, "arquivo");

        public MainPage()
        {
            InitializeComponent();

            if(File.Exists(caminho))
                CaixaEditor.Text = File.ReadAllText(caminho);

        }

        private void ApagarTextBtn_Clicked(object sender, EventArgs e)
        {

            if (File.Exists(caminho))
            {
                DisplayAlert("Arquivo apagado", "Arquivo apagado com sucesso", "OK");
                File.Delete(caminho);
                CaixaEditor.Text = null; //ou CaixaEditor.Text = ""
            }
            else
                DisplayAlert("Arquivo não existente", "Não há arquivo para deletar", "OK");
            // deu certo
        }

        private void SalvarTextBtn_Clicked(object sender, EventArgs e)
        {
            String conteudo = CaixaEditor.Text;
            File.WriteAllText(caminho, conteudo);
            DisplayAlert("Conteudo salvo", $"Seu arquivo foi salvo em {Path.GetFileName(caminho)} na pasta {caminho}", "Ok");
            
        }

    }

}
