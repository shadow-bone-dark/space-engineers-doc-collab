﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Definitions.MyAudioDefinition
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52862CFB-4672-4671-9CE3-6D19982FB841
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using Sandbox.Common.ObjectBuilders.Audio;
using Sandbox.Common.ObjectBuilders.Definitions;
using System;
using System.Collections.Generic;
using VRage.Common.Utils;

namespace Sandbox.Definitions
{
  [MyDefinitionType(typeof (MyObjectBuilder_AudioDefinition))]
  public class MyAudioDefinition : MyDefinitionBase
  {
    public MyStringId Category;
    public MyAudioHelpers.CurveType VolumeCurve;
    public float MaxDistance;
    public float Volume;
    public float VolumeVariation;
    public float PitchVariation;
    public bool Loopable;
    public string Alternative2D;
    public bool UseOcclusion;
    public List<MyAudioHelpers.Wave> Waves;
    public MyMusicTrack MusicTrack;

    public bool IsHudCue
    {
      get
      {
        return StringComparer.InvariantCultureIgnoreCase.Equals((object) this.Category, (object) "hud");
      }
    }

    protected override void Init(MyObjectBuilder_DefinitionBase builder)
    {
      base.Init(builder);
      MyObjectBuilder_AudioDefinition builderAudioDefinition = builder as MyObjectBuilder_AudioDefinition;
      this.Category = MyStringId.GetOrCompute(builderAudioDefinition.Category);
      this.VolumeCurve = builderAudioDefinition.VolumeCurve;
      this.MaxDistance = builderAudioDefinition.MaxDistance;
      this.Volume = builderAudioDefinition.Volume;
      this.VolumeVariation = builderAudioDefinition.VolumeVariation;
      this.PitchVariation = builderAudioDefinition.PitchVariation;
      this.Loopable = builderAudioDefinition.Loopable;
      this.Alternative2D = builderAudioDefinition.Alternative2D;
      this.UseOcclusion = builderAudioDefinition.UseOcclusion;
      this.Waves = builderAudioDefinition.Waves;
      if (string.IsNullOrEmpty(builderAudioDefinition.TransitionCategory) || string.IsNullOrEmpty(builderAudioDefinition.MusicCategory))
        return;
      this.MusicTrack.TransitionCategory = MyStringId.GetOrCompute(builderAudioDefinition.TransitionCategory);
      this.MusicTrack.MusicCategory = MyStringId.GetOrCompute(builderAudioDefinition.MusicCategory);
    }

    public override MyObjectBuilder_DefinitionBase GetObjectBuilder()
    {
      MyObjectBuilder_AudioDefinition builderAudioDefinition = (MyObjectBuilder_AudioDefinition) base.GetObjectBuilder();
      builderAudioDefinition.Category = this.Category.ToString();
      builderAudioDefinition.VolumeCurve = this.VolumeCurve;
      builderAudioDefinition.MaxDistance = this.MaxDistance;
      builderAudioDefinition.Volume = this.Volume;
      builderAudioDefinition.VolumeVariation = this.VolumeVariation;
      builderAudioDefinition.PitchVariation = this.PitchVariation;
      builderAudioDefinition.Loopable = this.Loopable;
      builderAudioDefinition.Alternative2D = this.Alternative2D;
      builderAudioDefinition.UseOcclusion = this.UseOcclusion;
      builderAudioDefinition.Waves = this.Waves;
      if (this.MusicTrack.TransitionCategory != MyStringId.NullOrEmpty)
      {
        builderAudioDefinition.TransitionCategory = this.MusicTrack.TransitionCategory.ToString();
        builderAudioDefinition.MusicCategory = this.MusicTrack.MusicCategory.ToString();
      }
      return (MyObjectBuilder_DefinitionBase) builderAudioDefinition;
    }
  }
}
