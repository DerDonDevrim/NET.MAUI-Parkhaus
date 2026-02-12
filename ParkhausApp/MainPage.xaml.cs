using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ParkhausApp
{
    public partial class MainPage : ContentPage
    {
        private ParkingGarage _parkingGarage;
        private ParkingGarage parkingGarage1;
        private ParkingGarage parkingGarage2;
        private ParkingGarage parkingGarage3;

        public MainPage()
        {
            InitializeComponent();
            var random = new Random();


            parkingGarage1 = new ParkingGarage { garageName = "Parkhaus Bahnhof", parkingLots = 50, freeLots = random.Next(1, 51) };
            parkingGarage2 = new ParkingGarage { garageName = "Parkhaus Spital", parkingLots = 50, freeLots = random.Next(1, 51) };
            parkingGarage3 = new ParkingGarage { garageName = "Parkhaus City", parkingLots = 50, freeLots = random.Next(1, 51) };

            parking1.Text = $"{parkingGarage1.garageName}\n{parkingGarage1.freeLots}/{parkingGarage1.parkingLots}";
            parking2.Text = $"{parkingGarage2.garageName}\n{parkingGarage2.freeLots}/{parkingGarage2.parkingLots}";
            parking3.Text = $"{parkingGarage3.garageName}\n{parkingGarage3.freeLots}/{parkingGarage3.parkingLots}";
        }
        private async void chose(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Barrier());

        }


    }
}