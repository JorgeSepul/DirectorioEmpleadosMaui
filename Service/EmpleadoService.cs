using DirectorioEmpleadosMawi.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace DirectorioEmpleadosMawi.Service
{
    public class EmpleadoService : IRepositoryService<Empleado>
    {
        
        // Añadir la ruta a la base dependiendo del endpoint que se quiera consumir
        private static readonly HttpClient _httpClient = new HttpClient();
        private static readonly JsonSerializerOptions _serializeOptions = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
        private const string BaseUrl = "http://localhost:8000/empleados";


        public void Update(Empleado empleado) => _httpClient.PutAsJsonAsync(requestUri: $"{BaseUrl}/{empleado.Id}", empleado, _serializeOptions).GetAwaiter().GetResult();


        public async Task<List<Empleado>> GetAllAsync() => await _httpClient.GetFromJsonAsync<List<Empleado>>(BaseUrl, _serializeOptions);


        public Task<Empleado> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
