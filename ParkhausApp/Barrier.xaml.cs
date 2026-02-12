namespace ParkhausApp;

public partial class Barrier : ContentPage
{
    private Ticket? _currentTicket;
    private int _nextTicketNumber = 1;

    public Barrier()
    {
        InitializeComponent();


    }
    private async void OpenBarrier(object sender, EventArgs e)
    {
        barrier.Text = "Schranke offen";
        _currentTicket = new Ticket
        {
            ticketNr = _nextTicketNumber++,
            entryTime = DateTime.Now,
            isPaid = false

        };
        await DisplayAlert("Ticket", "Du hast erfolgreich ein Ticket gelöst und kannst nun einfahren", "OK");
        await Navigation.PushAsync(new Dashboard(_currentTicket));

        barrier.Text = "Schranke geschlossen";
    }


}

