﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.MyObjectBuilder_MyProgrammableBlock
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;

namespace Sandbox.Common.ObjectBuilders
{
    [MyObjectBuilderDefinition]
    [ProtoContract]
    public class MyObjectBuilder_MyProgrammableBlock : MyObjectBuilder_FunctionalBlock
    {
        [ProtoMember(2)] public string Storage = "";
        [ProtoMember(1)] public string Program;
    }
}