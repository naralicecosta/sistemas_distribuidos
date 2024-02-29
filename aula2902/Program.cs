// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http;
using System.Threading.Tasks;


class Program 
{
    using var htttpClient = new htttpClient(); // variavel genérica
    string url = "https://github.com"
    HttpResponseMessage response = await htttpClient GetAsync(url)

    if (responde.IsSuccessStatusCode)
    {
        string respondeBody = await responde.Content.ReadAsStringAsync()
        Console.WriteLine(respondeBody)
    }

}