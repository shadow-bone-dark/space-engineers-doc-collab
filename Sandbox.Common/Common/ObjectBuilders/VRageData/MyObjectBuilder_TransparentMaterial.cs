﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.VRageData.MyObjectBuilder_TransparentMaterial
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AEA4A40D-6023-45C7-A56E-9FAD0E8F073F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;
using System.ComponentModel;
using VRageMath;

namespace Sandbox.Common.ObjectBuilders.VRageData
{
    [MyObjectBuilderDefinition]
    [ProtoContract]
    public class MyObjectBuilder_TransparentMaterial : MyObjectBuilder_Base
    {
        [ProtoMember(3)] [DefaultValue(1)] public float AlphaMistingStart = 1f;
        [ProtoMember(4)] [DefaultValue(4)] public float AlphaMistingEnd = 4f;
        [DefaultValue(1)] [ProtoMember(5)] public float AlphaSaturation = 1f;
        [ProtoMember(9)] [DefaultValue(true)] public bool NeedSort = true;
        [ProtoMember(13)] public Vector2 UVOffset = new Vector2(0.0f, 0.0f);
        [ProtoMember(14)] public Vector2 UVSize = new Vector2(1f, 1f);
        [ProtoMember(1)] public string Name;
        [ProtoMember(2)] public bool AlphaMistingEnable;
        [ProtoMember(6)] public bool CanBeAffectedByOtherLights;
        [ProtoMember(7)] public float Emissivity;
        [ProtoMember(8)] public bool IgnoreDepth;
        [ProtoMember(10)] public float SoftParticleDistanceScale;
        [ProtoMember(11)] public string Texture;
        [ProtoMember(12)] public bool UseAtlas;
        [ProtoMember(15)] public bool Reflection;
    }
}