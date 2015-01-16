﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.MyObjectBuilder_Projector
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using VRageMath;

namespace Sandbox.Common.ObjectBuilders
{
    [MyObjectBuilderDefinition]
    [ProtoContract]
    public class MyObjectBuilder_Projector : MyObjectBuilder_FunctionalBlock
    {
        [ProtoMember(1)] public MyObjectBuilder_CubeGrid ProjectedGrid;
        [ProtoMember(2)] public Vector3I ProjectionOffset;
        [ProtoMember(3)] public Vector3I ProjectionRotation;
        [ProtoMember(4)] public bool KeepProjection;

        public override void Remap(IMyRemapHelper remapHelper)
        {
            base.Remap(remapHelper);
            if (this.ProjectedGrid == null)
                return;
            this.ProjectedGrid.Remap(remapHelper);
        }
    }
}