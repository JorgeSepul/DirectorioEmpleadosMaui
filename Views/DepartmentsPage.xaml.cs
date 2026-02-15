using DirectorioEmpleadosMawi.ViewModels;

namespace DirectorioEmpleadosMawi.Views;

public partial class DepartmentsPage : ContentPage
{
	private readonly DepartamentoViewModel _departamentoViewModel;
    public DepartmentsPage(DepartamentoViewModel departamentoViewModel)
	{
		InitializeComponent();
		_departamentoViewModel = departamentoViewModel;
		BindingContext = departamentoViewModel;	

	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await _departamentoViewModel.LoadDepartamentosAsync();

    }
}
