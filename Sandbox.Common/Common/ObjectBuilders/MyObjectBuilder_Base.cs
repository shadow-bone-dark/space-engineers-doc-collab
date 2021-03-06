﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.MyObjectBuilder_Base
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65B9437C-6443-4388-AFE3-5DD75CE6625F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders.Serializer;
using System.ComponentModel;
using System.Xml.Serialization;
using VRage.Common.Utils;

namespace Sandbox.Common.ObjectBuilders
{
  [ProtoContract]
  public abstract class MyObjectBuilder_Base
  {
    private MyStringId m_subtypeId;
    private string m_subtypeName;

    [DefaultValue(0)]
    public MyStringId SubtypeId
    {
      get
      {
        return this.m_subtypeId;
      }
    }

    [ProtoMember(2)]
    [DefaultValue(null)]
    public string SubtypeName
    {
      get
      {
        return this.m_subtypeName;
      }
      set
      {
        this.m_subtypeName = value;
        this.m_subtypeId = MyStringId.GetOrCompute(value);
      }
    }

    [XmlIgnore]
    public MyObjectBuilderType TypeId
    {
      get
      {
        return (MyObjectBuilderType) this.GetType();
      }
    }

    public bool ShouldSerializeSubtypeId()
    {
      return false;
    }

    public MyObjectBuilder_Base Clone()
    {
      return MyObjectBuilderSerializer.Clone(this);
    }
  }
}
