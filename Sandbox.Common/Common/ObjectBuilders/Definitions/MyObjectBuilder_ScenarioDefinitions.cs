﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_ScenarioDefinitions
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AEA4A40D-6023-45C7-A56E-9FAD0E8F073F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;
using System.Xml.Serialization;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
  [XmlRoot("ScenarioDefinitions")]
  [ProtoContract]
  [MyObjectBuilderDefinition]
  public class MyObjectBuilder_ScenarioDefinitions : MyObjectBuilder_Base
  {
    [XmlArrayItem("ScenarioDefinition")]
    [ProtoMember(1)]
    public MyObjectBuilder_ScenarioDefinition[] Scenarios;
  }
}