using Maui_in_Action.Classes;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace Maui_in_Action;

public partial class CarouselViewPage : ContentPage
{
    private const string monkeyUrl = "https://montemagno.com/monkeys.json";
    private readonly HttpClient httpClient = new HttpClient();

    public ObservableCollection<Monkey> Monkeys { get; set; } = new ObservableCollection<Monkey>();
    public CarouselViewPage()
	{
		InitializeComponent();

        BindingContext = this;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        var monkeyJson = await httpClient.GetStringAsync(monkeyUrl);
        var monkeys = JsonConvert.DeserializeObject<Monkey[]>(monkeyJson);

        Monkeys.Clear();

        foreach (var monkey in monkeys)
        {
            Monkeys.Add(monkey);
        }
    }
}