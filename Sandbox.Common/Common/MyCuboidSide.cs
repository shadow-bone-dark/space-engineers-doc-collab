﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.MyCuboidSide
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using VRage.Common;
using VRageMath;

namespace Sandbox.Common
{
    public class MyCuboidSide
    {
        public MyPlane Plane = new MyPlane();
        public Line[] Lines = new Line[4];

        public MyCuboidSide()
        {
            this.Lines[0] = new Line();
            this.Lines[1] = new Line();
            this.Lines[2] = new Line();
            this.Lines[3] = new Line();
        }

        public void CreatePlaneFromLines()
        {
            this.Plane.Normal = Vector3.Cross(this.Lines[1].Direction, this.Lines[0].Direction);
            this.Plane.Point = this.Lines[0].From;
        }
    }
}