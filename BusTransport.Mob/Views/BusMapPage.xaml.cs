namespace BusTransport.Mob.Views;

public partial class BusMapPage : ContentPage
{
    private const int Rows = 4;
    private const int Columns = 10;
    private Button[,] seats;

    public BusMapPage()
	{
		InitializeComponent();
        InitializeSeats();
        StartRandomSeatUpdates();
    }
    private void InitializeSeats()
    {
        Application.Current.UserAppTheme = AppTheme.Light;
        seats = new Button[Rows, Columns];
        for (int row = 0; row < Rows; row++)
        {
            for (int col = 0; col < Columns; col++)
            {
                var seat = new Button
                {
                    BackgroundColor = Colors.Gray,
                    Text = $"{row + 1}{(char)('A' + col)}"
                };
                seats[row, col] = seat;
                SeatGrid.Add(seat, col, row);
            }
        }
    }

    private void StartRandomSeatUpdates()
    {
        var timer = new System.Threading.Timer((e) =>
        {
            MainThread.InvokeOnMainThreadAsync(() => UpdateSeatStates());
        }, null, TimeSpan.Zero, TimeSpan.FromSeconds(5)); 
    }

    private void UpdateSeatStates()
    {
        var random = new Random();
        for (int row = 0; row < Rows; row++)
        {
            for (int col = 0; col < Columns; col++)
            {
                var seat = seats[row, col];
                bool isTaken = random.Next(2) == 1;
                seat.BackgroundColor = isTaken ? Colors.LightBlue : Colors.Gray;
            }
        }
    }

    public static implicit operator View(BusMapPage v)
    {
        return v.Content;
    }
}