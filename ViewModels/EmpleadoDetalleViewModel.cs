using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DirectorioEmpleadosMawi.Models;
using DirectorioEmpleadosMawi.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace DirectorioEmpleadosMawi.ViewModels
{
    [QueryProperty(nameof(Empleado), "Empleado")]
    public partial class EmpleadoDetalleViewModel(IRepositoryService<Departamento> deptService, IRepositoryService<Sede> sedeService) : ObservableObject
    {
        private readonly IRepositoryService<Departamento> departamentoService = deptService;
        private readonly IRepositoryService<Sede> sedeService = sedeService;

        [ObservableProperty]
        private Empleado empleado;

        [ObservableProperty]
        private  Departamento departamentoAsociado;

        [ObservableProperty]
        private Sede sedeAsociada;


        private async Task CargarAsociados() 
        {
            DepartamentoAsociado = await departamentoService.GetById(Empleado.Departamento_id);
            SedeAsociada = await sedeService.GetById(Empleado.Sede_id);
        }

        partial void OnEmpleadoChanged(Empleado value)
        {
            if (value != null)
            {
                Task.Run(async () => await CargarAsociados());
            }
        }


    }
}
