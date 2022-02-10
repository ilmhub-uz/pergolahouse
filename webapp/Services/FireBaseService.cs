using System.Net;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using webapp.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;

namespace webapp.Services;


public class FireBaseService
{
    private readonly HttpClient _httpClient;

    private string BaseUrl { get; set; } = "https://pergola-db-default-rtdb.firebaseio.com/.json";
    
    public FireBaseService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<List<ItemModel>> GetAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<Dictionary<string, ItemModel>>(BaseUrl);
        List<ItemModel> data = new List<ItemModel>();

        if(response != null)
        {
            foreach (var (key, value) in response)
            {
                data.Add(value);
            }
            // foreach (var item in data)
            // {
            //     Console.WriteLine($"{System.Text.Json.JsonSerializer.Serialize(item)}");
            // }
        }

        return data;
    }

    public async Task<bool> AddAllAsync(System.Uri AppBaseUrl)
    {
        var models = new List<ItemModel>();
        try
        {
            models.AddRange(await _httpClient.GetFromJsonAsync<List<ItemModel>>(AppBaseUrl + "data/data.json"));
            foreach (var item in models)
            {
                await PostAsync(item);
                // Console.WriteLine($"{models.IndexOf(item) + 1} qo'shildi");
            }
        }
        catch (System.Exception ex)
        {
            // Console.WriteLine($"{ex.Message}");
            return false;
        }

        return true;
    }

    public async Task<bool> PostAsync(ItemModel model)
    {
        var response = await _httpClient.PostAsJsonAsync(BaseUrl, model);

        return (int)response.StatusCode == 200 ? true : false;
    }
}