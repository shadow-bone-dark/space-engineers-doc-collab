﻿// Decompiled with JetBrains decompiler
// Type: VRageMath.Vector3INormalEqualityComparer
// Assembly: VRage.Math, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 35FD5618-DF34-49B8-BA9B-FE095A7EFE3B
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\VRage.Math.dll

using System.Collections.Generic;

namespace VRageMath
{
  public class Vector3INormalEqualityComparer : IEqualityComparer<Vector3I>
  {
    public bool Equals(Vector3I x, Vector3I y)
    {
      return x.X + 1 + (x.Y + 1) * 3 + (x.Z + 1) * 9 == y.X + 1 + (y.Y + 1) * 3 + (y.Z + 1) * 9;
    }

    public int GetHashCode(Vector3I x)
    {
      return x.X + 1 + (x.Y + 1) * 3 + (x.Z + 1) * 9;
    }
  }
}
