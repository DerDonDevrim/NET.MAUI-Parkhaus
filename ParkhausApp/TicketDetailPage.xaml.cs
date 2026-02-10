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

    }

	private async void PayButton(object sender, EventArgs e)
	{
		_ticket.isPaid = true;
        await DisplayAlert("Ticket", "Du hast erfolgreich bezahlt", "OK");
		await Navigation.PopAsync();
    }
}