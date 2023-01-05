using GhostOfTheLibrary.Characters.Client;
using UnityEngine;

namespace GhostOfTheLibrary.BehaviourTree
{
    public class WaitForBookNode : ActionNode
    {
        public float duration = 1;
        float startTime;

        protected override void OnStart()
        {
            PrintDebugLog("Started");
            startTime = Time.time;
            //blackboard.client.State = Client.States.Waiting;
        }

        protected override void OnStop()
        {

        }

        protected override State OnUpdate()
        {
            if (blackboard.isTreeResetting)
            {
                blackboard.isTreeResetting = false;
                OnStart();
            }

            if (blackboard.client.State == Client.States.RetrievedBook)
            {
                PrintDebugLog("RetrievedBook");
                blackboard.client.TriggerRetrieveBookPopup();
                return State.Success;
            }

            if (Time.time - startTime > duration)
            {
                if (blackboard.client.State == Client.States.RetrievedBook)
                {
                    PrintDebugLog("RetrievedBook");
                    blackboard.client.TriggerRetrieveBookPopup();
                    return State.Success;
                }
                else
                {
                    blackboard.client.State = Client.States.DidNotRetrieveBook;
                    blackboard.client.TriggerDidNotRetrieveBookPopup();
                    PrintDebugLog("DidNotRetrieveBook");
                    return State.Success;
                }
            }

            PrintDebugLog("Waiting for book");
            return State.Running;
        }
    }
}
