namespace SpaceStation.Core
{
    using SpaceStation.Core.Contracts;
    using SpaceStation.Models.Astronauts;
    using SpaceStation.Models.Astronauts.Contracts;
    using SpaceStation.Models.Mission;
    using SpaceStation.Models.Planets;
    using SpaceStation.Repositories;
    using SpaceStation.Repositories.Contracts;
    using System;
    using System.Linq;
    using System.Text;

    public class Controller : IController
    {
        private IRepository<IAstronaut> astronautRepository;
        private IRepository<IPlanet> planetRepository;
        private int exploredPlanetsCount;
        private IMission mission;

        public Controller()
        {
            astronautRepository = new AstronautRepository();
            planetRepository = new PlanetRepository();
            exploredPlanetsCount = 0;
        }

        public string AddAstronaut(string type, string astronautName)
        {
            IAstronaut astronaut = null;

            if (type == "Biologist")
            {
                astronaut = new Biologist(astronautName);
            }
            else if (type == "Geodesist")
            {
                astronaut = new Geodesist(astronautName);
            }
            else if (type == "Meteorologist")
            {
                astronaut = new Meteorologist(astronautName);
            }
            else 
            {
                throw new InvalidOperationException("Astronaut type doesn't exists!");
            }
              
            astronautRepository.Add(astronaut);
            
            return $"Successfully added {type}: {astronautName}!";
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            IPlanet planet = new Planet(planetName, items);

            planetRepository.Add(planet);

            return $"Successfully added Planet: {planetName}!";
        }

        public string ExplorePlanet(string planetName) 
        {
            var astronautsOnMission = astronautRepository.Models.Where(x => x.Oxygen > 60).ToList();

            if (!astronautsOnMission.Any())
            {
                throw new InvalidOperationException("You need at least one astronaut to explore the planet");
            }

            IPlanet planet = planetRepository.FindByName(planetName);
           
            this.mission = new Mission();
            this.mission.Explore(planet, astronautsOnMission);
            
            int deadAstronauts = astronautsOnMission.Count(x => !x.CanBreath);

            this.exploredPlanetsCount++;

            return $"Planet: {planetName} was explored! Exploration finished with {deadAstronauts} dead astronauts!";
        }

        public string Report() //TODO...
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{exploredPlanetsCount} planets were explored!");
            sb.AppendLine("Astronauts info:");

            foreach (var astr in astronautRepository.Models)
            {
                sb.AppendLine($"Name: {astr.Name}");
                sb.AppendLine($"Oxygen: {astr.Oxygen}");
                if (astr.Bag.Items.Count == 0)
                {
                    sb.AppendLine("Bag items: none");
                }
                else
                {
                    sb.AppendLine($"Bag items: {string.Join(", ", astr.Bag.Items)}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public string RetireAstronaut(string astronautName)
        {
            IAstronaut astronaut = astronautRepository.FindByName(astronautName);
            if (astronaut != null) 
            {
                astronautRepository.Remove(astronaut);

                return $"Astronaut {astronautName} was retired!";
            }
            else
            {
                throw new InvalidOperationException($"Astronaut {astronautName} doesn't exists!");
            }
        }
    }
}
