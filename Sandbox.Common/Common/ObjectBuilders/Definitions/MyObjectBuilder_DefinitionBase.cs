﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_DefinitionBase
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65B9437C-6443-4388-AFE3-5DD75CE6625F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
  [ProtoContract]
  [MyObjectBuilderDefinition]
  public abstract class MyObjectBuilder_DefinitionBase : MyObjectBuilder_Base
  {
    [DefaultValue(true)]
    [ProtoMember(5)]
    public bool Public = true;
    [ProtoMember(6)]
    [DefaultValue(true)]
    [XmlAttribute(AttributeName = "Enabled")]
    public bool Enabled = true;
    [ProtoMember(1)]
    public SerializableDefinitionId Id;
    [DefaultValue("")]
    [ProtoMember(2)]
    public string DisplayName;
    [DefaultValue("")]
    [ProtoMember(3)]
    public string Description;
    [ProtoMember(4)]
    [ModdableContentFile("dds")]
    public string Icon;
  }
}
