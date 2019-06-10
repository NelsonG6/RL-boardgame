﻿using System.Collections.Generic;

namespace ReinforcementLearning
{
    //This class handles the types of results we get after applying a move to the board.
    class MoveResult
    {
        public string result_data;

        public static readonly MoveResult CanMissing;
        public static readonly MoveResult CanCollected;
        public static readonly MoveResult TravelSucceeded;
        public static readonly MoveResult TravelFailed;
        public static readonly MoveResult EnemeyEncountered;        

        private static MoveResult initialized_result;

        public static Dictionary<MoveResult, double> list;

        public MoveResult(string to_set)
        {
            result_data = to_set;
        }

        static MoveResult()
        {
            list = new Dictionary<MoveResult, double>(); //initialize reinforcement factor list

            CanMissing = new MoveResult("Can missing");
            CanCollected = new MoveResult("Can collected");
            TravelSucceeded = new MoveResult("Move successful");
            TravelFailed = new MoveResult("Move failed");
            EnemeyEncountered = new MoveResult("Enemey encountered");
            initialized_result = new MoveResult("Initialized");

            list.Add(CanMissing, InitialSettings.CanMissingReward);
            list.Add(CanCollected, InitialSettings.CanGrabbedReward);
            list.Add(TravelSucceeded, InitialSettings.MoveSuccessfulReward);
            list.Add(TravelFailed, InitialSettings.MoveFailedReward);
            list.Add(EnemeyEncountered, InitialSettings.EnemyEncountered);

        }
    }
}
