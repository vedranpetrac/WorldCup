﻿using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldCupLibrary.Constants;
using WorldCupLibrary.Models;
using WorldCupLibrary.Models.Match;

namespace WorldCupLibrary.Dal.WorldCupDataSource
{
    class LocalSource : IRepoWorldCupData
    {

        string FILE_WOMEN_RESULTS_ENDPOINT = @".\WorldCupDataSource\worldcup.sfg.io\women\teams.json";
        string FILE_MEN_RESULTS_ENDPOINT = @".\WorldCupDataSource\worldcup.sfg.io\men\teams.json";

        public Task<List<Nation>> GetNations(TeamGender teamGenderType)
        {
            return Task.Run(() =>
            {
                RestClient apiClient;
                if (teamGenderType == TeamGender.female) { 
                    apiClient = new RestClient(ApiConstants.WOMEN_RESULTS_ENDPOINT); 
                }
                else { 
                    apiClient = new RestClient(ApiConstants.MEN_RESULTS_ENDPOINT); 
                }
                var apiResult = apiClient.Execute<Nation>(new RestRequest());
                return JsonConvert.DeserializeObject<List<Nation>>(apiResult.Content);
                
            });
        }

        public Task<List<Match>> GetMatches(Nation nation, TeamGender teamGenderType)
        {
            return Task.Run(() =>
            {
                RestClient apiClient;
                if (teamGenderType == TeamGender.female)
                {
                    apiClient = new RestClient(ApiConstants.WOMEN_MATCH_ENDPOINT + nation.FifaCode);
                }
                else
                {
                    apiClient = new RestClient(ApiConstants.MEN_MATCH_ENDPOINT + nation.FifaCode);
                }
                var apiResult = apiClient.Execute<Match>(new RestRequest());
                return JsonConvert.DeserializeObject<List<Match>>(apiResult.Content);

            });
        }


        Task<List<Match>> IRepoWorldCupData.GetMatches(Nation nation, TeamGender teamGenderType)
        {
            throw new NotImplementedException();
        }
    }
}
