using BusTransport.Mob.ViewModels;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using Map = Microsoft.Maui.Controls.Maps.Map;

namespace BusTransport.Mob.Views;

public partial class RoutePage : ContentPage
{
    public RoutePage()
    {
        InitializeComponent();
        Application.Current.UserAppTheme = AppTheme.Light;

        Map map = new Map()
        {
            IsShowingUser = true,
            IsTrafficEnabled = true,
            MapType = MapType.Street
        };
        map.MoveToRegion(MapSpan.FromCenterAndRadius(new Location(52.42912314215671, 20.577927253227077), 
            Distance.FromKilometers(100)));

        List<LocationStore> locationStores = new List<LocationStore> {
            new LocationStore
            {
                Latitude = 52.31427966285411,
                Longitude = 20.975030951013984,
                StoreName= "Warszawa",
                Description = "Przystanek autobusowy znajduje siê na wschodnim krañcu kampusu uniwersyteckiego, obok budynku biblioteki."
            },
            new LocationStore
            {
                Latitude = 52.54582070996644,
                Longitude = 19.69903494277357,
                StoreName= "P³ock",
                Description = "Przystanek jest zlokalizowany przy po³udniowym wyjœciu z dworca kolejowego, obok stacji taksówek."
            },
            new LocationStore
            {
                Latitude = 53.54354247011144,
                Longitude = 18.813339446966882,
                StoreName= "Grudzi¹dz",
                Description = "Przystanek autobusowy jest usytuowany przy g³ównym wejœciu do Parku Miejskiego, naprzeciwko fontanny."
            },
            new LocationStore
            {
                Latitude = 54.15524822147908,
                Longitude = 18.813339446966882,
                StoreName= "Tczew",
                Description = "Przystanek znajduje siê na pó³nocnym krañcu parkingu supermarketu “Biedronka”, tu¿ obok stacji benzynowej"
            },
            new LocationStore
            {
                Latitude = 54.42795714690189,
                Longitude = 18.690886986914272,
                StoreName= "Gdañsk",
                Description = "Przystanek autobusowy jest zlokalizowany przy skrzy¿owaniu ulic Klonowej i Sosnowej, z ³atwym dojazdem od autostrady A1."
            }
        };
        
        foreach (var item in locationStores)
        {
            Pin pin = new Pin
            {
                Label = item.StoreName,
                Type = PinType.Generic,
                Location = new Location(item.Latitude, item.Longitude),
                Address = item.Description
            };
            map.Pins.Add(pin);
        }

        Polyline polyline= new Polyline
        {
            StrokeColor = Colors.Red,
            StrokeWidth = 5,
            Geopath =
            {
                new Location(52.31427966285411,20.975030951013984),
                new Location(52.54582070996644,19.69903494277357), 
                new Location(53.54354247011144, 18.813339446966882),
                new Location(54.15524822147908,18.813339446966882),
                new Location(54.42795714690189,18.690886986914272)
            }                 
        };
        map.MapElements.Add(polyline);
        Content = map;
    }

    public static implicit operator View(RoutePage v)
    {
        return v.Content;
    }
}