﻿// Decompiled with JetBrains decompiler
// Type: VRage.Serialization.TupleSerializer`4
// Assembly: VRage.Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3595035D-D240-4390-9773-1FE64718FDDB
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\VRage.Library.dll

using VRage;

namespace VRage.Serialization
{
  public class TupleSerializer<T1, T2, T3, T4> : ISerializer<MyTuple<T1, T2, T3, T4>>
  {
    public readonly ISerializer<T1> m_serializer1;
    public readonly ISerializer<T2> m_serializer2;
    public readonly ISerializer<T3> m_serializer3;
    public readonly ISerializer<T4> m_serializer4;

    public TupleSerializer(ISerializer<T1> serializer1, ISerializer<T2> serializer2, ISerializer<T3> serializer3, ISerializer<T4> serializer4)
    {
      this.m_serializer1 = serializer1;
      this.m_serializer2 = serializer2;
      this.m_serializer3 = serializer3;
      this.m_serializer4 = serializer4;
    }

    void ISerializer<MyTuple<T1, T2, T3, T4>>.Serialize(ByteStream destination, ref MyTuple<T1, T2, T3, T4> data)
    {
      this.m_serializer1.Serialize(destination, ref data.Item1);
      this.m_serializer2.Serialize(destination, ref data.Item2);
      this.m_serializer3.Serialize(destination, ref data.Item3);
      this.m_serializer4.Serialize(destination, ref data.Item4);
    }

    void ISerializer<MyTuple<T1, T2, T3, T4>>.Deserialize(ByteStream source, out MyTuple<T1, T2, T3, T4> data)
    {
      this.m_serializer1.Deserialize(source, out data.Item1);
      this.m_serializer2.Deserialize(source, out data.Item2);
      this.m_serializer3.Deserialize(source, out data.Item3);
      this.m_serializer4.Deserialize(source, out data.Item4);
    }
  }
}
