﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.MyEntityUpdateEnum
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using System;

namespace Sandbox.Common
{
    [Flags]
    public enum MyEntityUpdateEnum
    {
        NONE = 0,
        EACH_FRAME = 1,
        EACH_10TH_FRAME = 2,
        EACH_100TH_FRAME = 4,
        BEFORE_NEXT_FRAME = 8,
    }
}