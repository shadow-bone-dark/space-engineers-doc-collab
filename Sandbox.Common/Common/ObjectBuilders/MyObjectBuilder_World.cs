﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.MyObjectBuilder_World
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52862CFB-4672-4671-9CE3-6D19982FB841
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using VRage.Serialization;

namespace Sandbox.Common.ObjectBuilders
{
  [MyObjectBuilderDefinition]
  [ProtoContract]
  public class MyObjectBuilder_World : MyObjectBuilder_Base
  {
    [ProtoMember(1)]
    public MyObjectBuilder_Checkpoint Checkpoint;
    [ProtoMember(2)]
    public MyObjectBuilder_Sector Sector;
    [ProtoMember(3)]
    public SerializableDictionary<string, byte[]> VoxelMaps;
  }
}
