using DirectorioEmpleadosMawi.ViewModels;

namespace DirectorioEmpleadosMawi.Views;

public partial class EmployeesPage : ContentPage
{
    private readonly EmployeeViewModel _empleadoViewModel;
    public EmployeesPage(EmployeeViewModel empleadoViewModel)
	{
		InitializeComponent();
        _empleadoViewModel = empleadoViewModel;
        BindingContext = _empleadoViewModel;

    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await _empleadoViewModel.LoadEmpleadosAsync();

    }
}