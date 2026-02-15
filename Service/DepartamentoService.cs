using DirectorioEmpleadosMawi.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace DirectorioEmpleadosMawi.Service
{
    internal class DepartamentoService : IRepositoryService<Departamento>
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private static readonly JsonSerializerOptions _serializeOptions = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
        private const string BaseUrl = "http://localhost:8000/departamentos";


        public async Task<List<Departamento>> GetAllAsync() => await _httpClient.GetFromJsonAsync<List<Departamento>>(BaseUrl, _serializeOptions);
           
        


        public Task<Departamento> GetById(int id) => _httpClient.GetFromJsonAsync<Departamento>($"{BaseUrl}/{id}", _serializeOptions);

        public void Update(Departamento entity)
        {
            throw new NotImplementedException();
        }
    }
}
