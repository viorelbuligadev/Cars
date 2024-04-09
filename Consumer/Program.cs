using Consumer.Models;
using System.Text.Json;

string url = "https://localhost:60376/api/car/stream";

await foreach (var car in StreamCars(url))
{
    Console.WriteLine($"{car.FullName}, Color: {car.Color}, Year: {car.Year}");
}
Console.ReadLine();
static async IAsyncEnumerable<CarDto> StreamCars(string requestUri)
{
    using var httpClient = new HttpClient();

    var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
    var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
    response.EnsureSuccessStatusCode();

    var stream = await response.Content.ReadAsStreamAsync();
    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

    await foreach (var car in JsonSerializer.DeserializeAsyncEnumerable<CarDto>(stream, options))
    {
        yield return car;
    }
}
