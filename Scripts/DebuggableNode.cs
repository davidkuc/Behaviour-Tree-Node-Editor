using UnityEngine;

namespace GhostOfTheLibrary.BehaviourTree
{
    public class DebuggableNode : ScriptableObject
    {
        [SerializeField] protected bool showDebugLogs;

        protected virtual void PrintDebugLog(string message)
        {
#if UNITY_EDITOR
            if (showDebugLogs)
                Debug.Log("GameObject: ".Color(Color.magenta) + name + " --- " + "Class: ".Color(Color.green) + GetType().Name
                    + $"\r\n"
                    + "Message --> ".Color(Color.red) + message);
#endif
        }
    }
}
