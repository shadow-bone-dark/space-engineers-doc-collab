﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.Gui.MyObjectBuilder_GuiControlGrid
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52862CFB-4672-4671-9CE3-6D19982FB841
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;

namespace Sandbox.Common.ObjectBuilders.Gui
{
  [ProtoContract]
  [MyObjectBuilderDefinition]
  public class MyObjectBuilder_GuiControlGrid : MyObjectBuilder_GuiControlBase
  {
    [ProtoMember(2)]
    public int DisplayColumnsCount = 1;
    [ProtoMember(3)]
    public int DisplayRowsCount = 1;
    [ProtoMember(1)]
    public MyGuiControlGridStyleEnum VisualStyle;
  }
}
