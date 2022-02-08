using System;
using System.Collections.Generic;
using WorldCupLibrary.Models.Match;
namespace WorldCupLibrary.Models
{
    [Serializable]
    public enum Culture
    {
        en, hr
    }
    [Serializable]
    public enum TeamGender
    {
        male, female
    }
    [Serializable]
    public enum Resolution
    {
        small, medium, fullscreen
    }

    [Serializable]
    public class DataConfig
    {

        public Culture Culture { get; set; }
     
        public TeamGender TeamGender { get; set; }

        public Resolution Resolution { get; set; }

        public Nation FavNation { get; set; }

        public List<StartingEleven> FavNationPlayers { get; set; }
    }
}
