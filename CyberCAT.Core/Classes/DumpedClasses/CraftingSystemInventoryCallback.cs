using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("CraftingSystemInventoryCallback")]
    public class CraftingSystemInventoryCallback : GameInventoryScriptCallback
    {
        [RealName("player")]
        public PlayerPuppet Player { get; set; }
    }
}
