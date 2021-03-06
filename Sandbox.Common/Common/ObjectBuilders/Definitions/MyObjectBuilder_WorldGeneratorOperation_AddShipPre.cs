﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_WorldGeneratorOperation_AddShipPrefab
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65B9437C-6443-4388-AFE3-5DD75CE6625F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;
using System.Xml.Serialization;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
  [XmlType("AddShipPrefab")]
  [MyObjectBuilderDefinition]
  public class MyObjectBuilder_WorldGeneratorOperation_AddShipPrefab : MyObjectBuilder_WorldGeneratorOperation
  {
    [ProtoMember(1)]
    [XmlAttribute]
    public string PrefabFile;
    [ProtoMember(2)]
    public MyPositionAndOrientation Transform;
    [XmlAttribute]
    [ProtoMember(3)]
    public float RandomRadius;

    public bool ShouldSerializeRandomRadius()
    {
      return (double) this.RandomRadius != 0.0;
    }
  }
}
