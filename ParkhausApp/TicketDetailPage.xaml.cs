namespace ParkhausApp;

public partial class TicketDetailPage : ContentPage
{
	private Ticket _ticket;
	public TicketDetailPage(Ticket ticket)
	{
		InitializeComponent();
		_ticket = ticket;
		ticketNumberLabel.Text = $"Ticket Nummer: {_ticket.ticketNr}";
		entryTimeLabel.Text = $"Eintrittszeit: {_ticket.entryTime}";
        isPaidLabel.Text = $"Status: {_ticket.isPaid}";
        ticket.price = calculate();
        priceLabel.Text = $"Preis: {_ticket.price}";
    }
    public double calculate()
    {
        var time = DateTime.Now - _ticket.entryTime;
        var timeMinute = Math.Floor(time.TotalMinutes);
        double price = timeMinute / 1 * 2;
        return price;
    }
    private async void PayButton(object sender, EventArgs e)
	{
		_ticket.isPaid = true;
        await DisplayAlert("Ticket", "Du hast erfolgreich bezahlt", "OK");
		await Navigation.PopAsync();
    }
}