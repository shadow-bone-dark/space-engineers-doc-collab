﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_LargeTurretBaseDefinition
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52862CFB-4672-4671-9CE3-6D19982FB841
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
  [MyObjectBuilderDefinition]
  [ProtoContract]
  public class MyObjectBuilder_LargeTurretBaseDefinition : MyObjectBuilder_WeaponBlockDefinition
  {
    [ProtoMember(2)]
    public bool AiEnabled = true;
    [ProtoMember(1)]
    public string OverlayTexture;
  }
}
