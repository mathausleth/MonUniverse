using System.ComponentModel;

namespace MonUniverse.Enums
{
    public enum RunStates
    {
        STOPPED,
        STARTING,
        RUNNING,
        [Description("STOPPING")]
        STOPPING
    }
}