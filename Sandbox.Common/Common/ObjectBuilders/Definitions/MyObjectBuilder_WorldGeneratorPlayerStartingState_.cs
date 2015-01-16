﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_WorldGeneratorPlayerStartingState_Transform
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;
using System.Xml.Serialization;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
    [XmlType("Transform")]
    [MyObjectBuilderDefinition]
    public class MyObjectBuilder_WorldGeneratorPlayerStartingState_Transform :
        MyObjectBuilder_WorldGeneratorPlayerStartingState
    {
        [ProtoMember(1)] public MyPositionAndOrientation? Transform;
        [ProtoMember(2)] [XmlAttribute] public bool JetpackEnabled;
        [ProtoMember(3)] [XmlAttribute] public bool DampenersEnabled;

        public bool ShouldSerializeTransform()
        {
            return this.Transform.HasValue;
        }
    }
}