namespace MXGP.Core
{
    using MXGP.Core.Contracts;
    using MXGP.Models.Races;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ChampionshipControler : IChampionshipController
    {
        public string AddMotorcycleToRider(string riderName, string motorcycleModel)
        {
            Rider rider = new Rider(riderName);



        }

        public string AddRiderToRace(string raceName, string riderName)
        {
            throw new NotImplementedException();
        }

        public string CreateMotorcycle(string type, string model, int horsePower)
        {
            throw new NotImplementedException();
        }

        public string CreateRace(string name, int laps)
        {
            throw new NotImplementedException();
        }

        public string CreateRider(string riderName)
        {
            throw new NotImplementedException();
        }

        public string StartRace(string raceName)
        {
            throw new NotImplementedException();
        }
    }
}
