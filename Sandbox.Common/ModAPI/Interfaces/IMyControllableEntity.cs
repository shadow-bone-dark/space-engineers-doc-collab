﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.ModAPI.Interfaces.IMyControllableEntity
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87AD5BE9-1B9D-42F5-8000-067AE4AE8CE7
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using Sandbox.ModAPI;
using VRageMath;

namespace Sandbox.ModAPI.Interfaces
{
    /// <summary>
    /// Inaccessible as of version 01.066 (22.1.2015)
    /// </summary>
    public interface IMyControllableEntity
    {
        IMyEntity Entity { get; }

        bool ForceFirstPersonCamera { get; set; }

        bool PrimaryLookaround { get; }

        MatrixD GetHeadMatrix(bool includeY, bool includeX = true, bool forceHeadAnim = false,
            bool forceHeadBone = false);

        void MoveAndRotate(Vector3 moveIndicator, Vector2 rotationIndicator, float rollIndicator);

        void MoveAndRotateStopped();

        void Use();

        void UseContinues();

        void Jump();

        void Walk();

        void Up();

        void Crouch();

        void Down();

        void ShowInventory();

        void ShowTerminal();

        void SwitchThrusts();

        void SwitchDamping();

        void SwitchLights();

        void SwitchLeadingGears();

        void DrawHud(IMyCameraController camera, long playerId);

        void SwitchReactors();

        void Die();
    }
}