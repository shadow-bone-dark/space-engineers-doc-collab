﻿// Decompiled with JetBrains decompiler
// Type: VRage.Trace.MyTrace
// Assembly: VRage.Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F987C912-6032-4943-850E-69DEE0217B30
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\VRage.Library.dll

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace VRage.Trace
{
  public static class MyTrace
  {
    private static MyNullTrace m_nullTrace = new MyNullTrace();
    private const string WindowPrefix = "SE_ID";
    private const string WindowName = "SE";
    private static Dictionary<int, ITrace> m_traces;

    [Conditional("DEBUG")]
    public static void Init(InitTraceHandler handler)
    {
    }

    [Conditional("DEBUG")]
    public static void InitWinTrace()
    {
    }

    [Conditional("DEBUG")]
    [Conditional("DEVELOP")]
    private static void InitInternal(InitTraceHandler handler)
    {
      MyTrace.m_traces = new Dictionary<int, ITrace>();
      string str = "SE";
      foreach (object obj in Enum.GetValues(typeof (TraceWindow)))
      {
        string traceName = (TraceWindow) obj == TraceWindow.Default ? str : str + "_" + obj.ToString();
        string traceId = string.Format("{0}_{1}", (object) "SE_ID", (object) traceName);
        MyTrace.m_traces[(int) obj] = handler(traceId, traceName);
      }
    }

    private static ITrace InitWintraceHandler(string traceId, string traceName)
    {
      return MyWintraceWrapper.CreateTrace(traceId, traceName);
    }

    [Conditional("DEBUG")]
    public static void Watch(string name, object value)
    {
      MyTrace.GetTrace(TraceWindow.Default).Watch(name, value);
    }

    [Conditional("DEBUG")]
    public static void Send(TraceWindow window, string msg, string comment = null)
    {
      MyTrace.GetTrace(window).Send(msg, comment);
    }

    public static ITrace GetTrace(TraceWindow window)
    {
      ITrace trace;
      if (MyTrace.m_traces == null || !MyTrace.m_traces.TryGetValue((int) window, out trace))
        trace = (ITrace) MyTrace.m_nullTrace;
      return trace;
    }
  }
}
