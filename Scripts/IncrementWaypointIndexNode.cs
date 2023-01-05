namespace GhostOfTheLibrary.BehaviourTree
{
    public class IncrementWaypointIndexNode : ActionNode
    {
        protected override void OnStart()
        {
            blackboard.waypointsIndex++;
            if (blackboard.waypointsIndex == blackboard.waypoints.Count)
                blackboard.waypointsIndex = 0;
            //var newIndex = blackboard.waypointsIndex;

            //if (newIndex == blackboard.waypoints.Count)
            //    blackboard.waypointsIndex = 0;
            //else
            //    blackboard.waypointsIndex = newIndex;

            PrintDebugLog($"Current Index ==> {blackboard.waypointsIndex}");
        }

        protected override void OnStop()
        {

        }

        protected override State OnUpdate() => State.Success;
    }
}
