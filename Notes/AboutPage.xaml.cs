namespace Notes;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private void IraoGitBtn_Clicked(object sender, EventArgs e)
    {
		Launcher.Default.OpenAsync("https://github.com/FelipeSardinhaMiguel/Notes?tab=readme-ov-file");	
    }
}