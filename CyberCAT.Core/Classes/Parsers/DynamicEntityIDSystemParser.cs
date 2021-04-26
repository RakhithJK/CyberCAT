﻿using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class DynamicEntityIDSystemParser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public DynamicEntityIDSystemParser()
        {
            ParsableNodeName = Constants.NodeNames.DYNAMIC_ENTITYID_SYSTEM;
            DisplayName = "Dynamic EntityID System Parser";
            Guid = Guid.Parse("{791B9AB0-A63F-4037-9DE2-7AADC1DA2274}");
        }
        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new DynamicEntityIDSystem();

            reader.Skip(4); // Skip Id
            result.Unknown1 = reader.ReadUInt32();
            result.Unk_NextEntityHash = reader.ReadUInt32();

            var unkCount = reader.ReadUInt32();
            for (int i = 0; i < unkCount; i++)
            {
                result.Unknown3.Add(reader.ReadUInt32());
            }

            var stringCount = reader.ReadUInt32();
            for (int i = 0; i < stringCount; i++)
            {
                result.Unknown4.Add(new KeyValuePair<string, uint>(reader.ReadPackedString(), reader.ReadUInt32()));
            }

            result.Unk_NextListId = reader.ReadUInt32();

            result.Node = node;

            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (DynamicEntityIDSystem) node.Value;

            writer.Write(data.Unknown1);
            writer.Write(data.Unk_NextEntityHash);

            writer.Write(data.Unknown3.Count);
            foreach (var item in data.Unknown3)
            {
                writer.Write(item);
            }

            writer.Write(data.Unknown4.Count);
            foreach (var pair in data.Unknown4)
            {
                writer.WritePackedString(pair.Key);
                writer.Write(pair.Value);
            }

            writer.Write(data.Unk_NextListId);
        }
    }
}