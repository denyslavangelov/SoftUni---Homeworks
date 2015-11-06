using System;
using System.Collections.Generic;

class NightLife
{
    static void Main()
    {
        Dictionary<string, SortedDictionary<string, SortedSet<string>>> nightLifeDictionary =
                            new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

        string[] eventTokens;
        string eventCity;
        string eventVenue;
        string eventPerformer;
        string eventInformation = Console.ReadLine();

        while (eventInformation != "END")
        {
            eventTokens = eventInformation.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            eventCity = eventTokens[0];
            eventVenue = eventTokens[1];
            eventPerformer = eventTokens[2];

            if (!nightLifeDictionary.ContainsKey(eventCity))
            {
                nightLifeDictionary[eventCity] = new SortedDictionary<string, SortedSet<string>>(); 
            }

            if (!nightLifeDictionary.ContainsKey(eventVenue))
            {
                nightLifeDictionary[eventCity][eventVenue] = new SortedSet<string>();
            }

            nightLifeDictionary[eventCity][eventVenue].Add(eventPerformer);

            eventInformation = Console.ReadLine();
        }

        foreach (var city in nightLifeDictionary)
        {
            Console.WriteLine(city.Key);
            foreach (var venue in city.Value)
            { 
                Console.WriteLine("->{0}: {1}", venue.Key, String.Join(", ", venue.Value));
            }
        }


    }
}
