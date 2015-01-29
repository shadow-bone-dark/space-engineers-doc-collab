﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.AI.MyObjectBuilder_BlockNavigationInfo
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52862CFB-4672-4671-9CE3-6D19982FB841
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;
using Sandbox.Common.ObjectBuilders.VRageData;
using System.Xml.Serialization;

namespace Sandbox.Common.ObjectBuilders.AI
{
  [ProtoContract]
  [MyObjectBuilderDefinition]
  public class MyObjectBuilder_BlockNavigationInfo : MyObjectBuilder_Base
  {
    [XmlArrayItem("Triangle")]
    [ProtoMember(1)]
    public MyObjectBuilder_BlockNavigationInfo.Triangle[] Triangles;

    [ProtoContract]
    public class Triangle
    {
      [XmlArrayItem("Point")]
      [ProtoMember(1)]
      public SerializableVector3[] Points;
    }
  }
}
