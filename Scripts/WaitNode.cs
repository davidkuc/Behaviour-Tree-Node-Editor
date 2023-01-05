using GhostOfTheLibrary.Other;
using UnityEngine;

namespace GhostOfTheLibrary.BehaviourTree
{
    public class WaitNode : ActionNode
    {
        public float duration = 1;
        float startTime;

        protected override void OnStart() => startTime = Time.time;

        protected override void OnStop()
        {

        }

        protected override State OnUpdate()
        {
            if (Time.time - startTime > duration)
            {
                PrintDebugLog("Success");
                return State.Success; 
            }

            PrintDebugLog("Running");
            return State.Running;
        }
    }
}
