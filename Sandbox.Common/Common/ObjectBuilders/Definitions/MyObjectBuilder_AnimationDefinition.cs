﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AnimationDefinition
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65B9437C-6443-4388-AFE3-5DD75CE6625F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
  [MyObjectBuilderDefinition]
  [ProtoContract]
  public class MyObjectBuilder_AnimationDefinition : MyObjectBuilder_DefinitionBase
  {
    [ProtoMember(4)]
    public bool AllowInCockpit = true;
    [ProtoMember(6)]
    public string SupportedSkeletons = "Humanoid";
    [ModdableContentFile("mwm")]
    [ProtoMember(1)]
    public string AnimationModel;
    [ProtoMember(2)]
    public int ClipIndex;
    [ProtoMember(3)]
    public MyBonesArea InfluenceArea;
    [ProtoMember(5)]
    public bool AllowWithWeapon;
    [ProtoMember(7)]
    public bool Loop;
    [ProtoMember(8)]
    public SerializableDefinitionId LeftHandItem;
  }
}
