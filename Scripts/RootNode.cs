using UnityEngine;

namespace GhostOfTheLibrary.BehaviourTree
{
    public class RootNode : Node
    {
       [HideInInspector] public Node child;

        protected override void OnStart()
        {

        }

        protected override void OnStop()
        {

        }

        protected override State OnUpdate()
        {
            return child.Update();
        }

        public override Node Clone()
        {
            RootNode node = Instantiate(this);
            node.child = child.Clone();
            return node;
        }
    }
}