using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DirectorioEmpleadosMawi.Models;
using DirectorioEmpleadosMawi.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DirectorioEmpleadosMawi.ViewModels
{
    public partial class EmployeeViewModel(IRepositoryService<Empleado> empleadoService, IRepositoryService<Departamento> departamentoService ) : ObservableObject

    {
        [ObservableProperty]
        private ObservableCollection<Empleado> empleados = new();

        [ObservableProperty]
        private Empleado selectedEmpleado = new();

        [ObservableProperty]
        private string departamento;

        [RelayCommand]
        public async Task LoadEmpleadosAsync()
        {
            var lista = await empleadoService.GetAllAsync();
            Empleados.Clear();
            foreach (var sede in lista)
            {
                Empleados.Add(sede);
            }
        }

        [RelayCommand]
        public async Task OnDetailLinkTapped()
        { 
            await Shell.Current.GoToAsync("employeeDetailPage", new ShellNavigationQueryParameters { {"Empleado", SelectedEmpleado } });
        }

    }
}
