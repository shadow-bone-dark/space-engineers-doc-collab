﻿// Decompiled with JetBrains decompiler
// Type: VRage.Serialization.TupleSerializer`3
// Assembly: VRage.Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 98EC8A66-D3FB-4994-A617-48E1C71F8818
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\VRage.Library.dll

using VRage;

namespace VRage.Serialization
{
    public class TupleSerializer<T1, T2, T3> : ISerializer<MyTuple<T1, T2, T3>>
    {
        public readonly ISerializer<T1> m_serializer1;
        public readonly ISerializer<T2> m_serializer2;
        public readonly ISerializer<T3> m_serializer3;

        public TupleSerializer(ISerializer<T1> serializer1, ISerializer<T2> serializer2, ISerializer<T3> serializer3)
        {
            this.m_serializer1 = serializer1;
            this.m_serializer2 = serializer2;
            this.m_serializer3 = serializer3;
        }

        void ISerializer<MyTuple<T1, T2, T3>>.Serialize(ByteStream destination, ref MyTuple<T1, T2, T3> data)
        {
            this.m_serializer1.Serialize(destination, ref data.Item1);
            this.m_serializer2.Serialize(destination, ref data.Item2);
            this.m_serializer3.Serialize(destination, ref data.Item3);
        }

        void ISerializer<MyTuple<T1, T2, T3>>.Deserialize(ByteStream source, out MyTuple<T1, T2, T3> data)
        {
            this.m_serializer1.Deserialize(source, out data.Item1);
            this.m_serializer2.Deserialize(source, out data.Item2);
            this.m_serializer3.Deserialize(source, out data.Item3);
        }
    }
}