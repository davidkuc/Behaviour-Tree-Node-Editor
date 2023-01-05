namespace GhostOfTheLibrary.BehaviourTree
{
    public class DetectCounterTriggerNode : DecoratorNode
    {
        protected override void OnStart()
        {

        }

        protected override void OnStop()
        {
   
        }

        protected override State OnUpdate()
        {
            if (blackboard.waypoints[blackboard.waypointsIndex].GetComponent<Waypoint>().IsCounterTrigger)
                return child.Update();

            return State.Success;
        }
    }
}
