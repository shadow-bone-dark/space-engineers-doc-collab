﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.Gui.MyObjectBuilder_GuiScreen
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52862CFB-4672-4671-9CE3-6D19982FB841
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;
using VRageMath;

namespace Sandbox.Common.ObjectBuilders.Gui
{
  [MyObjectBuilderDefinition]
  [ProtoContract]
  public class MyObjectBuilder_GuiScreen : MyObjectBuilder_Base
  {
    [ProtoMember(1)]
    public MyObjectBuilder_GuiControls Controls;
    [ProtoMember(2)]
    public Vector4? BackgroundColor;
    [ProtoMember(3)]
    public string BackgroundTexture;
    [ProtoMember(4)]
    public Vector2? Size;
    [ProtoMember(5)]
    public bool CloseButtonEnabled;
    [ProtoMember(7)]
    public Vector2 CloseButtonOffset;

    public bool ShouldSerializeCloseButtonOffset()
    {
      return this.CloseButtonEnabled;
    }
  }
}
