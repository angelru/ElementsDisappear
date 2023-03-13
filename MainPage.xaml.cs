using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;

        for (int i = 0; i < 10; i++)
        {
            TestCBs.Add(new TestCB
            {
                Title = "Mr.Robot",
                Image = "https://flxt.tmsimg.com/assets/p11710290_b1t_v8_aa.jpg",
                Hours = new List<string>
                {
                    "10:20",
                    "15:20",
                    "10:20",
                    "15:20",
                    "10:20",
                    "15:20",
                }
            });
        }
    }

    public ObservableCollection<TestCB> TestCBs { get; set; } = new();

}

public class TestCB
{
    public string Title { get; set; }
    public string Image { get; set; }
    public List<string> Hours { get; set; }
}

