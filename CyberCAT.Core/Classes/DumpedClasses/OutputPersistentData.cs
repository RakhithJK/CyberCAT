using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;
using CyberCAT.Core.DumpedEnums;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("OutputPersistentData")]
    public class OutputPersistentData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("currentSecurityState")]
        public DumpedEnums.ESecuritySystemState? CurrentSecurityState { get; set; }
        
        [RealName("breachOrigin")]
        public DumpedEnums.EBreachOrigin? BreachOrigin { get; set; }
        
        [RealName("securityStateChanged")]
        public bool SecurityStateChanged { get; set; }
        
        [RealName("lastKnownPosition")]
        public Vector4 LastKnownPosition { get; set; }
        
        [RealName("type")]
        public DumpedEnums.ESecurityNotificationType? Type { get; set; }
        
        [RealName("areaType")]
        public DumpedEnums.ESecurityAreaType? AreaType { get; set; }
        
        [RealName("objectOfInterest")]
        public EntEntityID ObjectOfInterest { get; set; }
        
        [RealName("whoBreached")]
        public EntEntityID WhoBreached { get; set; }
        
        [RealName("reporter")]
        public GamePersistentID Reporter { get; set; }
        
        [RealName("id")]
        public int Id { get; set; }

        public OutputPersistentData()
        {
            CurrentSecurityState = ESecuritySystemState.UNINITIALIZED;
        }
    }
}
