namespace GhostOfTheLibrary.BehaviourTree
{
    public class MoveToWaypointsNode : ActionNode
    {
        protected override void OnStart() => agent.SetDestination(blackboard.waypoints[blackboard.waypointsIndex]);

        protected override void OnStop()
        {

        }

        protected override State OnUpdate() => State.Success;
    }
}
