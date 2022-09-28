namespace WinFormsIntro;

static class Program
{
	[STAThread] // Single Thread
	static void Main()
	{
		ApplicationConfiguration.Initialize();
		Application.Run(new Form1());
	}
}