using DirectorioEmpleadosMawi.ViewModels;

namespace DirectorioEmpleadosMawi.Views;

public partial class HeadQuartersPage : ContentPage
   
{
    private readonly SedeViewModel _sedeViewModel;
    public HeadQuartersPage(SedeViewModel sedeViewModel)
	{
		InitializeComponent();
        _sedeViewModel = sedeViewModel;
        BindingContext = _sedeViewModel;
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
       
            await _sedeViewModel.LoadSedesAsync();
        
    }
}