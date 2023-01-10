using Kotlin.IO;

namespace TShockOnAndroid;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
    protected override void OnStart()
    {
        Start();
    }
    public static async Task Start()
    {
        if (await Permissions.CheckStatusAsync<Permissions.StorageWrite>() == PermissionStatus.Denied)
        {
            if (await Permissions.RequestAsync<Permissions.StorageWrite>() == PermissionStatus.Denied)
            {
                Environment.Exit(0);
            }
        }
        Environment.CurrentDirectory = FileSystem.AppDataDirectory;
        TerrariaApi.Server.Program.Main(new string[0]);
    }
}
