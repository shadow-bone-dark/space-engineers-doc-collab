﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_FactionMember
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65B9437C-6443-4388-AFE3-5DD75CE6625F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
  [ProtoContract]
  public struct MyObjectBuilder_FactionMember
  {
    [ProtoMember(1)]
    public long PlayerId;
    [ProtoMember(2)]
    public bool IsLeader;
    [ProtoMember(3)]
    public bool IsFounder;
  }
}
