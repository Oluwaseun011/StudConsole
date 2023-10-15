// See https://aka.ms/new-console-template for more information

//using studConsole;

//Menu m = new Menu();
//m.MainMenu();


using studConsole;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        try
        {
            using (var _httpClient = new HttpClient())
            {


                _httpClient.DefaultRequestHeaders.Accept.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var url = "https://localhost:7109/api/Student/students";
                var response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var jsonContent = await response.Content.ReadAsStringAsync();
                    var students = JsonSerializer.Deserialize<List<StudentDto>>(jsonContent);
                    return students;
                }
                else
                {
                    Console.WriteLine($"HTTP error status code: {response.StatusCode}");
                    return null;
                }

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            return null;
        }
    }

        
}




