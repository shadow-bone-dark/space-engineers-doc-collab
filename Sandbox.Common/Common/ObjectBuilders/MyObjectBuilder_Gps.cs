﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.MyObjectBuilder_Gps
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65B9437C-6443-4388-AFE3-5DD75CE6625F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using System.Collections.Generic;
using VRageMath;

namespace Sandbox.Common.ObjectBuilders
{
  [MyObjectBuilderDefinition]
  [ProtoContract]
  public class MyObjectBuilder_Gps : MyObjectBuilder_Base
  {
    [ProtoMember(1)]
    public List<MyObjectBuilder_Gps.Entry> Entries;

    [ProtoContract]
    public struct Entry
    {
      [ProtoMember(1)]
      public string name;
      [ProtoMember(2)]
      public string description;
      [ProtoMember(3)]
      public Vector3D coords;
      [ProtoMember(4)]
      public bool isFinal;
      [ProtoMember(4)]
      public bool showOnHud;
    }
  }
}
