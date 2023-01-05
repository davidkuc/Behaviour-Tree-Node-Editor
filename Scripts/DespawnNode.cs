using GhostOfTheLibrary.Characters.Client;
using UnityEngine;

namespace GhostOfTheLibrary.BehaviourTree
{
    public class DespawnNode : ActionNode
    {
        protected override void OnStart()
        {
     
        }

        protected override void OnStop()
        {
            
        }

        protected override State OnUpdate()
        {
            if (blackboard.waypointsIndex == 0 && 
                (blackboard.client.State == Client.States.RetrievedBook || blackboard.client.State == Client.States.DidNotRetrieveBook))
            {
                PrintDebugLog("Despawn!");
                blackboard.client.gameObject.SetActive(false);
            }

            return State.Success;
        }
    }
}
