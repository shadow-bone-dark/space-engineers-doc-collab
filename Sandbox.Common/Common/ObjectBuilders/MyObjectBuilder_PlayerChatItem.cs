﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.MyObjectBuilder_PlayerChatItem
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52862CFB-4672-4671-9CE3-6D19982FB841
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Sandbox.Common.ObjectBuilders
{
  [MyObjectBuilderDefinition]
  [ProtoContract]
  public class MyObjectBuilder_PlayerChatItem : MyObjectBuilder_Base
  {
    [ProtoMember(4)]
    [DefaultValue(true)]
    [XmlElement(ElementName = "S")]
    public bool Sent = true;
    [ProtoMember(1)]
    [XmlAttribute("t")]
    public string Text;
    [ProtoMember(2)]
    [XmlElement(ElementName = "I")]
    public long IdentityIdUniqueNumber;
    [XmlElement(ElementName = "T")]
    [ProtoMember(3)]
    public long TimestampMs;
  }
}
