﻿// Decompiled with JetBrains decompiler
// Type: DShowNET.Dvd.DvdStreamFlags
// Assembly: VRage.Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3595035D-D240-4390-9773-1FE64718FDDB
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\VRage.Library.dll

using System;

namespace DShowNET.Dvd
{
  [Flags]
  public enum DvdStreamFlags
  {
    None = 0,
    Video = 1,
    Audio = 2,
    SubPic = 4,
  }
}
