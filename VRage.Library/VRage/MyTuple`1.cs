﻿// Decompiled with JetBrains decompiler
// Type: VRage.MyTuple`1
// Assembly: VRage.Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 98EC8A66-D3FB-4994-A617-48E1C71F8818
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\VRage.Library.dll

using System.Runtime.InteropServices;

namespace VRage
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct MyTuple<T1>
    {
        public T1 Item1;

        public MyTuple(T1 item1)
        {
            this.Item1 = item1;
        }
    }
}