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

        Map map = new Map()
        {
            IsShowingUser = true,
        };
        map.MoveToRegion(MapSpan.FromCenterAndRadius(new Location(52.42912314215671, 20.577927253227077), 
            Distance.FromKilometers(100)));

        List<LocationStore> Location_Stores = new List<LocationStore> {
            new LocationStore
            {
                Latitude = 52.31427966285411,
                Longitude = 20.975030951013984,
                StoreName= "Warszawa",
                Description = "Przystanek przy sklepie X"
            },
            new LocationStore
            {
                Latitude = 52.54582070996644,
                Longitude = 19.69903494277357,
                StoreName= "P³ock",
                Description = "Przystanek na dworcu autobusowymX"
            },
            new LocationStore
            {
                Latitude = 53.54354247011144,
                Longitude = 18.813339446966882,
                StoreName= "Grudzi¹dz",
                Description = "Przystanek na dworcu autobusowymX"
            },
            new LocationStore
            {
                Latitude = 54.15524822147908,
                Longitude = 18.813339446966882,
                StoreName= "Tczew",
                Description = "Przystanek na dworcu autobusowymX"
            },
            new LocationStore
            {
                Latitude = 54.42795714690189,
                Longitude = 18.690886986914272,
                StoreName= "Gdañsk",
                Description = "Przystanek przy sklepie Y"
            }
        };
        
        foreach (var item in Location_Stores)
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