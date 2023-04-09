using System;
using System.Collections.Generic;
using RoboCup.AtHome.CommandGenerator;

namespace RoboCup.AtHome.GPSRCmdGen
{
    /// <summary>
    /// Helper class that produces lists and containers with predefined example data
    /// </summary>
    public static class Factory
    {
        /// <summary>
        /// Gets a list with predefined gestures.
        /// </summary>
        /// <returns>A list with predefined gestures.</returns>
        public static List<Gesture> GetDefaultGestures()
        {
            List<Gesture> gestures = new List<Gesture>();
            gestures.Add(new Gesture("waving", DifficultyDegree.Low));
            gestures.Add(new Gesture("rising left arm", DifficultyDegree.Low));
            gestures.Add(new Gesture("rising right arm", DifficultyDegree.Low));
            gestures.Add(new Gesture("pointing left", DifficultyDegree.Low));
            gestures.Add(new Gesture("pointing right", DifficultyDegree.Low));
            return gestures;
        }

        /// <summary>
        /// Gets a list with predefined locations.
        /// </summary>
        /// <returns>A list with predefined locations.</returns>
        public static List<Room> GetDefaultLocations()
        {
            List<Room> tmp = new List<Room>();
            
            Room hallway = new Room("hallway");
            hallway.AddLocation("tall table", true, true);
            hallway.AddPlacement("bin c");
            hallway.AddPlacement("bin d");
            tmp.Add(hallway);

            Room livingroom = new Room("living room");
            livingroom.AddLocation("long table a", true, true);
            livingroom.AddLocation("long table b", true, true);
            livingroom.AddPlacement("bin a");
            livingroom.AddPlacement("bin b");
            tmp.Add(livingroom);

            Room diningroom = new Room("dining room");
            diningroom.AddPlacement("chair a");
            diningroom.AddPlacement("chair b");
            diningroom.AddLocation("shelf", true, true);
            tmp.Add(diningroom);

            return tmp;
        }

        /// <summary>
        /// Gets a list with predefined names.
        /// </summary>
        /// <returns>A list with predefined names.</returns>
        public static List<PersonName> GetDefaultNames()
        {
            List<PersonName> names = new List<PersonName>();

            string[] male = new string[] {
                "Angel",
                "Charlie",
                "Hunter",
                "Jack",
                "Max",
                "Noah",
                "Oliver",
                "Parker",
                "Sam",
                "Thomas",
                "William"
            };

            string[] female = new string[] {
                "Amelia",
                "Angel",
                "Ava",
                "Charlie",
                "Charlotte",
                "Hunter",
                "Max",
                "Mia",
                "Olivia",
                "Parker",
                "Sam"
            };
            foreach (string s in female)
                names.Add(new PersonName(s, Gender.Female));

            foreach (string s in male)
                names.Add(new PersonName(s, Gender.Male));

            return names;
        }

        /// <summary>
        /// Gets a GPSRObjectManager which contains example GPSRObjects grouped by category.
        /// </summary>
        /// <returns>A GPSRObjectManager with default objects.</returns>
        public static List<Category> GetDefaultObjects()
        {
            List<Category> tmp = new List<Category>();

            SpecificLocation talltable = SpecificLocation.Placement("tall table");
            talltable.Room = new Room("hallway");
            Category task = new Category("tasks", talltable);
            task.AddObject("dice", GPSRObjectType.Known);
            task.AddObject("light bulb", GPSRObjectType.Known);
            task.AddObject("block", GPSRObjectType.Known);
            tmp.Add(task);

            SpecificLocation longtable_b = SpecificLocation.Placement("long table b");
            longtable_b.Room = new Room("living room");
            Category kitchen = new Category("kitchen items", longtable_b);
            kitchen.AddObject("detergent", GPSRObjectType.Known);
            kitchen.AddObject("cup", GPSRObjectType.Known);
            kitchen.AddObject("lunch box", GPSRObjectType.Alike);
            tmp.Add(kitchen);

            SpecificLocation shelf = SpecificLocation.Placement("shlef");
            shelf.Room = new Room("dining room");
            Category food = new Category("food", shelf);
            food.AddObject("noodle", GPSRObjectType.Known);
            food.AddObject("cookies", GPSRObjectType.Known);
            food.AddObject("potato chips", GPSRObjectType.Known);
            tmp.Add(food);

            return tmp;

        }

        /// <summary>
        /// Gets a list with predefined questions.
        /// </summary>
        /// <returns>A list with predefined questions.</returns>
        internal static List<PredefindedQuestion> GetDefaultQuestions()
        {
            List<PredefindedQuestion> q = new List<PredefindedQuestion>();
            q.Add(new PredefindedQuestion("What is your teamÅfs name?", "My team is SSH."));
            q.Add(new PredefindedQuestion("What day is it today?", "Today is March 8th."));
            q.Add(new PredefindedQuestion("What is the highest mountain in the world?", "It is Mt. Everest."));
            q.Add(new PredefindedQuestion("How much is 174 minus 11?", "It is 163."));
            q.Add(new PredefindedQuestion("How many campuses does Tokyo University have?", "Tokyo University has 3 campuses."));
            q.Add(new PredefindedQuestion("Where will RoboCup 2023 take place?", "RoboCup 2023 will take place in Bordeaux, France."));
            q.Add(new PredefindedQuestion("Who is the current governor of Tokyo?", "The current governor of Tokyo is Yuriko Koike."));
            q.Add(new PredefindedQuestion("Where are you from?", "IÅfm from Japan."));
            q.Add(new PredefindedQuestion("What is your favorite team?", "Absolutely SSH! But weÅfre want to explore other team as well."));
            q.Add(new PredefindedQuestion("How many members in your team?", "I have 10 wonderful members in my team."));
            return q;
        }
    }
}
