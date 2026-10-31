using System.Collections.ObjectModel;

namespace NotatkiMobilne;

public partial class MainPage : ContentPage
{
    public ObservableCollection<string> Notatki { get; set; }

    public MainPage()
    {
        InitializeComponent();

        Notatki = new ObservableCollection<string>
        {
            "Urodziny Ali",
            "Kupić prezent",
            "Przygotować projekt"
        };

        BindingContext = this;
    }

    private void Dodaj_Clicked(object sender, EventArgs e)
    {
        string nowaNotatka = PoleNotatki.Text;

        if (!string.IsNullOrWhiteSpace(nowaNotatka))
        {
            Notatki.Add(nowaNotatka);

            PoleNotatki.Text = string.Empty;
        }
    }
}