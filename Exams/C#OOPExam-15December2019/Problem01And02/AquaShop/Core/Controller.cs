namespace AquaShop.Core
{
    using AquaShop.Core.Contracts;
    using AquaShop.Models.Aquariums;
    using AquaShop.Models.Aquariums.Contracts;
    using AquaShop.Models.Decorations;
    using AquaShop.Models.Decorations.Contracts;
    using AquaShop.Models.Fish;
    using AquaShop.Models.Fish.Contracts;
    using AquaShop.Repositories;
    using AquaShop.Repositories.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Controller : IController
    {
        private DecorationRepository decorationRepository;
        private List<IAquarium> aquariums;

        public Controller()
        {
            decorationRepository = new DecorationRepository();
            aquariums = new List<IAquarium>();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium aquarium = null;

            if (aquariumType == "SaltwaterAquarium")
            {
                aquarium = new SaltwaterAquarium(aquariumName);
                aquariums.Add(aquarium);
            }
            else if (aquariumType == "FreshwaterAquarium")
            {
                aquarium = new FreshwaterAquarium(aquariumName);
                aquariums.Add(aquarium);
            }
            else
            {
                throw new InvalidOperationException("Invalid aquarium type.");
            }

            return $"Successfully added {aquarium.GetType().Name}.";
        }

        public string AddDecoration(string decorationType)
        {
            IDecoration dec = decorationRepository.FindByType(decorationType);

            if (decorationType != null)
            {
                decorationRepository.Add(dec);
            }
            else
            {
                throw new InvalidOperationException("Invalid decoration type.");
            }

            return $"Successfully added {decorationType}.";
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            IFish fish = null;

            if (fishType == "FreshwaterFish")
            {
                fish = new FreshwaterFish(fishName, fishSpecies, price);
            }
            else if (fishType == "SaltwaterFish")
            {
                fish = new SaltwaterFish(fishName, fishSpecies, price);
            }
            else
            {
                throw new InvalidOperationException("Invalid fish type.");
            }

            foreach (var a in aquariums)
            {
                if (a.Name == aquariumName)
                {
                    a.AddFish(fish);
                    break;
                }
            }

            string str = string.Empty;

            str += $"Successfully added {fishType} to {aquariumName}.";

            foreach (var a in aquariums)
            {
                if (a.Name == aquariumName)
                {
                    if (a.GetType().Name == "FreshwaterFish" && fishType == "SaltwaterFish")
                    {
                        str = "Water not suitable.";
                        break;
                    }
                    else if (a.GetType().Name == "SaltwaterAquarium" && fishType == "FreshwaterFish")
                    {
                        str = "Water not suitable.";
                        break;
                    }
                }
            }

            return str;
        }

        public string CalculateValue(string aquariumName)
        {
            decimal fishSum = 0;
            decimal decSum = 0;

            foreach (var a in aquariums)
            {
                if (a.Name == aquariumName)
                {
                    foreach (var fish in a.Fish)
                    {
                        fishSum += fish.Price;
                    }

                    foreach (var d in a.Decorations)
                    {
                        decSum += d.Price;
                    }
                }
            }

            return $"The value of Aquarium {aquariumName} is {(fishSum + decSum):F2}.";
        }

        public string FeedFish(string aquariumName)
        {
            string str = null;
            foreach (var a in aquariums)
            {
                if (a.Name == aquariumName)
                {
                    a.Feed();
                    str = $"Fish fed: {a.Fish.Count()}";
                }
            }

            return str;
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            IDecoration dec = decorationRepository.FindByType(decorationType);

            foreach (var a in aquariums)
            {
                if (a.Name == aquariumName)
                {
                    a.AddDecoration(dec);
                    decorationRepository.Remove(dec);
                    break;
                }
            }

            if (dec != null)
            {
                return $"Successfully added {decorationType} to {aquariumName}.";
            }


            throw new InvalidOperationException($"There isn't a decoration of type {decorationType}.");
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var a in aquariums)
            {
                sb.AppendLine(a.GetInfo() + Environment.NewLine);
            }

            return sb.ToString().TrimEnd();
        }
    }
}
