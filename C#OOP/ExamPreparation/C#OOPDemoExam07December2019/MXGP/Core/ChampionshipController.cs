namespace MXGP.Core
{
    using MXGP.Core.Contracts;
    using MXGP.Models.Motorcycles;
    using MXGP.Models.Motorcycles.Contracts;
    using MXGP.Models.Races;
    using MXGP.Models.Races.Contracts;
    using MXGP.Models.Riders;
    using MXGP.Models.Riders.Contracts;
    using MXGP.Repositories;
    using MXGP.Utilities.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ChampionshipController : IChampionshipController
    {
        private RiderRepository riders;
        private MotorcycleRepository motorcycles;
        private RaceRepository races;

        public ChampionshipController()
        {
            riders = new RiderRepository();
            motorcycles = new MotorcycleRepository();
            races = new RaceRepository();
        }

        public string AddMotorcycleToRider(string riderName, string motorcycleModel)
        {
            IRider rider = riders.GetByName(riderName);
            IMotorcycle motorcycle = motorcycles.GetByName(motorcycleModel);

            rider.AddMotorcycle(motorcycle);

            return string.Format(OutputMessages.MotorcycleAdded, rider.Name, motorcycle.Model);
        }

        public string AddRiderToRace(string raceName, string riderName)
        {
            IRace race = races.GetByName(raceName);
            IRider rider = riders.GetByName(riderName);

            race.AddRider(rider);

            return string.Format(OutputMessages.RiderAdded, rider.Name, race.Name);
        } // TODO: Repair

        public string CreateMotorcycle(string type, string model, int horsePower)
        {
            IMotorcycle motorcycle = null;
            if (type == "Speed")
            {
                motorcycle = new SpeedMotorcycle(model, horsePower);
            }
            else if (type == "Power")
            {
                motorcycle = new PowerMotorcycle(model, horsePower);
            }

            foreach (var m in motorcycles.GetAll())
            {
                if (m.Model == motorcycle.Model)
                {
                    throw new ArgumentException($"Motorcycle {m.Model} is already created.");
                }
            }

            motorcycles.Add(motorcycle);

            return string.Format(OutputMessages.RiderCreated, motorcycle.GetType().Name, motorcycle.Model);
        }

        public string CreateRace(string name, int laps)
        {
            IRace race = new Race(name, laps);

            races.Add(race);

            return string.Format(OutputMessages.RaceCreated, race.Name);
        }

        public string CreateRider(string riderName)
        {
            IRider rider = new Rider(riderName);

            foreach (var r in riders.GetAll())
            {
                if (r.Name == rider.Name)
                {
                    throw new ArgumentException($"Rider {rider.Name} is already created.");
                }
            }

            riders.Add(rider);

            return string.Format(OutputMessages.RiderCreated, rider.Name);
        }

        public string StartRace(string raceName)
        {
            StringBuilder sb = new StringBuilder();

            IRace race = races.GetByName(raceName);

            if (race.Riders.Count < 3)
            {
                throw new InvalidOperationException($"Race {race.Name} cannot start with less than 3 participants.");
            }

            List<IMotorcycle> raceRiders = riders.GetAll() as List<IMotorcycle>;

            raceRiders.OrderByDescending(r => r.CalculateRacePoints(race.Laps));

            sb.AppendLine($"Rider {raceRiders[0]} wins {race.Name} race.");
            sb.AppendLine($"Rider {raceRiders[1]} is second in {race.Name} race.");
            sb.AppendLine($"Rider {raceRiders[1]} is third in {race.Name} race.");

            return sb.ToString().TrimEnd();
        }
    }
}
