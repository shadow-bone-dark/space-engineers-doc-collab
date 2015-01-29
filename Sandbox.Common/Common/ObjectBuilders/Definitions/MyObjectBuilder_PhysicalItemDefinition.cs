﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_PhysicalItemDefinition
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52862CFB-4672-4671-9CE3-6D19982FB841
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;
using System.ComponentModel;
using VRageMath;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
  [MyObjectBuilderDefinition]
  [ProtoContract]
  public class MyObjectBuilder_PhysicalItemDefinition : MyObjectBuilder_DefinitionBase
  {
    [ProtoMember(3)]
    [ModdableContentFile("mwm")]
    public string Model = "Models\\Components\\Sphere.mwm";
    [DefaultValue(null)]
    [ProtoMember(5)]
    public float? Volume = new float?();
    [ProtoMember(1)]
    public Vector3 Size;
    [ProtoMember(2)]
    public float Mass;
    [DefaultValue(null)]
    [ProtoMember(4)]
    public string IconSymbol;

    public bool ShouldSerializeIconSymbol()
    {
      return this.IconSymbol != null;
    }
  }
}
