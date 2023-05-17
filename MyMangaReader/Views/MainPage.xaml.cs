using MyMangaReader.ViewModels;

namespace MyMangaReader;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
    }

    private void SideMenuOpenClick(object sender, EventArgs e)
	{
        if (SideMenu.IsVisible == false)
		{
            SideMenuColumn.Width = new GridLength(5, GridUnitType.Star);
			SideMenuButtonColumn.Width = new GridLength(1, GridUnitType.Star);
			MainColumn.Width = new GridLength(4, GridUnitType.Star);
			SideMenu.IsVisible = true;
        }
		else
		{
            SideMenuColumn.Width = new GridLength(0, GridUnitType.Star);
            SideMenuButtonColumn.Width = new GridLength(1, GridUnitType.Star);
            MainColumn.Width = new GridLength(9, GridUnitType.Star);
            SideMenu.IsVisible = false;
        }
    }
}

