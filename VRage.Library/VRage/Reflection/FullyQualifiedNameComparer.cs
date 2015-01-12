﻿// Decompiled with JetBrains decompiler
// Type: VRage.Reflection.FullyQualifiedNameComparer
// Assembly: VRage.Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FD5D66CE-92BD-4D2D-A5F6-2A600D10290D
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\VRage.Library.dll

using System;
using System.Collections.Generic;

namespace VRage.Reflection
{
    public class FullyQualifiedNameComparer : IComparer<Type>
    {
        public static readonly FullyQualifiedNameComparer Default = new FullyQualifiedNameComparer();

        public int Compare(Type x, Type y)
        {
            return x.FullName.CompareTo(y.FullName);
        }
    }
}