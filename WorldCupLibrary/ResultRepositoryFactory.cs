using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldCupLibrary.Constants;
using WorldCupLibrary.Models;
using Newtonsoft.Json.Converters;
using System.Globalization;
using WorldCupLibrary.Models.Match;

namespace WorldCupLibrary
{
    public static class ResultRepositoryFactory
    {

        public static Task<Match> GetWomenResult()
        {
            return Task.Run(() =>
            {
                return GetResultsFromUrl(ApiConstants.WOMEN_RESULTS_ENDPOINT);
            });


        }

        public static Task<List<Match>> GetMenResult()
        {
            return Task.Run(() =>
            {
                var apiClient = new RestClient(ApiConstants.MEN_RESULTS_ENDPOINT);
                var apiResult = apiClient.Execute<Match>(new RestRequest());
                string json = apiResult.Content.ToString();
                return JsonConvert.DeserializeObject<List<Match>>(json, Converter.Settings);
            });

            
        }

        static Match GetResultsFromUrl(string url)
        {
            var apiClient = new RestClient(url);
            var apiResult = apiClient.Execute<Match>(new RestRequest());
            return JsonConvert.DeserializeObject<Match>(apiResult.Content);
        }
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };

    }
}
