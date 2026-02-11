namespace ParkhausApp;

public partial class Dashboard : ContentPage
{
	private Ticket _ticket;
	public Dashboard(Ticket ticket)
	{
		InitializeComponent();
		_ticket = ticket;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		CurrentTime();
		CurrentPrice();

    }
	public void CurrentTime()
	{
		Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
		{
			var duration = DateTime.Now - _ticket.entryTime;
			parkduration.Text = $"Aktuellezeit: {duration:hh\\:mm\\:ss}";
			return true;
		});
	}
	public void CurrentPrice() {
		Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
		{
			var time = DateTime.Now - _ticket.entryTime;
			var timeMinute = Math.Floor(time.TotalMinutes);
			double price = timeMinute / 1 * 2;
            parkprice.Text = $"Aktueller Preis: {price} CHF";
            return true;

		});
} }