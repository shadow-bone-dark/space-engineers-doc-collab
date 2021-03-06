﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_MissileAmmoDefinition
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65B9437C-6443-4388-AFE3-5DD75CE6625F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;
using System.ComponentModel;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
  [ProtoContract]
  [MyObjectBuilderDefinition]
  public class MyObjectBuilder_MissileAmmoDefinition : MyObjectBuilder_AmmoDefinition
  {
    [ProtoMember(1)]
    [DefaultValue(null)]
    public MyObjectBuilder_MissileAmmoDefinition.AmmoMissileProperties MissileProperties;

    [ProtoContract]
    public class AmmoMissileProperties
    {
      [ProtoMember(1)]
      public float MissileMass;
      [ProtoMember(2)]
      public float MissileExplosionRadius;
      [ModdableContentFile("mwm")]
      [ProtoMember(3)]
      public string MissileModelName;
      [ProtoMember(4)]
      public float MissileAcceleration;
      [ProtoMember(5)]
      public float MissileInitialSpeed;
      [ProtoMember(6)]
      public bool MissileSkipAcceleration;
      [ProtoMember(7)]
      public float MissileExplosionDamage;
    }
  }
}
