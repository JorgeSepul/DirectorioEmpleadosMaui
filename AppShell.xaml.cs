using DirectorioEmpleadosMawi.Views;

namespace DirectorioEmpleadosMawi
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            InitializeRouting();

        }

        private void InitializeRouting()
        {
            Routing.RegisterRoute("employeeDetailsPage", typeof(EmployeeDetailPage));
        }

       
    }
}
