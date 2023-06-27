using MauiCalculator.MVVM;

namespace MauiCalculator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CalcView();
	}
}
