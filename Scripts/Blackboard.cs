using GhostOfTheLibrary.Characters.Client;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace GhostOfTheLibrary.BehaviourTree
{
    [Serializable]
    public class Blackboard
    {
        public Client client;
        public List<Transform> waypoints;
        public int waypointsIndex = 0;
        public bool isTreeResetting;
    }
}
