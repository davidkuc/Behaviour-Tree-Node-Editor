using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostOfTheLibrary.BehaviourTree
{
    public class SuccessNode : DecoratorNode
    {
        protected override void OnStart()
        {

        }

        protected override void OnStop()
        {

        }

        protected override State OnUpdate()
        {
            child?.Update();
            return State.Success;
        }
    }
}
