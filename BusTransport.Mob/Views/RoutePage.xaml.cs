using Mapsui.Layers;
using Mapsui.Providers;
using Mapsui.Styles;
using Mapsui.UI.Maui;
using Microsoft.Maui.Controls;

namespace BusTransport.Mob.Views;

public partial class RoutePage : ContentPage
{
    public RoutePage()
	{
		InitializeComponent();

        var mapControl = new Mapsui.UI.Maui.MapControl();
        mapControl.Map?.Layers.Add(Mapsui.Tiling.OpenStreetMap.CreateTileLayer());
        Content = mapControl;
    }


    public static implicit operator View(RoutePage v)
    {
        return v.Content;
    }
}