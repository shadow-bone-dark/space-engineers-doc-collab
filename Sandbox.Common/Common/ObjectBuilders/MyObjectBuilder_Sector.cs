﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.MyObjectBuilder_Sector
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65B9437C-6443-4388-AFE3-5DD75CE6625F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common;
using System.Collections.Generic;
using System.Xml.Serialization;
using VRageMath;

namespace Sandbox.Common.ObjectBuilders
{
  [ProtoContract]
  [MyObjectBuilderDefinition]
  public class MyObjectBuilder_Sector : MyObjectBuilder_Base
  {
    [ProtoMember(1)]
    public Vector3I Position;
    [ProtoMember(3)]
    public MyObjectBuilder_GlobalEvents SectorEvents;
    [ProtoMember(4)]
    public int AppVersion;
    [ProtoMember(5)]
    public MyObjectBuilder_Encounters Encounters;

    [ProtoMember(2)]
    [XmlArrayItem("MyObjectBuilder_EntityBase", Type = typeof (MyAbstractXmlSerializer<MyObjectBuilder_EntityBase>))]
    public List<MyObjectBuilder_EntityBase> SectorObjects { get; set; }
  }
}
