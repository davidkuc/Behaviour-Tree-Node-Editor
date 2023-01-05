using UnityEngine;

namespace GhostOfTheLibrary.BehaviourTree
{
    public class SequencerNode : CompositeNode
    {
        int current;

        protected override void OnStart()
        {
            current = 0;
        }

        protected override void OnStop()
        {

        }

        protected override State OnUpdate()
        {
            PrintDebugLog("OnUpdate");

            if (children == null || children.Count == 0)
                return State.Failure;

            var child = children[current];
            switch (child.Update())
            {
                case State.Running:
                    return State.Running;
                case State.Failure:
                    return State.Failure;
                case State.Success:
                    current++;
                    break;
            }

            return current == children.Count ? State.Success : State.Running;
        }
    }
}
