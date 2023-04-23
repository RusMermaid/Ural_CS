
using Ural_CS_Rider;

namespace Ural_IDE;


public partial class MainPage : ContentPage
{
	int count = 0;




	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        matrica c = new matrica(2);
        c[1, 1] = new drobch64(8);
        c[1, 0] = new drobch64(-9);
        short n = 60;

        matrica d = new matrica(3);

        d[0, 0] = new drobch64(2);
        d[0, 1] = new drobch64(-2);
        d[1, 0] = new drobch64(4);
        d[1, 1] = new drobch64(6);
        d[2, 1] = new drobch64(10);
        d[2, 2] = new drobch64(2);
        d[2, 0] = new drobch64(-10);
        // StrIndexOutOfRangeError err = new StrIndexOutOfRangeError(0, 0);
        //err.Execute();

        label2.Text = MainClass.Main();
        //CounterBtn.Text  = MainClass.Main();

        SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


