﻿// Decompiled with JetBrains decompiler
// Type: ParallelTasks.Semaphore
// Assembly: VRage.Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3595035D-D240-4390-9773-1FE64718FDDB
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\VRage.Library.dll

using System.Threading;

namespace ParallelTasks
{
  public class Semaphore
  {
    private object free_lock = new object();
    private AutoResetEvent gate;
    private int free;

    public Semaphore(int maximumCount)
    {
      this.free = maximumCount;
      this.gate = new AutoResetEvent(this.free > 0);
    }

    public void WaitOne()
    {
      this.gate.WaitOne();
      lock (this.free_lock)
      {
        --this.free;
        if (this.free <= 0)
          return;
        this.gate.Set();
      }
    }

    public void Release()
    {
      lock (this.free_lock)
      {
        ++this.free;
        this.gate.Set();
      }
    }
  }
}
