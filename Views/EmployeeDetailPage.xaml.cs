using DirectorioEmpleadosMawi.ViewModels;

namespace DirectorioEmpleadosMawi.Views;

public partial class EmployeeDetailPage : ContentPage
{

	public EmployeeDetailPage(EmpleadoDetalleViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}