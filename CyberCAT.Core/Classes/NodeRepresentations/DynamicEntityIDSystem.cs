﻿using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class DynamicEntityIDSystem : NodeRepresentation
    {
        public uint Unknown1 { get; set; }
        public uint Unk_NextEntityHash { get; set; }
        public List<uint> Unknown3 { get; set; }
        public List<KeyValuePair<string, uint>> Unknown4 { get; set; }
        public uint Unk_NextListId { get; set; }

        public DynamicEntityIDSystem()
        {
            Unknown3 = new List<uint>();
            Unknown4 = new List<KeyValuePair<string, uint>>();
        }
    }
}