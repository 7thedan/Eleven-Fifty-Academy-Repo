using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;
using IntroToApi.Models;

namespace IntroToApi
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage response = httpClient.GetAsync("http://swapi.dev/api/people/1/").Result; 
            

            if (response.IsSuccessStatusCode)
            {
                //var content = response.Content.ReadAsStringAsync().Result; //expression v
                //var person = JsonConvert.DeserializeObject<Person>(content); //reading as a string then converting it. 

                Person luke = response.Content.ReadAsAsync<Person>().Result;
                Console.WriteLine(luke.Name);
                
                foreach(string vehicleUrl in luke.Vehicles)
                {
                    HttpResponseMessage vehicleResponse = httpClient.GetAsync(vehicleUrl).Result;
                    //Console.WriteLine(vehicleResponse.Content.ReadAsStringAsync().Result);

                    Vehicle vehicle = vehicleResponse.Content.ReadAsAsync<Vehicle>().Result;
                    Console.WriteLine(vehicle.Name);
                }
            }

            Console.WriteLine();

            SWAPIService service = new SWAPIService();
            Person person = service.GetPersonAsync("https://swapi.dev/api/people/14/").Result;
            if(person != null)
            {
                Console.WriteLine(person.Name);
                
                foreach(var vehicleUrl in person.Vehicles)
                {
                    var vehicle = service.GetVehicleAsync(vehicleUrl).Result;
                    Console.WriteLine(vehicle.Name); 
                }
            }

            Console.WriteLine();

            //var genericReponse = service.GetAsync<Vehicle>("https://swapi.dev/api/vehicles/4/").Result;
            var genericReponse = service.GetAsync<Vehicle>("https://swapi.dev/api/people/4/").Result;
            if (genericReponse != null)
            {
                Console.WriteLine(genericReponse.Name);
            }
            else
            {
                Console.WriteLine("Target object does not exist.");
            }
            Console.WriteLine();

            SearchResult<Person> skywalkers = service.GetPersonSearchAsync("skywalker").Result;
            foreach(Person p in skywalkers.Results)
            {
                Console.WriteLine(p.Name);
            }

            var genericSearch = service.GetSearchAsync<Vehicle>("speeder", "vehicles").Result;
            var vehicleSearch = service.GetVehicleSearchAsync("speeder").Result;
        }
    }
}
