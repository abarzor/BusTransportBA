using Mapsui.UI.Maui;

namespace BusTransport.Mob.Views;

public partial class RoutePage : ContentPage
{
    public RoutePage()
    {

        InitializeComponent();
        MapView mapView = new MapView();

        var mapControl = new Mapsui.UI.Maui.MapControl();
        var map = mapControl.Map;

        map?.Layers.Add(Mapsui.Tiling.OpenStreetMap.CreateTileLayer());

        //map.Home = n => n.NavigateTo(new MPoint(point.x, point.y), map.Resolutions[12]);


        var pin = new Pin
        {
            Label = "Santa Cruz",
            Address = "The city with a boardwalk",
            Type = PinType.Pin,
            Position = new Position(54.0756259624659, 21.372695213038302)
        };
        var line = new Mapsui.UI.Maui.Polyline
        {
            StrokeWidth = 15,
            StrokeColor = Mapsui.UI.Maui.KnownColor.Red
        };

        line.Positions.Add(new Position(52.196496547335954, 19.305936148042303));
        line.Positions.Add(new Position(54.6774142842844, -106.27939232261615));
        //var line = new Polyline
        //{
        //    StrokeColor = Mapsui.UI.Maui.KnownColor.Red,
        //    StrokeWidth = 15,
        //    Positions =
        //    {
        //        new Position (52.196496547335954, 19.305936148042303),
        //        new Position(54.6774142842844, -106.27939232261615)
        //    }
        //};
        mapView.Drawables.Add(line);
        //map?.Layers.Add((Mapsui.Layers.ILayer)line);
        Content = mapControl;
    }

    public static implicit operator View(RoutePage v)
    {
        return v.Content;
    }
}