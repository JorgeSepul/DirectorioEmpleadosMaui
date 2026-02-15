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
    public partial class SedeViewModel(IRepositoryService<Sede> sedeService) : ObservableObject

    {
        [ObservableProperty]
        private ObservableCollection<Sede> sedes = new();

        // Para cargar los datos de forma asíncrona, es necesario usar un comando que se ejecute al cargar la página, en este caso, se usará el método OnAppearing de la página para ejecutar el comando LoadSedesAsync

        [RelayCommand]
        public async Task LoadSedesAsync()
        {
            var lista = await sedeService.GetAllAsync();
            Sedes.Clear();
            foreach (var sede in lista)
            {
                Sedes.Add(sede);
            }
        }

    }
}
