
namespace TShockOnAndroid;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        Console.SetOut(new TextOut(ConsoleOut));
	}
}

