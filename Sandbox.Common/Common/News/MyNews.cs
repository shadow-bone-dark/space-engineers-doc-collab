﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.News.MyNews
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Sandbox.Common.News
{
    [XmlRoot(ElementName = "News")]
    public class MyNews
    {
        [XmlElement("Entry")] public List<MyNewsEntry> Entry;
    }
}