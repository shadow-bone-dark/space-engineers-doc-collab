﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Definitions.DefinitionIdBlit
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;
using VRage.Common.Utils;

namespace Sandbox.Definitions
{
    [ProtoContract]
    public struct DefinitionIdBlit
    {
        [ProtoMember(1)] public MyRuntimeObjectBuilderId TypeId;
        [ProtoMember(2)] public MyStringId SubtypeId;

        public DefinitionIdBlit(MyObjectBuilderType type, MyStringId subtypeId)
        {
            this.TypeId = (MyRuntimeObjectBuilderId) type;
            this.SubtypeId = subtypeId;
        }

        public DefinitionIdBlit(MyRuntimeObjectBuilderId typeId, MyStringId subtypeId)
        {
            this.TypeId = typeId;
            this.SubtypeId = subtypeId;
        }

        public static implicit operator MyDefinitionId(DefinitionIdBlit id)
        {
            return new MyDefinitionId((MyObjectBuilderType) id.TypeId, id.SubtypeId);
        }

        public static implicit operator DefinitionIdBlit(MyDefinitionId id)
        {
            return new DefinitionIdBlit(id.TypeId, id.SubtypeId);
        }
    }
}