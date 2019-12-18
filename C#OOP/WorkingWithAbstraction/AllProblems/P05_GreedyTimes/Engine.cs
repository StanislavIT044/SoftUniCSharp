using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem05GreedyTimes
{
    public class Engine
    {
        public static void Run()
        {
            long input = long.Parse(Console.ReadLine());
            string[] safe = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Dictionary<string, long>> bag = new Dictionary<string, Dictionary<string, long>>();

            long gold = 0;
            long gems = 0;
            long cash = 0;

            for (int i = 0; i < safe.Length; i += 2)
            {
                string currentItem = safe[i];
                long number = long.Parse(safe[i + 1]);

                string item = string.Empty;

                if (currentItem.Length == 3)
                {
                    item = "Cash";
                }
                else if (currentItem.ToLower().EndsWith("gem"))
                {
                    item = "Gem";
                }
                else if (currentItem.ToLower() == "gold")
                {
                    item = "Gold";
                }

                if (item == "")
                {
                    continue;
                }
                else if (input < bag.Values.Select(x => x.Values.Sum()).Sum() + number)
                {
                    continue;
                }

                if (item == "Gem")
                {
                    if (!bag.ContainsKey(item))
                    {
                        if (bag.ContainsKey("Gold"))
                        {
                            if (number > bag["Gold"].Values.Sum())
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (bag[item].Values.Sum() + number > bag["Gold"].Values.Sum())
                    {
                        continue;
                    }
                }
                else if (item == "Cash")
                {
                    if (!bag.ContainsKey(item))
                    {
                        if (bag.ContainsKey("Gem"))
                        {
                            if (number > bag["Gem"].Values.Sum())
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (bag[item].Values.Sum() + number > bag["Gem"].Values.Sum())
                    {
                        continue;
                    }
                }

                if (!bag.ContainsKey(item))
                {
                    bag[item] = new Dictionary<string, long>();
                }

                if (!bag[item].ContainsKey(currentItem))
                {
                    bag[item][currentItem] = 0;
                }

                bag[item][currentItem] += number;

                if (item == "Gold")
                {
                    gold += number;
                }
                else if (item == "Gem")
                {
                    gems += number;
                }
                else if (item == "Cash")
                {
                    cash += number;
                }
            }

            PrintItemsInBag(bag);
        }
        private static void PrintItemsInBag(Dictionary<string, Dictionary<string, long>> bag)
        {
            foreach (var x in bag)
            {
                Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
                foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }
    }
}
