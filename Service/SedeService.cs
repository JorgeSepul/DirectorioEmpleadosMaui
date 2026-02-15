using CommunityToolkit.Mvvm.ComponentModel;
using DirectorioEmpleadosMawi.Models;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace DirectorioEmpleadosMawi.Service
{
    internal class SedeService : IRepositoryService<Sede>
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private static readonly JsonSerializerOptions _serializeOptions = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
        private const string BaseUrl = "http://localhost:8000/sedes";

        // Para poder recoger los datos de la API de forma asíncrona, es necesario cambiar el método a async y usar await
        //de la otra forma, el método se ejecutará de forma síncrona y bloqueará el hilo principal, lo que puede causar problemas de rendimiento y experiencia de usuario.
        public async Task<List<Sede>> GetAllAsync() => await _httpClient.GetFromJsonAsync<List<Sede>>(BaseUrl, _serializeOptions);



        public void Update(Sede entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Sede> GetById(int id) => await _httpClient.GetFromJsonAsync<Sede>($"{BaseUrl}/{id}", _serializeOptions);

    }
}
