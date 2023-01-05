using GhostOfTheLibrary.Characters;
using GhostOfTheLibrary.Characters.Client;
using System.Collections.Generic;
using UnityEngine;

namespace GhostOfTheLibrary.BehaviourTree
{
    public class BehaviourTreeRunner : MonoBehaviour
    {
        [SerializeField] private BehaviourTree tree;
        [SerializeField] private List<Transform> waypoints;
        private Ai_Agent agent;
        private Client client;

        public BehaviourTree Tree => tree;

        private void Awake()
        {
            agent = GetComponent<Ai_Agent>();
            client = GetComponent<Client>();
        }

        private void OnEnable()
        {        
            transform.position = waypoints[0].position;
        }

        private void OnDisable() => tree.ResetTree();

        void Start()
        {       
            tree = tree.Clone();
            tree.blackboard.waypoints = waypoints;
            tree.blackboard.client = client;
            // just put the agent in the blackboard?
            tree.Bind(agent);
        }

        void Update() => tree.Update();
    }
}
