
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;


namespace TestingAPI
{
    public class TestingAPI
    {
        List<Card> cardList = new List<Card>();
        List<Attributes> petList = new List<Attributes>();
        /*public static void Main(String[] args)
        {
            Task.Run(async () =>
            {
                var result = await getTestUsersFromMockIO();
               
            }).Wait();
        }*/

        public static void Main(String[] args)
        {
            Task.Run(async () =>
            {
                var result = await GetPets();
                Console.WriteLine(result[0].name);

            }).Wait();
        }

        public static async Task<List<Card>> getTestUsersFromMockIO()
        {
            string URL = "https://instructorc.github.io/CPST343_lab4_resource/basketball_cards.json";
            HttpClient httpClient = new HttpClient();
            

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(URL); //Sends a GET Request 
                string jsonContent = await response.Content.ReadAsStringAsync();
                List<Card> cardList = JsonSerializer.Deserialize<List<Card>>(jsonContent);
                foreach (var card in cardList)
                {
                    Console.WriteLine($"Apartment Name : {card.name}");
                    Console.WriteLine($"Apartment Position: {card.position}");
                    Console.WriteLine($"Apartment Sport: {card.sport}");
                    Console.WriteLine();
                }
                return cardList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }//End of GetTestUsersFromMockIO

   
        public static async Task<List<Attributes>> GetPets()
        {
            List<Attributes> petInfo = new List<Attributes>();
            var apikey = "wFrVl5dO";
            HttpClient httpClient = new HttpClient();

            //var url = "https://montemagno.com/monkeys.json";

            //var url = "https://api.rescuegroups.org/http/v2.json";

            var url = "https://api.rescuegroups.org/v5/public/animals/search/available";
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(apikey);
            //var response = await httpClient.GetAsync($"{url}?apikey=wFrVl5dO");
            HttpResponseMessage response = await httpClient.GetAsync(url); //Sends a GET Request 

            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

            string jsonContent = await response.Content.ReadAsStringAsync();
            var petList = JsonSerializer.Deserialize<Root>(jsonContent);

            //var response = await httpClient.GetAsync(url); **Original

      



            foreach (var pet in petList.data)
            {
                /*Console.WriteLine($"Pet Name : {pet.attributes.name}");
                Console.WriteLine($"Pet Breed: {pet.attributes.breedPrimary}");
                Console.WriteLine($"Pet sex: {pet.attributes.sex}");
                Console.WriteLine();*/
                petInfo.Add(pet.attributes);

            }


            //return petList;
            return petInfo;
        }
    }
    public class Card
    {

       
        public string name { get; set; }

      
        public string sport { get; set; }

        
        public string team { get; set; }

      
        public string position { get; set; }

      
        public string image { get; set; }


    }
}
