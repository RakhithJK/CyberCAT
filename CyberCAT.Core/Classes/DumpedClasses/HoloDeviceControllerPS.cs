using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("HoloDeviceControllerPS")]
    public class HoloDeviceControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("isPlaying")]
        [RealType("Bool")]
        public bool IsPlaying { get; set; }
    }
}