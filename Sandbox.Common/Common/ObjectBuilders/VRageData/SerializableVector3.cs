﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.VRageData.SerializableVector3
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65B9437C-6443-4388-AFE3-5DD75CE6625F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using System.Xml.Serialization;
using VRageMath;

namespace Sandbox.Common.ObjectBuilders.VRageData
{
  [ProtoContract]
  public struct SerializableVector3
  {
    public float X;
    public float Y;
    public float Z;

    [ProtoMember(1)]
    [XmlAttribute]
    public float x
    {
      get
      {
        return this.X;
      }
      set
      {
        this.X = value;
      }
    }

    [ProtoMember(2)]
    [XmlAttribute]
    public float y
    {
      get
      {
        return this.Y;
      }
      set
      {
        this.Y = value;
      }
    }

    [ProtoMember(3)]
    [XmlAttribute]
    public float z
    {
      get
      {
        return this.Z;
      }
      set
      {
        this.Z = value;
      }
    }

    public bool IsZero
    {
      get
      {
        if ((double) this.X == 0.0 && (double) this.Y == 0.0)
          return (double) this.Z == 0.0;
        else
          return false;
      }
    }

    public SerializableVector3(float x, float y, float z)
    {
      this.X = x;
      this.Y = y;
      this.Z = z;
    }

    public static implicit operator Vector3(SerializableVector3 v)
    {
      return new Vector3(v.X, v.Y, v.Z);
    }

    public static implicit operator SerializableVector3(Vector3 v)
    {
      return new SerializableVector3(v.X, v.Y, v.Z);
    }

    public bool ShouldSerializeX()
    {
      return false;
    }

    public bool ShouldSerializeY()
    {
      return false;
    }

    public bool ShouldSerializeZ()
    {
      return false;
    }
  }
}
