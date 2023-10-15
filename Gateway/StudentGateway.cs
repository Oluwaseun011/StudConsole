using studConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace regApp.Gateway
{
    public class StudentGateway
    {
        

        public static async Task<List<StudentDto>> GetAll()
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
}