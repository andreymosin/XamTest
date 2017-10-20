using System;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CrossFinal.Shared
{
    public class MyClass
    {

        private HttpClient _httpClient;

        public MyClass()
        {
            _httpClient = new HttpClient();
        }


        public async System.Threading.Tasks.Task<DataDTO> GetDataAsync()
        {
            var res = await _httpClient.GetStringAsync("https://www.alza.cz/Services/RestService.svc/v1/floors");
            var data = JsonConvert.DeserializeObject<Data>(res);

            return new DataDTO()
            {
                Categories = data.Categories
            };
        }

    }

    public class DataDTO {
        public List<Category> Categories;
    }

    public class Data {

        [JsonProperty("data")]
        public List<Category> Categories;
    }

    public class Category {
        public string name;
    }

}
