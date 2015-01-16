﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.ModAPI.Ingame.IMySensorBlock
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using Sandbox.ModAPI;

namespace Sandbox.ModAPI.Ingame
{
    public interface IMySensorBlock : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
    {
        float LeftExtend { get; }

        float RightExtend { get; }

        float TopExtend { get; }

        float BottomExtend { get; }

        float FrontExtend { get; }

        float BackExtend { get; }

        bool DetectPlayers { get; }

        bool DetectFloatingObjects { get; }

        bool DetectSmallShips { get; }

        bool DetectLargeShips { get; }

        bool DetectStations { get; }

        bool DetectAsteroids { get; }

        bool DetectOwner { get; }

        bool DetectFriendly { get; }

        bool DetectNeutral { get; }

        bool DetectEnemy { get; }

        bool IsActive { get; }

        IMyEntity LastDetectedEntity { get; }
    }
}