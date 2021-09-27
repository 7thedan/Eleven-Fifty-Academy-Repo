using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToApi.Models
{
    class SearchResult<T> //must use specific type. T is used as a generic type. 
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("result")]
        public List<T> Result { get; set; }
    }
}
