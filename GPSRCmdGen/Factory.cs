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
            gestures.Add(new Gesture("standing", DifficultyDegree.Low));
            gestures.Add(new Gesture("raising one hand", DifficultyDegree.Low));
            gestures.Add(new Gesture("waving both hands over head", DifficultyDegree.Low));
            gestures.Add(new Gesture("performing the OK symbol", DifficultyDegree.Low));
            gestures.Add(new Gesture("sitting on a chair", DifficultyDegree.Low));
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
            q.Add(new PredefindedQuestion("What is the highest mountain in Japan?", "It is Mt. Fuji."));
            q.Add(new PredefindedQuestion("What is the largest lake in Japan?", "It is Lake Biwa."));
            q.Add(new PredefindedQuestion("Where are you coming from?", "We are coming from COUNTRY."));
            q.Add(new PredefindedQuestion("Are you enjoying this competition?", "Yes, we are enjoying it a lot."));
            q.Add(new PredefindedQuestion("What is your favorite drink?", "My favorite drink is DRINK_NAME."));
            q.Add(new PredefindedQuestion("How are you today?", "I am feeling EMOTION."));
            q.Add(new PredefindedQuestion("Do Thai people ride an elephant to go to the university?", "No, they ride a dinosaur."));
            q.Add(new PredefindedQuestion("Can you tell me which country won the WBC this year?", "Japan."));
            q.Add(new PredefindedQuestion("Can you tell me how many joints your robot arm has?", "It has NUMBER_OF_ARMS."));
            q.Add(new PredefindedQuestion("What is 3 times 5?", "It is 15."));
            return q;
        }
    }
}
