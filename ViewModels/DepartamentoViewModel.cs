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
    public partial class DepartamentoViewModel(IRepositoryService<Departamento> departamentoService) : ObservableObject

    {
        [ObservableProperty]
        private ObservableCollection<Departamento> departamentos = new();
        

        [RelayCommand]
        public async Task LoadDepartamentosAsync()
        {
            var lista = await departamentoService.GetAllAsync();
            Departamentos.Clear();
            foreach (var departamento in lista)
            {
                Departamentos.Add(departamento);
            }
        }


    }
}
