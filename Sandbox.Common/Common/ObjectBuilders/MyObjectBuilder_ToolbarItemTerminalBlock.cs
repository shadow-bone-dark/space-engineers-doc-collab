﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.MyObjectBuilder_ToolbarItemTerminalBlock
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;

namespace Sandbox.Common.ObjectBuilders
{
    [MyObjectBuilderDefinition]
    [ProtoContract]
    public class MyObjectBuilder_ToolbarItemTerminalBlock : MyObjectBuilder_ToolbarItemTerminal
    {
        [ProtoMember(1)] public long BlockEntityId;

        public override void Remap(IMyRemapHelper remapHelper)
        {
            this.BlockEntityId = remapHelper.RemapEntityId(this.BlockEntityId);
        }
    }
}