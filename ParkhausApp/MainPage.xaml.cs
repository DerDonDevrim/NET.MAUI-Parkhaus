using System.Threading.Tasks;

namespace ParkhausApp
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
           InitializeComponent();
        }
        private async void OpenBarrier(object sender, EventArgs e)
        {
            barrier.Text = "Schranke offen";
            await DisplayAlert("Meldung", "Du hast erfolgreich ein Ticket gelöst und kannst nun einfahren", "OK");
        }


    }
}
