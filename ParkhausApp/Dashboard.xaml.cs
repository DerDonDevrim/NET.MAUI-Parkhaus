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
}