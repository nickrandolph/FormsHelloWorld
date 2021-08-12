using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;

namespace HelloMaui
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}

		//protected override IWindow CreateWindow(IActivationState activationState)
		//{
		//	Microsoft.Maui.Controls.Compatibility.Forms.Init(activationState);

		//	this.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>()
		//		.SetImageDirectory("Assets");

		//	return new Microsoft.Maui.Controls.Window(new MainPage());
		//}
	}
}
