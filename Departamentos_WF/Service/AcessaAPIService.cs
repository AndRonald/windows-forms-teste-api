using Departamentos_WF.Model;
using System.Net.Http.Json;

namespace Departamentos_WF.Service
{
    public class AcessaAPIService
    {
        private static readonly HttpClient client = new HttpClient();

        private readonly string? _baseUrl;

        public AcessaAPIService(string baseUrl) 
        {

            _baseUrl = baseUrl.TrimEnd('/');
        }

        public string GetBaseUrl() => $"{_baseUrl}/";

        public string GetItemUrl(int id) => $"{_baseUrl}/{id}";

        public async Task<List<Departamento>> GetAllDepartamentos() 
        {
            var response = await client.GetAsync(GetBaseUrl());

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<List<Departamento>>() ?? new List<Departamento>();
        }

        public async Task<Departamento> GetDepartamentoById(int id) 
        {
            var response = await client.GetAsync(GetItemUrl(id));

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                return null;

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<Departamento>();
        }

        public async Task AddDepartamento(Departamento departamento) 
        {
            var response = await client.PostAsJsonAsync(GetBaseUrl(), departamento);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateDepartamento(int id, Departamento departamento) 
        {
            var response = await client.PutAsJsonAsync(GetItemUrl(id), departamento);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteDepartamento(int id)
        {
            var response = await client.DeleteAsync(GetItemUrl(id));
            response.EnsureSuccessStatusCode();
        }
    }
}
