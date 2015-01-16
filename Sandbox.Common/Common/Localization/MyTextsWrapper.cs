﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.Localization.MyTextsWrapper
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using Sandbox.Common.Resources;
using System;
using System.Globalization;
using System.Text;
using VRage.Common.Utils;

namespace Sandbox.Common.Localization
{
    public static class MyTextsWrapper
    {
        private static MyTextsWrapper.TextInfo[] m_sb;

        public static CultureInfo Culture
        {
            get { return MyTexts.Culture; }
            set { MyTexts.Culture = value; }
        }

        public static void Init()
        {
            MyTextsWrapper.m_sb = new MyTextsWrapper.TextInfo[Enum.GetValues(typeof (MyTextsWrapperEnum)).Length];
            MyTextsWrapper.Reload();
        }

        public static StringBuilder Get(MyTextsWrapperEnum textEnum)
        {
            if (MyTextsWrapper.m_sb == null)
                return MyVRageUtils.EmptyStringBuilder;
            else
                return MyTextsWrapper.m_sb[(int) textEnum].StringBuilder;
        }

        public static string GetString(MyTextsWrapperEnum textEnum)
        {
            return MyTextsWrapper.m_sb[(int) textEnum].String;
        }

        public static StringBuilder AppendFormat(this StringBuilder stringBuilder, MyTextsWrapperEnum textEnum,
            object arg0)
        {
            return stringBuilder.AppendFormat(MyTextsWrapper.GetString(textEnum), arg0);
        }

        public static StringBuilder AppendFormat(this StringBuilder stringBuilder, MyTextsWrapperEnum textEnum,
            params object[] args)
        {
            return stringBuilder.AppendFormat(MyTextsWrapper.GetString(textEnum), args);
        }

        public static void Reload()
        {
            MyTextsWrapper.m_sb[0] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.INVALID);
            MyTextsWrapper.m_sb[1] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Afterburner);
            MyTextsWrapper.m_sb[2] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextAreYouSureYouWantToExit);
            MyTextsWrapper.m_sb[3] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.AssignControlJoystick);
            MyTextsWrapper.m_sb[4] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.AssignControlJoystickAxis);
            MyTextsWrapper.m_sb[5] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.AssignControlKeyboard);
            MyTextsWrapper.m_sb[6] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.AssignControlMouse);
            MyTextsWrapper.m_sb[7] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenOptionsButtonAudio);
            MyTextsWrapper.m_sb[8] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCaptionAudioOptions);
            MyTextsWrapper.m_sb[9] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Blank);
            MyTextsWrapper.m_sb[10] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Cancel);
            MyTextsWrapper.m_sb[11] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.CanNotAssignControl);
            MyTextsWrapper.m_sb[12] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.LoadScreenButtonContinueLastGame);
            MyTextsWrapper.m_sb[13] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlAlreadyAssigned);
            MyTextsWrapper.m_sb[14] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlIsNotValid);
            MyTextsWrapper.m_sb[15] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCaptionControls);
            MyTextsWrapper.m_sb[16] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMenuButtonCredits);
            MyTextsWrapper.m_sb[17] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysDelete);
            MyTextsWrapper.m_sb[18] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysDown);
            MyTextsWrapper.m_sb[19] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DoYouWantToKeepTheseSettingsXSecondsRemaining);
            MyTextsWrapper.m_sb[20] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Drill);
            MyTextsWrapper.m_sb[21] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysEnd);
            MyTextsWrapper.m_sb[22] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMenuButtonExitToMainMenu);
            MyTextsWrapper.m_sb[23] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMenuButtonExitToWindows);
            MyTextsWrapper.m_sb[24] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.FieldOfView);
            MyTextsWrapper.m_sb[25] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_FirePrimaryWeapon);
            MyTextsWrapper.m_sb[26] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_FireSecondaryWeapon);
            MyTextsWrapper.m_sb[27] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenOptionsButtonGame);
            MyTextsWrapper.m_sb[28] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCaptionGameOptions);
            MyTextsWrapper.m_sb[29] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenOptionsControls_Gamepad);
            MyTextsWrapper.m_sb[30] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenOptionsControls_AnalogAxes);
            MyTextsWrapper.m_sb[31] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.GameVolume);
            MyTextsWrapper.m_sb[32] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlTypeGeneral);
            MyTextsWrapper.m_sb[33] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HardwareCursor);
            MyTextsWrapper.m_sb[34] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_ToggleHeadlights);
            MyTextsWrapper.m_sb[35] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_Help);
            MyTextsWrapper.m_sb[36] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysHome);
            MyTextsWrapper.m_sb[37] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysInsert);
            MyTextsWrapper.m_sb[38] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Inventory);
            MyTextsWrapper.m_sb[39] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.InvertMouseX);
            MyTextsWrapper.m_sb[40] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.InvertMouseY);
            MyTextsWrapper.m_sb[41] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Joystick);
            MyTextsWrapper.m_sb[42] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoystickButtonLeft);
            MyTextsWrapper.m_sb[43] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoystickButtonRight);
            MyTextsWrapper.m_sb[44] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoystickButtonUp);
            MyTextsWrapper.m_sb[45] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoystickButtonDown);
            MyTextsWrapper.m_sb[46] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoystickDeadzone);
            MyTextsWrapper.m_sb[47] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoystickExponent);
            MyTextsWrapper.m_sb[48] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoystickSensitivity);
            MyTextsWrapper.m_sb[49] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenOptionsControls_Keyboard);
            MyTextsWrapper.m_sb[50] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Language);
            MyTextsWrapper.m_sb[51] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysLeft);
            MyTextsWrapper.m_sb[52] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysLeftAlt);
            MyTextsWrapper.m_sb[53] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysLeftControl);
            MyTextsWrapper.m_sb[54] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.LeftMouseButton);
            MyTextsWrapper.m_sb[55] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysLeftShift);
            MyTextsWrapper.m_sb[56] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.LoadScreenButtonLoad);
            MyTextsWrapper.m_sb[57] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.LoadingPleaseWaitUppercase);
            MyTextsWrapper.m_sb[58] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxCaptionError);
            MyTextsWrapper.m_sb[59] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxCaptionPleaseConfirm);
            MyTextsWrapper.m_sb[60] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxCaptionExit);
            MyTextsWrapper.m_sb[61] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MiddleMouseButton);
            MyTextsWrapper.m_sb[62] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenOptionsControls_Mouse);
            MyTextsWrapper.m_sb[63] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MouseSensitivity);
            MyTextsWrapper.m_sb[64] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MouseXButton1);
            MyTextsWrapper.m_sb[65] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MouseXButton2);
            MyTextsWrapper.m_sb[66] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlTypeNavigation);
            MyTextsWrapper.m_sb[67] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCaptionNewWorld);
            MyTextsWrapper.m_sb[68] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.No);
            MyTextsWrapper.m_sb[69] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysNumPad0);
            MyTextsWrapper.m_sb[70] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysNumPad1);
            MyTextsWrapper.m_sb[71] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysNumPad2);
            MyTextsWrapper.m_sb[72] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysNumPad3);
            MyTextsWrapper.m_sb[73] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysNumPad4);
            MyTextsWrapper.m_sb[74] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysNumPad5);
            MyTextsWrapper.m_sb[75] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysNumPad6);
            MyTextsWrapper.m_sb[76] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysNumPad7);
            MyTextsWrapper.m_sb[77] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysNumPad8);
            MyTextsWrapper.m_sb[78] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysNumPad9);
            MyTextsWrapper.m_sb[79] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Ok);
            MyTextsWrapper.m_sb[80] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCaptionOptions);
            MyTextsWrapper.m_sb[81] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysPageDown);
            MyTextsWrapper.m_sb[82] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysPageUp);
            MyTextsWrapper.m_sb[83] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.RecommendedAspectRatio);
            MyTextsWrapper.m_sb[84] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.RenderQuality);
            MyTextsWrapper.m_sb[85] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.RenderQualityExtreme);
            MyTextsWrapper.m_sb[86] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.RenderQualityHigh);
            MyTextsWrapper.m_sb[87] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.RenderQualityNormal);
            MyTextsWrapper.m_sb[88] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Revert);
            MyTextsWrapper.m_sb[89] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysRight);
            MyTextsWrapper.m_sb[90] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysRightAlt);
            MyTextsWrapper.m_sb[91] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysRightControl);
            MyTextsWrapper.m_sb[92] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.RightMouseButton);
            MyTextsWrapper.m_sb[93] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysRightShift);
            MyTextsWrapper.m_sb[94] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_RollLeft);
            MyTextsWrapper.m_sb[95] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_RollRight);
            MyTextsWrapper.m_sb[96] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_RotationDown);
            MyTextsWrapper.m_sb[97] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_RotationLeft);
            MyTextsWrapper.m_sb[98] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_RotationRight);
            MyTextsWrapper.m_sb[99] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_RotationUp);
            MyTextsWrapper.m_sb[100] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SelectControl);
            MyTextsWrapper.m_sb[101] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ServerShutdownNotificationCaption);
            MyTextsWrapper.m_sb[102] =
                (MyTextsWrapper.TextInfo)
                    new StringBuilder(MyTexts.SorryButSelectedSettingsAreNotSupportedByYourHardware);
            MyTextsWrapper.m_sb[103] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysSpace);
            MyTextsWrapper.m_sb[104] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.StartGameInProgressPleaseWait);
            MyTextsWrapper.m_sb[105] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_StrafeLeft);
            MyTextsWrapper.m_sb[106] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_StrafeRight);
            MyTextsWrapper.m_sb[107] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlTypeSystems1);
            MyTextsWrapper.m_sb[108] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlTypeSystems2);
            MyTextsWrapper.m_sb[109] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysTab);
            MyTextsWrapper.m_sb[110] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TitleFailedToStartInternetBrowser);
            MyTextsWrapper.m_sb[111] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.UnknownControl_None);
            MyTextsWrapper.m_sb[112] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysUp);
            MyTextsWrapper.m_sb[113] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_UseOrInteract);
            MyTextsWrapper.m_sb[114] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.VerticalSync);
            MyTextsWrapper.m_sb[115] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenOptionsButtonVideo);
            MyTextsWrapper.m_sb[116] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.VideoMode);
            MyTextsWrapper.m_sb[117] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCaptionVideoOptions);
            MyTextsWrapper.m_sb[118] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlTypeToolsOrWeapons);
            MyTextsWrapper.m_sb[119] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Yes);
            MyTextsWrapper.m_sb[120] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Disabled);
            MyTextsWrapper.m_sb[121] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoystickRotationXpos);
            MyTextsWrapper.m_sb[122] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoystickRotationYpos);
            MyTextsWrapper.m_sb[123] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoystickRotationZpos);
            MyTextsWrapper.m_sb[124] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoystickSlider1pos);
            MyTextsWrapper.m_sb[125] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoystickSlider2pos);
            MyTextsWrapper.m_sb[126] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoystickRotationXneg);
            MyTextsWrapper.m_sb[(int) sbyte.MaxValue] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoystickRotationYneg);
            MyTextsWrapper.m_sb[128] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoystickRotationZneg);
            MyTextsWrapper.m_sb[129] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoystickSlider1neg);
            MyTextsWrapper.m_sb[130] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoystickSlider2neg);
            MyTextsWrapper.m_sb[131] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysDecimal);
            MyTextsWrapper.m_sb[132] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysBackslash);
            MyTextsWrapper.m_sb[133] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysComma);
            MyTextsWrapper.m_sb[134] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysMinus);
            MyTextsWrapper.m_sb[135] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysOpenBracket);
            MyTextsWrapper.m_sb[136] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysCloseBracket);
            MyTextsWrapper.m_sb[137] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysPeriod);
            MyTextsWrapper.m_sb[138] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysPipe);
            MyTextsWrapper.m_sb[139] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysPlus);
            MyTextsWrapper.m_sb[140] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysQuestion);
            MyTextsWrapper.m_sb[141] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysQuotes);
            MyTextsWrapper.m_sb[142] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysSemicolon);
            MyTextsWrapper.m_sb[143] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysTilde);
            MyTextsWrapper.m_sb[144] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysMultiply);
            MyTextsWrapper.m_sb[145] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysDivide);
            MyTextsWrapper.m_sb[146] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysAdd);
            MyTextsWrapper.m_sb[147] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysSubtract);
            MyTextsWrapper.m_sb[148] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysCapsLock);
            MyTextsWrapper.m_sb[149] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysEnter);
            MyTextsWrapper.m_sb[150] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysBackspace);
            MyTextsWrapper.m_sb[151] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ApplyingPleaseWait);
            MyTextsWrapper.m_sb[152] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MP_YouHaveBeenKilled);
            MyTextsWrapper.m_sb[153] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MusicVolume);
            MyTextsWrapper.m_sb[154] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.VideoAdapter);
            MyTextsWrapper.m_sb[155] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DefaultFOV);
            MyTextsWrapper.m_sb[156] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldLoaded);
            MyTextsWrapper.m_sb[157] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Chat_screen);
            MyTextsWrapper.m_sb[158] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_Screenshot);
            MyTextsWrapper.m_sb[159] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_PreviousColor);
            MyTextsWrapper.m_sb[160] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_NextColor);
            MyTextsWrapper.m_sb[161] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_TerminalOrInventory);
            MyTextsWrapper.m_sb[162] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_Welder);
            MyTextsWrapper.m_sb[163] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSaved);
            MyTextsWrapper.m_sb[164] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.AngleGrinderPrimaryAction);
            MyTextsWrapper.m_sb[165] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WelderPrimaryActionBuild);
            MyTextsWrapper.m_sb[166] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Blueprints);
            MyTextsWrapper.m_sb[167] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlPanel);
            MyTextsWrapper.m_sb[168] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Factions);
            MyTextsWrapper.m_sb[169] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Assembler);
            MyTextsWrapper.m_sb[170] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Refinery);
            MyTextsWrapper.m_sb[171] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenTerminalError_ShipNotConnected);
            MyTextsWrapper.m_sb[172] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_AngleGrinder);
            MyTextsWrapper.m_sb[173] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Antenna);
            MyTextsWrapper.m_sb[174] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_AutomaticRifle);
            MyTextsWrapper.m_sb[175] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HelpScreen_FactionColor_Blue);
            MyTextsWrapper.m_sb[176] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_BulletproofGlass);
            MyTextsWrapper.m_sb[177] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_CobaltIngot);
            MyTextsWrapper.m_sb[178] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_CobaltOre);
            MyTextsWrapper.m_sb[179] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Cockpit1);
            MyTextsWrapper.m_sb[180] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_Computer);
            MyTextsWrapper.m_sb[181] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_ConstructionComponent);
            MyTextsWrapper.m_sb[182] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_DetectorComponents);
            MyTextsWrapper.m_sb[183] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_DiagonalWindow);
            MyTextsWrapper.m_sb[184] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_Display);
            MyTextsWrapper.m_sb[185] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Door);
            MyTextsWrapper.m_sb[186] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Warhead);
            MyTextsWrapper.m_sb[187] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_ReflectorLight);
            MyTextsWrapper.m_sb[188] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_FullCoverWall);
            MyTextsWrapper.m_sb[189] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_GatlingGun);
            MyTextsWrapper.m_sb[190] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_GatlingTurret);
            MyTextsWrapper.m_sb[191] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_GoldIngot);
            MyTextsWrapper.m_sb[192] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_GoldOre);
            MyTextsWrapper.m_sb[193] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_Gravel);
            MyTextsWrapper.m_sb[194] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_GravityGenerator);
            MyTextsWrapper.m_sb[195] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_GravityGeneratorComponents);
            MyTextsWrapper.m_sb[196] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HelpScreen_FactionColor_Green);
            MyTextsWrapper.m_sb[197] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Gyroscope);
            MyTextsWrapper.m_sb[198] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_HalfCoverWall);
            MyTextsWrapper.m_sb[199] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_HandDrill);
            MyTextsWrapper.m_sb[200] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_HeavyArmorBlock);
            MyTextsWrapper.m_sb[201] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_HeavyArmorCorner);
            MyTextsWrapper.m_sb[202] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_HeavyArmorInvCorner);
            MyTextsWrapper.m_sb[203] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_HeavyArmorSlope);
            MyTextsWrapper.m_sb[204] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_Ice);
            MyTextsWrapper.m_sb[205] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_InteriorLight);
            MyTextsWrapper.m_sb[206] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_InteriorPillar);
            MyTextsWrapper.m_sb[207] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_InteriorPlate);
            MyTextsWrapper.m_sb[208] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_InteriorTurret);
            MyTextsWrapper.m_sb[209] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_InteriorWall);
            MyTextsWrapper.m_sb[210] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_IronIngot);
            MyTextsWrapper.m_sb[211] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_IronOre);
            MyTextsWrapper.m_sb[212] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_LandingGear);
            MyTextsWrapper.m_sb[213] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_LargeCargoContainer);
            MyTextsWrapper.m_sb[214] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_LargeReactor);
            MyTextsWrapper.m_sb[215] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_LargeSteelTube);
            MyTextsWrapper.m_sb[216] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_LargeThrust);
            MyTextsWrapper.m_sb[217] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_LightArmorBlock);
            MyTextsWrapper.m_sb[218] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_LightArmorCorner);
            MyTextsWrapper.m_sb[219] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_LightArmorInvCorner);
            MyTextsWrapper.m_sb[220] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_LightArmorSlope);
            MyTextsWrapper.m_sb[221] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_MagnesiumOre);
            MyTextsWrapper.m_sb[222] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_MagnesiumPowder);
            MyTextsWrapper.m_sb[223] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_MedicalComponents);
            MyTextsWrapper.m_sb[224] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_MedicalRoom);
            MyTextsWrapper.m_sb[225] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_MediumCargoContainer);
            MyTextsWrapper.m_sb[226] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_MetalGrid);
            MyTextsWrapper.m_sb[227] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_Missile200mm);
            MyTextsWrapper.m_sb[228] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_MissileTurret);
            MyTextsWrapper.m_sb[229] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_Motor);
            MyTextsWrapper.m_sb[230] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_NATO_25x184mm);
            MyTextsWrapper.m_sb[231] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_NATO_5p56x45mm);
            MyTextsWrapper.m_sb[232] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_NickelIngot);
            MyTextsWrapper.m_sb[233] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_NickelOre);
            MyTextsWrapper.m_sb[234] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_OreDetector);
            MyTextsWrapper.m_sb[235] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_PlatinumIngot);
            MyTextsWrapper.m_sb[236] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_PlatinumOre);
            MyTextsWrapper.m_sb[237] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_Potassium);
            MyTextsWrapper.m_sb[238] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_RadioCommunicationComponents);
            MyTextsWrapper.m_sb[239] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Ramp);
            MyTextsWrapper.m_sb[240] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_ReactorComponents);
            MyTextsWrapper.m_sb[241] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HelpScreen_FactionColor_Red);
            MyTextsWrapper.m_sb[242] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_RocketLauncher);
            MyTextsWrapper.m_sb[243] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_SiliconOre);
            MyTextsWrapper.m_sb[244] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_SiliconWafer);
            MyTextsWrapper.m_sb[245] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_SilverIngot);
            MyTextsWrapper.m_sb[246] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_SilverOre);
            MyTextsWrapper.m_sb[247] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_SmallCargoContainer);
            MyTextsWrapper.m_sb[248] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_SmallReactor);
            MyTextsWrapper.m_sb[249] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_SmallSteelTube);
            MyTextsWrapper.m_sb[250] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_SmallThrust);
            MyTextsWrapper.m_sb[251] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Stairs);
            MyTextsWrapper.m_sb[252] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_SteelCatwalk);
            MyTextsWrapper.m_sb[253] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_SteelPlate);
            MyTextsWrapper.m_sb[254] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_StoneOre);
            MyTextsWrapper.m_sb[(int) byte.MaxValue] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_ThrustComponents);
            MyTextsWrapper.m_sb[256] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_UraniumIngot);
            MyTextsWrapper.m_sb[257] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_UraniumOre);
            MyTextsWrapper.m_sb[258] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_VerticalWindow);
            MyTextsWrapper.m_sb[259] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HelpScreen_FactionColor_White);
            MyTextsWrapper.m_sb[260] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlueprintMaterials);
            MyTextsWrapper.m_sb[261] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProductionQueue);
            MyTextsWrapper.m_sb[262] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Reactor);
            MyTextsWrapper.m_sb[263] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.LoadScreenButtonEditSettings);
            MyTextsWrapper.m_sb[264] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_AutoHealing);
            MyTextsWrapper.m_sb[265] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCaptionCustomWorld);
            MyTextsWrapper.m_sb[266] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_Description);
            MyTextsWrapper.m_sb[267] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_EnvironmentHostility);
            MyTextsWrapper.m_sb[268] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_EnvironmentHostilityCataclysm);
            MyTextsWrapper.m_sb[269] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_EnvironmentHostilityNormal);
            MyTextsWrapper.m_sb[270] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_EnvironmentHostilitySafe);
            MyTextsWrapper.m_sb[271] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ErrorNameTooLong);
            MyTextsWrapper.m_sb[272] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ErrorNameTooShort);
            MyTextsWrapper.m_sb[273] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_FriendlyFire);
            MyTextsWrapper.m_sb[274] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_GameStyle);
            MyTextsWrapper.m_sb[275] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_GameMode);
            MyTextsWrapper.m_sb[276] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_GameModeSurvival);
            MyTextsWrapper.m_sb[277] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_GameSurvivalTimes10);
            MyTextsWrapper.m_sb[278] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMenuButtonJoinWorld);
            MyTextsWrapper.m_sb[279] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Name);
            MyTextsWrapper.m_sb[280] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_OnlineMode);
            MyTextsWrapper.m_sb[281] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_OnlineModeOffline);
            MyTextsWrapper.m_sb[282] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_OnlineModePrivate);
            MyTextsWrapper.m_sb[283] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_OnlineModePublic);
            MyTextsWrapper.m_sb[284] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_Password);
            MyTextsWrapper.m_sb[285] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenNewWorldButtonQuickstart);
            MyTextsWrapper.m_sb[286] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_SoundInSpace);
            MyTextsWrapper.m_sb[287] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings);
            MyTextsWrapper.m_sb[288] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsAutoHealing);
            MyTextsWrapper.m_sb[289] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsDifficulty);
            MyTextsWrapper.m_sb[290] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsEnvironment);
            MyTextsWrapper.m_sb[291] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsFriendlyFire);
            MyTextsWrapper.m_sb[292] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsHardwareRequirements);
            MyTextsWrapper.m_sb[293] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsHarvestingMode);
            MyTextsWrapper.m_sb[294] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsName);
            MyTextsWrapper.m_sb[295] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsOnlineMode);
            MyTextsWrapper.m_sb[296] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsPVP);
            MyTextsWrapper.m_sb[297] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsSoundInSpace);
            MyTextsWrapper.m_sb[298] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextAreYouSureYouWantToDeleteSave);
            MyTextsWrapper.m_sb[299] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCaptionLoadWorld);
            MyTextsWrapper.m_sb[300] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.LoadScreenButtonSaveAs);
            MyTextsWrapper.m_sb[301] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_GameModeCreative);
            MyTextsWrapper.m_sb[302] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_Scenario);
            MyTextsWrapper.m_sb[303] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Scenario_EasyStart1);
            MyTextsWrapper.m_sb[304] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Scenario_Survival);
            MyTextsWrapper.m_sb[305] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.PlayerCharacter);
            MyTextsWrapper.m_sb[306] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_AutoSave);
            MyTextsWrapper.m_sb[307] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsAutoSave);
            MyTextsWrapper.m_sb[308] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextDoYouWantToSaveYourProgress);
            MyTextsWrapper.m_sb[309] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SaveWorld);
            MyTextsWrapper.m_sb[310] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMenuButtonSave);
            MyTextsWrapper.m_sb[311] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SavingPleaseWait);
            MyTextsWrapper.m_sb[312] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Advanced);
            MyTextsWrapper.m_sb[313] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.AdvancedControls);
            MyTextsWrapper.m_sb[314] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_Backward);
            MyTextsWrapper.m_sb[315] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BasicControls);
            MyTextsWrapper.m_sb[316] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Close);
            MyTextsWrapper.m_sb[317] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_DownOrCrouch);
            MyTextsWrapper.m_sb[318] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_FirstOrThirdPerson);
            MyTextsWrapper.m_sb[319] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_Forward);
            MyTextsWrapper.m_sb[320] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NextPage);
            MyTextsWrapper.m_sb[321] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationNeedShowHelpScreen);
            MyTextsWrapper.m_sb[322] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.PreviousPage);
            MyTextsWrapper.m_sb[323] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ShowControlsHints);
            MyTextsWrapper.m_sb[324] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SteamGuide);
            MyTextsWrapper.m_sb[325] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_UpOrJump);
            MyTextsWrapper.m_sb[326] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_CubeRotateVerticalNeg);
            MyTextsWrapper.m_sb[327] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_CubeRotateVerticalPos);
            MyTextsWrapper.m_sb[328] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_CubeRotateHorizontalNeg);
            MyTextsWrapper.m_sb[329] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_CubeRotateHorizontalPos);
            MyTextsWrapper.m_sb[330] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_CubeRotateRollNeg);
            MyTextsWrapper.m_sb[331] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_CubeRotateRollPos);
            MyTextsWrapper.m_sb[332] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_Slot0);
            MyTextsWrapper.m_sb[333] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_Slot1);
            MyTextsWrapper.m_sb[334] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_Slot2);
            MyTextsWrapper.m_sb[335] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_Slot3);
            MyTextsWrapper.m_sb[336] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_Slot4);
            MyTextsWrapper.m_sb[337] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_Slot5);
            MyTextsWrapper.m_sb[338] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_Slot6);
            MyTextsWrapper.m_sb[339] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_Slot7);
            MyTextsWrapper.m_sb[340] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_Slot8);
            MyTextsWrapper.m_sb[341] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_Slot9);
            MyTextsWrapper.m_sb[342] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_ReactorsOnOff);
            MyTextsWrapper.m_sb[343] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Scenario_EmptyWorld);
            MyTextsWrapper.m_sb[344] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextAreYouSureYouWantToQuickLoad);
            MyTextsWrapper.m_sb[345] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextAreYouSureYouWantToQuickSave);
            MyTextsWrapper.m_sb[346] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_ToolbarConfig);
            MyTextsWrapper.m_sb[347] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_HoldToLookAround);
            MyTextsWrapper.m_sb[348] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_HoldToSprint);
            MyTextsWrapper.m_sb[349] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_Jetpack);
            MyTextsWrapper.m_sb[350] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.LoadingPleaseWait);
            MyTextsWrapper.m_sb[351] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NoPlaceToCreateGrid);
            MyTextsWrapper.m_sb[352] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotEnoughMaterial);
            MyTextsWrapper.m_sb[353] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Turret);
            MyTextsWrapper.m_sb[354] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Conveyor);
            MyTextsWrapper.m_sb[355] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_HudOnOff);
            MyTextsWrapper.m_sb[356] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCubeBuilderHint);
            MyTextsWrapper.m_sb[357] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Saved);
            MyTextsWrapper.m_sb[358] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HideWeapon);
            MyTextsWrapper.m_sb[359] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Thrust);
            MyTextsWrapper.m_sb[360] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SomeWorldFilesCouldNotBeLoaded);
            MyTextsWrapper.m_sb[361] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldFileIsCorruptedAndCouldNotBeLoaded);
            MyTextsWrapper.m_sb[362] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Terminal);
            MyTextsWrapper.m_sb[363] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote00Author);
            MyTextsWrapper.m_sb[364] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote00Text);
            MyTextsWrapper.m_sb[365] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote01Author);
            MyTextsWrapper.m_sb[366] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote01Text);
            MyTextsWrapper.m_sb[367] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote02Author);
            MyTextsWrapper.m_sb[368] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote02Text);
            MyTextsWrapper.m_sb[369] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote03Author);
            MyTextsWrapper.m_sb[370] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote03Text);
            MyTextsWrapper.m_sb[371] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote04Author);
            MyTextsWrapper.m_sb[372] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote04Text);
            MyTextsWrapper.m_sb[373] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote05Author);
            MyTextsWrapper.m_sb[374] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote05Text);
            MyTextsWrapper.m_sb[375] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote06Author);
            MyTextsWrapper.m_sb[376] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote06Text);
            MyTextsWrapper.m_sb[377] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote07Author);
            MyTextsWrapper.m_sb[378] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote07Text);
            MyTextsWrapper.m_sb[379] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote08Author);
            MyTextsWrapper.m_sb[380] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote08Text);
            MyTextsWrapper.m_sb[381] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote09Author);
            MyTextsWrapper.m_sb[382] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote09Text);
            MyTextsWrapper.m_sb[383] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote10Author);
            MyTextsWrapper.m_sb[384] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote10Text);
            MyTextsWrapper.m_sb[385] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote11Author);
            MyTextsWrapper.m_sb[386] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote11Text);
            MyTextsWrapper.m_sb[387] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote12Author);
            MyTextsWrapper.m_sb[388] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote12Text);
            MyTextsWrapper.m_sb[389] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote13Author);
            MyTextsWrapper.m_sb[390] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote13Text);
            MyTextsWrapper.m_sb[391] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote14Author);
            MyTextsWrapper.m_sb[392] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote14Text);
            MyTextsWrapper.m_sb[393] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote15Author);
            MyTextsWrapper.m_sb[394] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote15Text);
            MyTextsWrapper.m_sb[395] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote16Author);
            MyTextsWrapper.m_sb[396] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote16Text);
            MyTextsWrapper.m_sb[397] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote17Author);
            MyTextsWrapper.m_sb[398] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote17Text);
            MyTextsWrapper.m_sb[399] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote18Author);
            MyTextsWrapper.m_sb[400] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote18Text);
            MyTextsWrapper.m_sb[401] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote19Author);
            MyTextsWrapper.m_sb[402] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote19Text);
            MyTextsWrapper.m_sb[403] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote20Author);
            MyTextsWrapper.m_sb[404] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote20Text);
            MyTextsWrapper.m_sb[405] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote21Author);
            MyTextsWrapper.m_sb[406] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote21Text);
            MyTextsWrapper.m_sb[407] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote22Author);
            MyTextsWrapper.m_sb[408] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote22Text);
            MyTextsWrapper.m_sb[409] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote23Author);
            MyTextsWrapper.m_sb[410] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote23Text);
            MyTextsWrapper.m_sb[411] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote24Author);
            MyTextsWrapper.m_sb[412] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote24Text);
            MyTextsWrapper.m_sb[413] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote25Author);
            MyTextsWrapper.m_sb[414] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote25Text);
            MyTextsWrapper.m_sb[415] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote26Author);
            MyTextsWrapper.m_sb[416] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote26Text);
            MyTextsWrapper.m_sb[417] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote27Author);
            MyTextsWrapper.m_sb[418] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote27Text);
            MyTextsWrapper.m_sb[419] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote28Author);
            MyTextsWrapper.m_sb[420] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote28Text);
            MyTextsWrapper.m_sb[421] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote29Author);
            MyTextsWrapper.m_sb[422] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote29Text);
            MyTextsWrapper.m_sb[423] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote30Author);
            MyTextsWrapper.m_sb[424] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote30Text);
            MyTextsWrapper.m_sb[425] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote31Author);
            MyTextsWrapper.m_sb[426] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote31Text);
            MyTextsWrapper.m_sb[427] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote32Author);
            MyTextsWrapper.m_sb[428] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote32Text);
            MyTextsWrapper.m_sb[429] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote33Author);
            MyTextsWrapper.m_sb[430] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote33Text);
            MyTextsWrapper.m_sb[431] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote34Author);
            MyTextsWrapper.m_sb[432] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote34Text);
            MyTextsWrapper.m_sb[433] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote35Author);
            MyTextsWrapper.m_sb[434] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote35Text);
            MyTextsWrapper.m_sb[435] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote36Author);
            MyTextsWrapper.m_sb[436] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote36Text);
            MyTextsWrapper.m_sb[437] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote37Author);
            MyTextsWrapper.m_sb[438] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote37Text);
            MyTextsWrapper.m_sb[439] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote38Author);
            MyTextsWrapper.m_sb[440] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote38Text);
            MyTextsWrapper.m_sb[441] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote39Author);
            MyTextsWrapper.m_sb[442] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote39Text);
            MyTextsWrapper.m_sb[443] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote40Author);
            MyTextsWrapper.m_sb[444] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote40Text);
            MyTextsWrapper.m_sb[445] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote41Author);
            MyTextsWrapper.m_sb[446] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote41Text);
            MyTextsWrapper.m_sb[447] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote42Author);
            MyTextsWrapper.m_sb[448] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote42Text);
            MyTextsWrapper.m_sb[449] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote43Author);
            MyTextsWrapper.m_sb[450] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote43Text);
            MyTextsWrapper.m_sb[451] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote44Author);
            MyTextsWrapper.m_sb[452] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote44Text);
            MyTextsWrapper.m_sb[453] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote45Author);
            MyTextsWrapper.m_sb[454] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote45Text);
            MyTextsWrapper.m_sb[455] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote46Author);
            MyTextsWrapper.m_sb[456] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote46Text);
            MyTextsWrapper.m_sb[457] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote47Author);
            MyTextsWrapper.m_sb[458] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote47Text);
            MyTextsWrapper.m_sb[459] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote48Author);
            MyTextsWrapper.m_sb[460] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote48Text);
            MyTextsWrapper.m_sb[461] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote49Author);
            MyTextsWrapper.m_sb[462] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote49Text);
            MyTextsWrapper.m_sb[463] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote50Author);
            MyTextsWrapper.m_sb[464] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote50Text);
            MyTextsWrapper.m_sb[465] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote51Author);
            MyTextsWrapper.m_sb[466] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote51Text);
            MyTextsWrapper.m_sb[467] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote52Author);
            MyTextsWrapper.m_sb[468] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote52Text);
            MyTextsWrapper.m_sb[469] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote53Author);
            MyTextsWrapper.m_sb[470] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote53Text);
            MyTextsWrapper.m_sb[471] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote54Author);
            MyTextsWrapper.m_sb[472] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote54Text);
            MyTextsWrapper.m_sb[473] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote55Author);
            MyTextsWrapper.m_sb[474] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote55Text);
            MyTextsWrapper.m_sb[475] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote56Author);
            MyTextsWrapper.m_sb[476] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote56Text);
            MyTextsWrapper.m_sb[477] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote57Author);
            MyTextsWrapper.m_sb[478] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote57Text);
            MyTextsWrapper.m_sb[479] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote58Author);
            MyTextsWrapper.m_sb[480] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote58Text);
            MyTextsWrapper.m_sb[481] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote59Author);
            MyTextsWrapper.m_sb[482] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote59Text);
            MyTextsWrapper.m_sb[483] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote60Author);
            MyTextsWrapper.m_sb[484] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote60Text);
            MyTextsWrapper.m_sb[485] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote61Author);
            MyTextsWrapper.m_sb[486] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote61Text);
            MyTextsWrapper.m_sb[487] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote62Author);
            MyTextsWrapper.m_sb[488] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote62Text);
            MyTextsWrapper.m_sb[489] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote63Author);
            MyTextsWrapper.m_sb[490] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote63Text);
            MyTextsWrapper.m_sb[491] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote64Author);
            MyTextsWrapper.m_sb[492] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote64Text);
            MyTextsWrapper.m_sb[493] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote65Author);
            MyTextsWrapper.m_sb[494] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote65Text);
            MyTextsWrapper.m_sb[495] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote66Author);
            MyTextsWrapper.m_sb[496] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote66Text);
            MyTextsWrapper.m_sb[497] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote67Author);
            MyTextsWrapper.m_sb[498] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote67Text);
            MyTextsWrapper.m_sb[499] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote68Author);
            MyTextsWrapper.m_sb[500] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote68Text);
            MyTextsWrapper.m_sb[501] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote69Author);
            MyTextsWrapper.m_sb[502] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote69Text);
            MyTextsWrapper.m_sb[503] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoGravity);
            MyTextsWrapper.m_sb[504] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoNoGravity);
            MyTextsWrapper.m_sb[505] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipNewWorldCustomWorld);
            MyTextsWrapper.m_sb[506] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipNewWorldQuickstart);
            MyTextsWrapper.m_sb[507] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipVideoOptionsRenderQuality);
            MyTextsWrapper.m_sb[508] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipVideoOptionsVideoAdapter);
            MyTextsWrapper.m_sb[509] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipVideoOptionsVideoMode);
            MyTextsWrapper.m_sb[510] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipVideoOptionsHardwareCursor);
            MyTextsWrapper.m_sb[511] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipVideoOptionsVerticalSync);
            MyTextsWrapper.m_sb[512] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipVideoOptionsFieldOfView);
            MyTextsWrapper.m_sb[513] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipGameOptionsShowControlsHints);
            MyTextsWrapper.m_sb[514] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldNotSaved);
            MyTextsWrapper.m_sb[515] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationMemoryOverload);
            MyTextsWrapper.m_sb[516] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BetterGCIsAvailable);
            MyTextsWrapper.m_sb[517] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxCaptionWarning);
            MyTextsWrapper.m_sb[518] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SpaceEngineersWeb);
            MyTextsWrapper.m_sb[519] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextOpenBrowser);
            MyTextsWrapper.m_sb[520] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoCrouching);
            MyTextsWrapper.m_sb[521] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoFlying);
            MyTextsWrapper.m_sb[522] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoOff);
            MyTextsWrapper.m_sb[523] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoOn);
            MyTextsWrapper.m_sb[524] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudEnergyMissingTotal);
            MyTextsWrapper.m_sb[525] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoNameEnergy);
            MyTextsWrapper.m_sb[526] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoNameFuelTime);
            MyTextsWrapper.m_sb[527] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoNameGyroscopes);
            MyTextsWrapper.m_sb[528] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoNameLights);
            MyTextsWrapper.m_sb[529] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoNameMass);
            MyTextsWrapper.m_sb[530] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoNamePowerUsage);
            MyTextsWrapper.m_sb[531] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoNameReactors);
            MyTextsWrapper.m_sb[532] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoNameSpeed);
            MyTextsWrapper.m_sb[533] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoNameThrusts);
            MyTextsWrapper.m_sb[534] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoNoPower);
            MyTextsWrapper.m_sb[535] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoNoReflectors);
            MyTextsWrapper.m_sb[536] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoPilotingLargeShip);
            MyTextsWrapper.m_sb[537] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoPilotingSmallShip);
            MyTextsWrapper.m_sb[538] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoPowerOverload);
            MyTextsWrapper.m_sb[539] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoReflectorsOff);
            MyTextsWrapper.m_sb[540] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoReflectorsOn);
            MyTextsWrapper.m_sb[541] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoStanding);
            MyTextsWrapper.m_sb[542] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Scenario_EasyStart2);
            MyTextsWrapper.m_sb[543] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextTutorialQuestion);
            MyTextsWrapper.m_sb[544] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Loaded);
            MyTextsWrapper.m_sb[545] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextNoSavedWorlds);
            MyTextsWrapper.m_sb[546] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxCaptionVideoTutorial);
            MyTextsWrapper.m_sb[547] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextSaveChangesBeforeExit);
            MyTextsWrapper.m_sb[548] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ErrorNameAlreadyExists);
            MyTextsWrapper.m_sb[549] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationBuildingFormat);
            MyTextsWrapper.m_sb[550] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationColorFormat);
            MyTextsWrapper.m_sb[551] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHideHintsInGameOptions);
            MyTextsWrapper.m_sb[552] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHudHideFormat);
            MyTextsWrapper.m_sb[553] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationRotationFormat);
            MyTextsWrapper.m_sb[554] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationScreenFormat);
            MyTextsWrapper.m_sb[555] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationSlotEquipFormat);
            MyTextsWrapper.m_sb[556] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationToolDisabled);
            MyTextsWrapper.m_sb[557] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationUnlimitedBuildingFormat);
            MyTextsWrapper.m_sb[558] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlDescHoldToColor);
            MyTextsWrapper.m_sb[559] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlDescLargeBrush);
            MyTextsWrapper.m_sb[560] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlDescMediumBrush);
            MyTextsWrapper.m_sb[561] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlDescQuickLoad);
            MyTextsWrapper.m_sb[562] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlDescQuickSave);
            MyTextsWrapper.m_sb[563] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlDescZoom);
            MyTextsWrapper.m_sb[564] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MouseWheel);
            MyTextsWrapper.m_sb[565] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCubeBuilderBuildingBlocks);
            MyTextsWrapper.m_sb[566] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCubeBuilderCreativeMode);
            MyTextsWrapper.m_sb[567] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCubeBuilderNewLargeShip);
            MyTextsWrapper.m_sb[568] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCubeBuilderNewSmallShip);
            MyTextsWrapper.m_sb[569] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCubeBuilderNewStation);
            MyTextsWrapper.m_sb[570] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCubeBuilderSubtitle);
            MyTextsWrapper.m_sb[571] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCubeBuilderToolbar);
            MyTextsWrapper.m_sb[572] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCubeBuilderToolbarConfig);
            MyTextsWrapper.m_sb[573] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCubeBuilderToolsWeapons);
            MyTextsWrapper.m_sb[574] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudEnergyGroupCharging);
            MyTextsWrapper.m_sb[575] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudEnergyGroupConveyors);
            MyTextsWrapper.m_sb[576] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudEnergyGroupDefense);
            MyTextsWrapper.m_sb[577] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudEnergyGroupDoors);
            MyTextsWrapper.m_sb[578] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudEnergyGroupFactory);
            MyTextsWrapper.m_sb[579] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudEnergyGroupGyroscope);
            MyTextsWrapper.m_sb[580] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudEnergyGroupThrust);
            MyTextsWrapper.m_sb[581] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudEnergyGroupUtility);
            MyTextsWrapper.m_sb[582] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SteamOverlayDisabledCaption);
            MyTextsWrapper.m_sb[583] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SteamOverlayDisabledText);
            MyTextsWrapper.m_sb[584] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.LoadScreenButtonPublish);
            MyTextsWrapper.m_sb[585] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextWorldPublished);
            MyTextsWrapper.m_sb[586] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextWorldPublishFailed);
            MyTextsWrapper.m_sb[587] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextModPublished);
            MyTextsWrapper.m_sb[588] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextModPublishFailed);
            MyTextsWrapper.m_sb[589] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgressTextPublishingWorld);
            MyTextsWrapper.m_sb[590] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgressTextUploadingWorld);
            MyTextsWrapper.m_sb[591] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMenuButtonSubscribedWorlds);
            MyTextsWrapper.m_sb[592] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgressTextCreatingWorld);
            MyTextsWrapper.m_sb[593] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCaptionWorkshop);
            MyTextsWrapper.m_sb[594] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMenuButtonRecommend);
            MyTextsWrapper.m_sb[595] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextRecommend);
            MyTextsWrapper.m_sb[596] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxCaptionRecommend);
            MyTextsWrapper.m_sb[597] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxCaptionWorldPublished);
            MyTextsWrapper.m_sb[598] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxCaptionWorldPublishFailed);
            MyTextsWrapper.m_sb[599] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxCaptionModPublished);
            MyTextsWrapper.m_sb[600] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxCaptionModPublishFailed);
            MyTextsWrapper.m_sb[601] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenLoadSubscribedWorldCopyAndLoad);
            MyTextsWrapper.m_sb[602] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.LoadScreenButtonTooltipPublish);
            MyTextsWrapper.m_sb[603] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipMenuSubscribedWorlds);
            MyTextsWrapper.m_sb[604] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxCaptionDoYouWishToPublishWorld);
            MyTextsWrapper.m_sb[605] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxCaptionDoYouWishToUpdateWorld);
            MyTextsWrapper.m_sb[606] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextDoYouWishToPublishWorld);
            MyTextsWrapper.m_sb[607] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextDoYouWishToUpdateWorld);
            MyTextsWrapper.m_sb[608] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxCaptionDoYouWishToPublishMod);
            MyTextsWrapper.m_sb[609] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxCaptionDoYouWishToUpdateMod);
            MyTextsWrapper.m_sb[610] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextDoYouWishToPublishMod);
            MyTextsWrapper.m_sb[611] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextDoYouWishToUpdateMod);
            MyTextsWrapper.m_sb[612] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHintLeaveCockpit);
            MyTextsWrapper.m_sb[613] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHintOpenShipControlPanel);
            MyTextsWrapper.m_sb[614] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHintTurnAllReactorsOff);
            MyTextsWrapper.m_sb[615] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHintTurnAllReactorsOn);
            MyTextsWrapper.m_sb[616] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationArgLargeShip);
            MyTextsWrapper.m_sb[617] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationArgSmallShip);
            MyTextsWrapper.m_sb[618] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationArgStation);
            MyTextsWrapper.m_sb[619] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationBlockNotAvailableFor);
            MyTextsWrapper.m_sb[620] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenLoadSubscribedWorldBrowseWorkshop);
            MyTextsWrapper.m_sb[621] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenLoadSubscribedWorldRefresh);
            MyTextsWrapper.m_sb[622] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationArgAngleGrinder);
            MyTextsWrapper.m_sb[623] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationArgDrill);
            MyTextsWrapper.m_sb[624] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationArgMissile);
            MyTextsWrapper.m_sb[625] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationArgProjectile);
            MyTextsWrapper.m_sb[626] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationArgWelder);
            MyTextsWrapper.m_sb[627] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationNoWeaponSelected);
            MyTextsWrapper.m_sb[628] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationSwitchedToWeaponType);
            MyTextsWrapper.m_sb[629] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHintPressToClimbUpDown);
            MyTextsWrapper.m_sb[630] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHintPressToGetDownFromLadder);
            MyTextsWrapper.m_sb[631] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHintPressToJumpOffLadder);
            MyTextsWrapper.m_sb[632] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationJetpackOff);
            MyTextsWrapper.m_sb[633] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationJetpackOffNoEnergy);
            MyTextsWrapper.m_sb[634] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationJetpackOn);
            MyTextsWrapper.m_sb[635] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationUsingWeaponType);
            MyTextsWrapper.m_sb[636] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoControllingStation);
            MyTextsWrapper.m_sb[637] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoNameDampeners);
            MyTextsWrapper.m_sb[638] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationInertiaDampenersOff);
            MyTextsWrapper.m_sb[639] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationInertiaDampenersOn);
            MyTextsWrapper.m_sb[640] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.LoadScreenButtonDelete);
            MyTextsWrapper.m_sb[641] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCaptionEditSettings);
            MyTextsWrapper.m_sb[642] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCaptionSaveAs);
            MyTextsWrapper.m_sb[643] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMenuButtonHelp);
            MyTextsWrapper.m_sb[644] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMenuButtonLoadWorld);
            MyTextsWrapper.m_sb[645] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMenuButtonNewWorld);
            MyTextsWrapper.m_sb[646] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMenuButtonOptions);
            MyTextsWrapper.m_sb[647] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenNewWorldButtonCustomWorld);
            MyTextsWrapper.m_sb[648] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenOptionsButtonControls);
            MyTextsWrapper.m_sb[649] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoNameLandingGear);
            MyTextsWrapper.m_sb[650] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoNameInProximity);
            MyTextsWrapper.m_sb[651] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoNameLocked);
            MyTextsWrapper.m_sb[652] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxCaptionResetControlsToDefault);
            MyTextsWrapper.m_sb[653] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextResetControlsToDefault);
            MyTextsWrapper.m_sb[654] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenshotFailed);
            MyTextsWrapper.m_sb[655] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenshotSaved);
            MyTextsWrapper.m_sb[656] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ExportToObjComplete);
            MyTextsWrapper.m_sb[657] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ExportToObjFailed);
            MyTextsWrapper.m_sb[658] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenLoadSubscribedWorldOpenInWorkshop);
            MyTextsWrapper.m_sb[659] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorkshopBrowseWorkshop);
            MyTextsWrapper.m_sb[660] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorkshopCopyAndLoad);
            MyTextsWrapper.m_sb[661] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorkshopOpenInWorkshop);
            MyTextsWrapper.m_sb[662] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorkshopRefresh);
            MyTextsWrapper.m_sb[663] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_LandingGear);
            MyTextsWrapper.m_sb[664] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_SymmetrySwitch);
            MyTextsWrapper.m_sb[665] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHintPressToEnterCockpit);
            MyTextsWrapper.m_sb[666] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHintPressToOpenControlPanel);
            MyTextsWrapper.m_sb[667] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHintPressToOpenInventory);
            MyTextsWrapper.m_sb[668] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipTerminalInventory_FilterAll);
            MyTextsWrapper.m_sb[669] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipTerminalInventory_FilterEnergy);
            MyTextsWrapper.m_sb[670] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipTerminalInventory_FilterStorage);
            MyTextsWrapper.m_sb[671] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipTerminalInventory_FilterSystem);
            MyTextsWrapper.m_sb[672] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipTerminalInventory_ShowCharacter);
            MyTextsWrapper.m_sb[673] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipTerminalInventory_ShowConnected);
            MyTextsWrapper.m_sb[674] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenTerminalInventory_Mass);
            MyTextsWrapper.m_sb[675] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenTerminalInventory_Volume);
            MyTextsWrapper.m_sb[676] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipTerminalInventory_ItemInfo);
            MyTextsWrapper.m_sb[677] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SettingSymmetryX);
            MyTextsWrapper.m_sb[678] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SettingSymmetryXOffset);
            MyTextsWrapper.m_sb[679] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SettingSymmetryY);
            MyTextsWrapper.m_sb[680] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SettingSymmetryYOffset);
            MyTextsWrapper.m_sb[681] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SettingSymmetryZ);
            MyTextsWrapper.m_sb[682] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SettingSymmetryZOffset);
            MyTextsWrapper.m_sb[683] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_InertialDampeners);
            MyTextsWrapper.m_sb[684] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationPickupObject);
            MyTextsWrapper.m_sb[685] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_UseSymmetry);
            MyTextsWrapper.m_sb[686] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Beacon);
            MyTextsWrapper.m_sb[687] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.CubeBuilderPasteNotification);
            MyTextsWrapper.m_sb[688] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextErrorLoadingEntities);
            MyTextsWrapper.m_sb[689] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextAreYouSureToMoveGridToClipboard);
            MyTextsWrapper.m_sb[690] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextMemoryLimitReachedDuringLoad);
            MyTextsWrapper.m_sb[691] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenOptionsControls_Keyboard2);
            MyTextsWrapper.m_sb[692] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DialogTextDownloadingWorld);
            MyTextsWrapper.m_sb[693] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DialogTextDownloadWorldFailed);
            MyTextsWrapper.m_sb[694] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DialogTextJoiningWorld);
            MyTextsWrapper.m_sb[695] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DialogTextJoinWorldFailed);
            MyTextsWrapper.m_sb[696] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.GpuUnderMinimumNotification);
            MyTextsWrapper.m_sb[697] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipItemFilter_AnyOre);
            MyTextsWrapper.m_sb[698] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipItemFilter_UraniumIngot);
            MyTextsWrapper.m_sb[699] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ShowRotationHints);
            MyTextsWrapper.m_sb[700] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipGameOptionsShowRotationHints);
            MyTextsWrapper.m_sb[701] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Rotor);
            MyTextsWrapper.m_sb[702] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.UnknownControl_Unassigned);
            MyTextsWrapper.m_sb[703] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenOptionsGame_BuildingMode);
            MyTextsWrapper.m_sb[704] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenOptionsGame_Line);
            MyTextsWrapper.m_sb[705] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenOptionsGame_Plane);
            MyTextsWrapper.m_sb[706] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenOptionsGame_SingleBlock);
            MyTextsWrapper.m_sb[707] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_MotorTorque);
            MyTextsWrapper.m_sb[708] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_MotorBrakingTorque);
            MyTextsWrapper.m_sb[709] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_MotorTargetVelocity);
            MyTextsWrapper.m_sb[710] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipItemFilter_AnyIngot);
            MyTextsWrapper.m_sb[711] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_MotorMaxAngle);
            MyTextsWrapper.m_sb[712] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_MotorMinAngle);
            MyTextsWrapper.m_sb[713] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.IconSymbol_Ag);
            MyTextsWrapper.m_sb[714] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.IconSymbol_Au);
            MyTextsWrapper.m_sb[715] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.IconSymbol_Co);
            MyTextsWrapper.m_sb[716] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.IconSymbol_Fe);
            MyTextsWrapper.m_sb[717] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.IconSymbol_Gravel);
            MyTextsWrapper.m_sb[718] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.IconSymbol_Ice);
            MyTextsWrapper.m_sb[719] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.IconSymbol_K);
            MyTextsWrapper.m_sb[720] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.IconSymbol_Mg);
            MyTextsWrapper.m_sb[721] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.IconSymbol_Ni);
            MyTextsWrapper.m_sb[722] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.IconSymbol_Pt);
            MyTextsWrapper.m_sb[723] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.IconSymbol_Stone);
            MyTextsWrapper.m_sb[724] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.IconSymbol_Si);
            MyTextsWrapper.m_sb[725] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.IconSymbol_U);
            MyTextsWrapper.m_sb[726] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertiesText_MotorCurrentAngle);
            MyTextsWrapper.m_sb[727] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyValue_MotorAngleUnlimited);
            MyTextsWrapper.m_sb[728] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertiesText_MotorLimitsDisabled);
            MyTextsWrapper.m_sb[729] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_MotorBrakingTorque);
            MyTextsWrapper.m_sb[730] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_MotorLowerLimit);
            MyTextsWrapper.m_sb[731] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_MotorTorque);
            MyTextsWrapper.m_sb[732] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_MotorUpperLimit);
            MyTextsWrapper.m_sb[733] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_MotorVelocity);
            MyTextsWrapper.m_sb[734] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_Suicide);
            MyTextsWrapper.m_sb[735] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_Girder);
            MyTextsWrapper.m_sb[736] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SwitchText_Open);
            MyTextsWrapper.m_sb[737] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SwitchText_Close);
            MyTextsWrapper.m_sb[738] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoNameHealth);
            MyTextsWrapper.m_sb[739] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoFalling);
            MyTextsWrapper.m_sb[740] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.AssemblerState_Disabled);
            MyTextsWrapper.m_sb[741] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.AssemblerState_MissingItems);
            MyTextsWrapper.m_sb[742] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.AssemblerState_NotEnoughPower);
            MyTextsWrapper.m_sb[743] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.AssemblerState_NothingBeingProduced);
            MyTextsWrapper.m_sb[744] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoNameJetpack);
            MyTextsWrapper.m_sb[745] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Scenario_EasyStart3);
            MyTextsWrapper.m_sb[746] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_LightColor);
            MyTextsWrapper.m_sb[747] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_LightColor);
            MyTextsWrapper.m_sb[748] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_LightRadius);
            MyTextsWrapper.m_sb[749] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_LightRadius);
            MyTextsWrapper.m_sb[750] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_LightFalloff);
            MyTextsWrapper.m_sb[751] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_LightFalloff);
            MyTextsWrapper.m_sb[752] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_LightIntensity);
            MyTextsWrapper.m_sb[753] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_LightIntensity);
            MyTextsWrapper.m_sb[754] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerErrorStartingServer);
            MyTextsWrapper.m_sb[755] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHintPressToOpenDoor);
            MyTextsWrapper.m_sb[756] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.AlreadyUsedBySomebodyElse);
            MyTextsWrapper.m_sb[757] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SwitchText_Off);
            MyTextsWrapper.m_sb[758] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SwitchText_On);
            MyTextsWrapper.m_sb[759] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerJoinFriendsGames);
            MyTextsWrapper.m_sb[760] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCaptionPlayers);
            MyTextsWrapper.m_sb[761] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenPlayersLobby_Friends);
            MyTextsWrapper.m_sb[762] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenPlayersLobby_Private);
            MyTextsWrapper.m_sb[763] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenPlayersLobby_Public);
            MyTextsWrapper.m_sb[764] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenPlayers_GameOwner);
            MyTextsWrapper.m_sb[765] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenPlayers_Invite);
            MyTextsWrapper.m_sb[766] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenPlayers_Kick);
            MyTextsWrapper.m_sb[767] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenPlayers_PlayerName);
            MyTextsWrapper.m_sb[768] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DialogDownloadWorld_WorldDoesNotExists);
            MyTextsWrapper.m_sb[769] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxCaptionKicked);
            MyTextsWrapper.m_sb[770] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextYouHaveBeenKicked);
            MyTextsWrapper.m_sb[771] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_OnlineModeFriends);
            MyTextsWrapper.m_sb[772] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextAreYouSureYouWantToReconnect);
            MyTextsWrapper.m_sb[773] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationMultiplayerDisabled);
            MyTextsWrapper.m_sb[774] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SteamIsOfflinePleaseRestart);
            MyTextsWrapper.m_sb[775] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsEnableCopyPaste);
            MyTextsWrapper.m_sb[776] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_EnableCopyPaste);
            MyTextsWrapper.m_sb[777] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerCompatibleVersions);
            MyTextsWrapper.m_sb[778] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MaxPlayers);
            MyTextsWrapper.m_sb[779] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DialogWaitingForWorldData);
            MyTextsWrapper.m_sb[780] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerErrorConnectionFailed);
            MyTextsWrapper.m_sb[781] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerStateConnectingToServer);
            MyTextsWrapper.m_sb[782] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerStateWaitingForServer);
            MyTextsWrapper.m_sb[783] =
                (MyTextsWrapper.TextInfo)
                    new StringBuilder(MyTexts.HarvestingWarningInventoryMightBeTruncatedAreYouSure);
            MyTextsWrapper.m_sb[784] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCaptionFriendWorlds);
            MyTextsWrapper.m_sb[785] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCaptionPublicWorlds);
            MyTextsWrapper.m_sb[786] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_CubeColorChange);
            MyTextsWrapper.m_sb[787] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_EnableWeapons);
            MyTextsWrapper.m_sb[788] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationWeaponDisabledInSettings);
            MyTextsWrapper.m_sb[789] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlDescPlayersList);
            MyTextsWrapper.m_sb[790] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMenuButtonPlayers);
            MyTextsWrapper.m_sb[791] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.AssemblerState_NotWorking);
            MyTextsWrapper.m_sb[792] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Passage);
            MyTextsWrapper.m_sb[793] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ItemDamagedDescription);
            MyTextsWrapper.m_sb[794] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplaterJoin_ServerIsNotResponding);
            MyTextsWrapper.m_sb[795] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_GravityAcceleration);
            MyTextsWrapper.m_sb[796] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_GravityFieldDepth);
            MyTextsWrapper.m_sb[797] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_GravityFieldHeight);
            MyTextsWrapper.m_sb[798] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_GravityFieldWidth);
            MyTextsWrapper.m_sb[799] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_GravityAcceleration);
            MyTextsWrapper.m_sb[800] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_GravityFieldDepth);
            MyTextsWrapper.m_sb[801] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_GravityFieldHeight);
            MyTextsWrapper.m_sb[802] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_GravityFieldWidth);
            MyTextsWrapper.m_sb[803] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHintPressToOpenTerminal);
            MyTextsWrapper.m_sb[804] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHintPressToRechargeInMedicalRoom);
            MyTextsWrapper.m_sb[805] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.UnsupportedAspectRatio);
            MyTextsWrapper.m_sb[806] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.OnlyFriendsCanJoinThisGame);
            MyTextsWrapper.m_sb[807] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsDescription);
            MyTextsWrapper.m_sb[808] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.CompressSaveGames);
            MyTextsWrapper.m_sb[809] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipGameOptionsCompressSaveGames);
            MyTextsWrapper.m_sb[810] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Headbob);
            MyTextsWrapper.m_sb[811] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsShowPlayerNamesOnHud);
            MyTextsWrapper.m_sb[812] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_ShowPlayerNamesOnHud);
            MyTextsWrapper.m_sb[813] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenOptionsGame_ShowPlayerNames);
            MyTextsWrapper.m_sb[814] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipGameOptionsShowPlayerNames);
            MyTextsWrapper.m_sb[815] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipTerminalInventory_ThrowOut);
            MyTextsWrapper.m_sb[816] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationSuitEnergyLow);
            MyTextsWrapper.m_sb[817] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationInventoryFull);
            MyTextsWrapper.m_sb[818] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationSuitEnergyCritical);
            MyTextsWrapper.m_sb[819] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MaxFloatingObjects);
            MyTextsWrapper.m_sb[820] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsMaxFloatingObjects);
            MyTextsWrapper.m_sb[821] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.OutOfAmmo);
            MyTextsWrapper.m_sb[822] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipItemFilter_Missile200mm);
            MyTextsWrapper.m_sb[823] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipItemFilter_NATO_25x184mm);
            MyTextsWrapper.m_sb[824] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationMissingComponentToPlaceBlockFormat);
            MyTextsWrapper.m_sb[825] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Scenario_Asteroids);
            MyTextsWrapper.m_sb[826] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Asteroid_Amount);
            MyTextsWrapper.m_sb[827] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_Explosives);
            MyTextsWrapper.m_sb[828] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_AsteroidAmountExtreme);
            MyTextsWrapper.m_sb[829] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_AsteroidAmountLarge);
            MyTextsWrapper.m_sb[830] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_AsteroidAmountNormal);
            MyTextsWrapper.m_sb[831] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsAsteroidAmount);
            MyTextsWrapper.m_sb[832] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsMaxPlayer);
            MyTextsWrapper.m_sb[833] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsWeapons);
            MyTextsWrapper.m_sb[834] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_OreDetectorRange);
            MyTextsWrapper.m_sb[835] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_OreDetectorRange);
            MyTextsWrapper.m_sb[836] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_ColumnTitle_GameMode);
            MyTextsWrapper.m_sb[837] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_ColumnTitle_Players);
            MyTextsWrapper.m_sb[838] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_ColumnTitle_Username);
            MyTextsWrapper.m_sb[839] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_ColumnTitle_World);
            MyTextsWrapper.m_sb[840] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_ColumnTitle_WorldSize);
            MyTextsWrapper.m_sb[841] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipItemFilter_AssembledItems);
            MyTextsWrapper.m_sb[842] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.AssemblerState_InventoryFull);
            MyTextsWrapper.m_sb[843] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_InventorySize);
            MyTextsWrapper.m_sb[844] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_GameSurvivalTimes1);
            MyTextsWrapper.m_sb[845] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_GameSurvivalTimes3);
            MyTextsWrapper.m_sb[846] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsModeCreative);
            MyTextsWrapper.m_sb[847] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsModeSurvival);
            MyTextsWrapper.m_sb[848] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Description_Scenario_Asteroids);
            MyTextsWrapper.m_sb[849] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Description_Scenario_EasyStart1);
            MyTextsWrapper.m_sb[850] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Description_Scenario_EasyStart2);
            MyTextsWrapper.m_sb[851] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Description_Scenario_EmptyWorld);
            MyTextsWrapper.m_sb[852] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Description_Scenario_LoneSurvivor);
            MyTextsWrapper.m_sb[853] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextSuicide);
            MyTextsWrapper.m_sb[854] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Scenario_CrashedRedShip);
            MyTextsWrapper.m_sb[855] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Description_Scenario_CrashedRedShip);
            MyTextsWrapper.m_sb[856] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudBlockInfo_Components);
            MyTextsWrapper.m_sb[857] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudBlockInfo_Installed_Required);
            MyTextsWrapper.m_sb[858] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_Scrap);
            MyTextsWrapper.m_sb[859] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerErrorServerHasLeft);
            MyTextsWrapper.m_sb[860] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationRespawn);
            MyTextsWrapper.m_sb[861] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudBlockInfo_Required);
            MyTextsWrapper.m_sb[862] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudBlockInfo_LargeShip_Station);
            MyTextsWrapper.m_sb[863] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudBlockInfo_SmallShip);
            MyTextsWrapper.m_sb[864] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Production);
            MyTextsWrapper.m_sb[865] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenTerminalError_NoAssemblers);
            MyTextsWrapper.m_sb[866] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Scenario_TwoPlatforms);
            MyTextsWrapper.m_sb[867] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Description_Scenario_TwoPlatforms);
            MyTextsWrapper.m_sb[868] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Terminal_BlockIncomplete);
            MyTextsWrapper.m_sb[869] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoInventoryVolume);
            MyTextsWrapper.m_sb[870] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_AssemblerEfficiency);
            MyTextsWrapper.m_sb[871] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_Realistic);
            MyTextsWrapper.m_sb[872] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_RefinerySpeed);
            MyTextsWrapper.m_sb[873] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_Realistic_x10);
            MyTextsWrapper.m_sb[874] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_Realistic_x3);
            MyTextsWrapper.m_sb[875] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettings_Assembler_x1);
            MyTextsWrapper.m_sb[876] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettings_Assembler_x10);
            MyTextsWrapper.m_sb[877] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettings_Assembler_x3);
            MyTextsWrapper.m_sb[878] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettings_Inventory_x1);
            MyTextsWrapper.m_sb[879] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettings_Inventory_x10);
            MyTextsWrapper.m_sb[880] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettings_Inventory_x3);
            MyTextsWrapper.m_sb[881] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettings_Refinery_x1);
            MyTextsWrapper.m_sb[882] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettings_Refinery_x10);
            MyTextsWrapper.m_sb[883] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettings_Refinery_x3);
            MyTextsWrapper.m_sb[884] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_SolarCell);
            MyTextsWrapper.m_sb[885] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_SolarPanel);
            MyTextsWrapper.m_sb[886] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenTerminalProduction_Blueprints);
            MyTextsWrapper.m_sb[887] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenTerminalProduction_AssemblingButton);
            MyTextsWrapper.m_sb[888] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenTerminalProduction_ControlPanelButton);
            MyTextsWrapper.m_sb[889] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenTerminalProduction_DisassembleAllButton);
            MyTextsWrapper.m_sb[890] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenTerminalProduction_DisassemblingButton);
            MyTextsWrapper.m_sb[891] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenTerminalProduction_GainedAndAvailable);
            MyTextsWrapper.m_sb[892] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenTerminalProduction_Inventory);
            MyTextsWrapper.m_sb[893] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenTerminalProduction_InventoryButton);
            MyTextsWrapper.m_sb[894] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenTerminalProduction_ProductionQueue);
            MyTextsWrapper.m_sb[895] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenTerminalProduction_RequiredAndAvailable);
            MyTextsWrapper.m_sb[896] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenTerminalProduction_StoredMaterials);
            MyTextsWrapper.m_sb[897] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipTerminalProduction_AssemblingMode);
            MyTextsWrapper.m_sb[898] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipTerminalProduction_DisassembleAll);
            MyTextsWrapper.m_sb[899] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipTerminalProduction_DisassemblingMode);
            MyTextsWrapper.m_sb[900] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipTerminalProduction_RepeatMode);
            MyTextsWrapper.m_sb[901] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_GameTypeToolTip_MultipliersFormat);
            MyTextsWrapper.m_sb[902] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationClientConnected);
            MyTextsWrapper.m_sb[903] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationClientDisconnected);
            MyTextsWrapper.m_sb[904] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_ThrusterDamage);
            MyTextsWrapper.m_sb[905] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsThrusterDamage);
            MyTextsWrapper.m_sb[906] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsEnableCargoShips);
            MyTextsWrapper.m_sb[907] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_EnableCargoShips);
            MyTextsWrapper.m_sb[908] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerError_IncorrectVersion);
            MyTextsWrapper.m_sb[909] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_EnvironmentHostilityCataclysmUnreal);
            MyTextsWrapper.m_sb[910] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.FirstApril2014);
            MyTextsWrapper.m_sb[911] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ShowCrosshair);
            MyTextsWrapper.m_sb[912] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipGameOptionsShowCrosshair);
            MyTextsWrapper.m_sb[913] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_VirtualMass);
            MyTextsWrapper.m_sb[914] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Cockpit2);
            MyTextsWrapper.m_sb[915] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextSavingInProgress);
            MyTextsWrapper.m_sb[916] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Collector);
            MyTextsWrapper.m_sb[917] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Cockpit3);
            MyTextsWrapper.m_sb[918] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Window1x1Face);
            MyTextsWrapper.m_sb[919] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Window1x1Flat);
            MyTextsWrapper.m_sb[920] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Window1x1Inv);
            MyTextsWrapper.m_sb[921] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Window1x1Side);
            MyTextsWrapper.m_sb[922] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Window1x1Slope);
            MyTextsWrapper.m_sb[923] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Window1x2Face);
            MyTextsWrapper.m_sb[924] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Window1x2Flat);
            MyTextsWrapper.m_sb[925] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Window1x2Inv);
            MyTextsWrapper.m_sb[926] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Window1x2SideLeft);
            MyTextsWrapper.m_sb[927] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Window1x2SideRight);
            MyTextsWrapper.m_sb[928] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Window1x2Slope);
            MyTextsWrapper.m_sb[929] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Window2x3Flat);
            MyTextsWrapper.m_sb[930] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Window3x3Flat);
            MyTextsWrapper.m_sb[931] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextOpenBrowserLocalization);
            MyTextsWrapper.m_sb[932] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenOptionsGame_LocalizationWarning);
            MyTextsWrapper.m_sb[933] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenOptionsGame_MoreInfo);
            MyTextsWrapper.m_sb[934] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlDescSingleAllMode);
            MyTextsWrapper.m_sb[935] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Terminal_UseConveyorSystem);
            MyTextsWrapper.m_sb[936] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Terminal_CollectAll);
            MyTextsWrapper.m_sb[937] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Terminal_ThrowOut);
            MyTextsWrapper.m_sb[938] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Connector);
            MyTextsWrapper.m_sb[939] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_ConveyorTube);
            MyTextsWrapper.m_sb[940] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Window1x1FlatInv);
            MyTextsWrapper.m_sb[941] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Window1x2FlatInv);
            MyTextsWrapper.m_sb[942] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Window2x3FlatInv);
            MyTextsWrapper.m_sb[943] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Window3x3FlatInv);
            MyTextsWrapper.m_sb[944] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Multiplayer_IndirectConnection);
            MyTextsWrapper.m_sb[945] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Multiplayer_LastMsg);
            MyTextsWrapper.m_sb[946] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Multiplayer_NoConnection);
            MyTextsWrapper.m_sb[947] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHintSwitchWeaponMode);
            MyTextsWrapper.m_sb[948] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_LargeTurretRadius);
            MyTextsWrapper.m_sb[949] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipItemFilter_NATO_5p56x45mm);
            MyTextsWrapper.m_sb[950] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.GamePaused);
            MyTextsWrapper.m_sb[951] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Wheel1x1);
            MyTextsWrapper.m_sb[952] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Wheel3x3);
            MyTextsWrapper.m_sb[953] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Wheel5x5);
            MyTextsWrapper.m_sb[954] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlDescPauseGame);
            MyTextsWrapper.m_sb[955] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_ShipGrinder);
            MyTextsWrapper.m_sb[956] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_GyroPower);
            MyTextsWrapper.m_sb[957] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_GyroPower);
            MyTextsWrapper.m_sb[958] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Decoy);
            MyTextsWrapper.m_sb[959] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_PauseGame);
            MyTextsWrapper.m_sb[960] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeysPause);
            MyTextsWrapper.m_sb[961] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalButton_GroupSave);
            MyTextsWrapper.m_sb[962] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationWeaponNotWorking);
            MyTextsWrapper.m_sb[963] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockActionTitle_Lock);
            MyTextsWrapper.m_sb[964] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockActionTitle_Unlock);
            MyTextsWrapper.m_sb[965] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockActionTitle_Reverse);
            MyTextsWrapper.m_sb[966] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyProperties_CurrentInput);
            MyTextsWrapper.m_sb[967] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyProperties_CurrentMass);
            MyTextsWrapper.m_sb[968] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyProperties_CurrentOutput);
            MyTextsWrapper.m_sb[969] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertiesText_LockState);
            MyTextsWrapper.m_sb[970] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertiesText_MaxOutput);
            MyTextsWrapper.m_sb[971] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertiesText_MaxRequiredInput);
            MyTextsWrapper.m_sb[972] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertiesText_RequiredInput);
            MyTextsWrapper.m_sb[973] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertiesText_Type);
            MyTextsWrapper.m_sb[974] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyValue_Locked);
            MyTextsWrapper.m_sb[975] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyValue_ReadyToLock);
            MyTextsWrapper.m_sb[976] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyValue_Unlocked);
            MyTextsWrapper.m_sb[977] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote70Author);
            MyTextsWrapper.m_sb[978] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Quote70Text);
            MyTextsWrapper.m_sb[979] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_ConveyorTubeCurved);
            MyTextsWrapper.m_sb[980] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_LargeTurretTargetDecoys);
            MyTextsWrapper.m_sb[981] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_LargeTurretTargetMeteors);
            MyTextsWrapper.m_sb[982] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_LargeTurretTargetMoving);
            MyTextsWrapper.m_sb[983] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DialogAmount_AddAmountCaption);
            MyTextsWrapper.m_sb[984] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DialogAmount_SetValueCaption);
            MyTextsWrapper.m_sb[985] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_LargeTurretTargetMissiles);
            MyTextsWrapper.m_sb[986] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_ShipWelder);
            MyTextsWrapper.m_sb[987] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationEnergyCritical);
            MyTextsWrapper.m_sb[988] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationEnergyLow);
            MyTextsWrapper.m_sb[989] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationEnergyNo);
            MyTextsWrapper.m_sb[990] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationFuelCritical);
            MyTextsWrapper.m_sb[991] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationFuelLow);
            MyTextsWrapper.m_sb[992] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationFuelNo);
            MyTextsWrapper.m_sb[993] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHealthCritical);
            MyTextsWrapper.m_sb[994] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHealthLow);
            MyTextsWrapper.m_sb[995] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationMeteorInbound);
            MyTextsWrapper.m_sb[996] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_ConveyorTubeMedium);
            MyTextsWrapper.m_sb[997] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_ConnectorSmall);
            MyTextsWrapper.m_sb[998] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_ConveyorFrame);
            MyTextsWrapper.m_sb[999] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_ConveyorSmall);
            MyTextsWrapper.m_sb[1000] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_ConveyorTubeCurvedSmall);
            MyTextsWrapper.m_sb[1001] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_ConveyorTubeSmall);
            MyTextsWrapper.m_sb[1002] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHintPressToOpenInventoryConnector);
            MyTextsWrapper.m_sb[1003] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerError_DifferentData);
            MyTextsWrapper.m_sb[1004] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerJoin_IncompatibleGameDataLabel);
            MyTextsWrapper.m_sb[1005] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Info);
            MyTextsWrapper.m_sb[1006] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Info_ConvertButton);
            MyTextsWrapper.m_sb[1007] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Info_Conveyors);
            MyTextsWrapper.m_sb[1008] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Info_Blocks);
            MyTextsWrapper.m_sb[1009] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Info_GravGens);
            MyTextsWrapper.m_sb[1010] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Info_Lights);
            MyTextsWrapper.m_sb[1011] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Info_NonArmor);
            MyTextsWrapper.m_sb[1012] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Info_Triangles);
            MyTextsWrapper.m_sb[1013] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Info_Reflectors);
            MyTextsWrapper.m_sb[1014] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Info_Thrusters);
            MyTextsWrapper.m_sb[1015] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Info_VirtualMass);
            MyTextsWrapper.m_sb[1016] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Info_BlocksTooltip);
            MyTextsWrapper.m_sb[1017] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Info_TrianglesTooltip);
            MyTextsWrapper.m_sb[1018] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenPlayers_GameAdmin);
            MyTextsWrapper.m_sb[1019] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerJoinServers);
            MyTextsWrapper.m_sb[1020] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerErrorAlreadyJoined);
            MyTextsWrapper.m_sb[1021] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerErrorNotInGroup);
            MyTextsWrapper.m_sb[1022] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerErrorServerFull);
            MyTextsWrapper.m_sb[1023] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerErrorSteamServersOffline);
            MyTextsWrapper.m_sb[1024] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerErrorTicketInvalid);
            MyTextsWrapper.m_sb[1025] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerJoinLANServers);
            MyTextsWrapper.m_sb[1026] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_TabTitle_Friends);
            MyTextsWrapper.m_sb[1027] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_TabTitle_LAN);
            MyTextsWrapper.m_sb[1028] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_TabTitle_Lobbies);
            MyTextsWrapper.m_sb[1029] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_TabTitle_Servers);
            MyTextsWrapper.m_sb[1030] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_Title);
            MyTextsWrapper.m_sb[1031] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_ColumnTitle_Ping);
            MyTextsWrapper.m_sb[1032] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_ColumnTitle_Server);
            MyTextsWrapper.m_sb[1033] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerErrorLoggedInElseWhere);
            MyTextsWrapper.m_sb[1034] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerErrorNoLicenseOrExpired);
            MyTextsWrapper.m_sb[1035] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerErrorTicketAlreadyUsed);
            MyTextsWrapper.m_sb[1036] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerErrorTicketCanceled);
            MyTextsWrapper.m_sb[1037] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerErrorUserNotConnected);
            MyTextsWrapper.m_sb[1038] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerErrorVACBanned);
            MyTextsWrapper.m_sb[1039] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerErrorVACCheckTimedOut);
            MyTextsWrapper.m_sb[1040] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerJoinAllowedGroups);
            MyTextsWrapper.m_sb[1041] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_MergeBlock);
            MyTextsWrapper.m_sb[1042] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NewsDownloadingFailed);
            MyTextsWrapper.m_sb[1043] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxCaptionInfo);
            MyTextsWrapper.m_sb[1044] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NewVersionAvailable);
            MyTextsWrapper.m_sb[1045] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerErrorGroupIdInvalid);
            MyTextsWrapper.m_sb[1046] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_TabTooltip_LAN);
            MyTextsWrapper.m_sb[1047] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_TabTooltip_Lobbies);
            MyTextsWrapper.m_sb[1048] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_TabTooltip_Servers);
            MyTextsWrapper.m_sb[1049] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsEnableSpectator);
            MyTextsWrapper.m_sb[1050] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_EnableSpectator);
            MyTextsWrapper.m_sb[1051] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.PlayerCharacterColor);
            MyTextsWrapper.m_sb[1052] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.PlayerCharacterColorBlack);
            MyTextsWrapper.m_sb[1053] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.PlayerCharacterColorBlue);
            MyTextsWrapper.m_sb[1054] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.PlayerCharacterColorDefault);
            MyTextsWrapper.m_sb[1055] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.PlayerCharacterColorGreen);
            MyTextsWrapper.m_sb[1056] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.PlayerCharacterColorRed);
            MyTextsWrapper.m_sb[1057] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.PlayerCharacterColorWhite);
            MyTextsWrapper.m_sb[1058] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.PlayerCharacterColorYellow);
            MyTextsWrapper.m_sb[1059] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHintPressToUseWardrobe);
            MyTextsWrapper.m_sb[1060] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalControlPanel_Cockpit_ControlThrusters);
            MyTextsWrapper.m_sb[1061] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalControlPanel_Cockpit_ControlWheels);
            MyTextsWrapper.m_sb[1062] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_MotorUsesWheelCommands);
            MyTextsWrapper.m_sb[1063] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_MotorUsesWheelCommands);
            MyTextsWrapper.m_sb[1064] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Info_Rotors);
            MyTextsWrapper.m_sb[1065] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenOptionsVideo_WindowMode);
            MyTextsWrapper.m_sb[1066] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenOptionsVideo_WindowMode_Fullscreen);
            MyTextsWrapper.m_sb[1067] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenOptionsVideo_WindowMode_FullscreenWindow);
            MyTextsWrapper.m_sb[1068] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenOptionsVideo_WindowMode_Window);
            MyTextsWrapper.m_sb[1069] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_BreakForce);
            MyTextsWrapper.m_sb[1070] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_LandGearAutoLock);
            MyTextsWrapper.m_sb[1071] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SpectatorControls);
            MyTextsWrapper.m_sb[1072] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SpectatorControls_None_Desc);
            MyTextsWrapper.m_sb[1073] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SpectatorControls_Delta_Desc);
            MyTextsWrapper.m_sb[1074] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SpectatorControls_Free_Desc);
            MyTextsWrapper.m_sb[1075] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SpectatorControls_Static_Desc);
            MyTextsWrapper.m_sb[1076] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerErrorBannedByAdmins);
            MyTextsWrapper.m_sb[1077] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerErrorBannedByAdminsWithDialog);
            MyTextsWrapper.m_sb[1078] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextYouHaveBeenBanned);
            MyTextsWrapper.m_sb[1079] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenPlayers_Ban);
            MyTextsWrapper.m_sb[1080] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudMarker_ReturnToWorld);
            MyTextsWrapper.m_sb[1081] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationLeavingWorld);
            MyTextsWrapper.m_sb[1082] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCaptionAdvancedSettings);
            MyTextsWrapper.m_sb[1083] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_Advanced);
            MyTextsWrapper.m_sb[1084] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions);
            MyTextsWrapper.m_sb[1085] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_Create);
            MyTextsWrapper.m_sb[1086] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_CreateToolTip);
            MyTextsWrapper.m_sb[1087] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_Leave);
            MyTextsWrapper.m_sb[1088] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_Join);
            MyTextsWrapper.m_sb[1089] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_JoinToolTip);
            MyTextsWrapper.m_sb[1090] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.String1TerminalTab_Factions_LeaveToolTip);
            MyTextsWrapper.m_sb[1091] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_Enemy);
            MyTextsWrapper.m_sb[1092] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_Friend);
            MyTextsWrapper.m_sb[1093] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_FriendToolTip);
            MyTextsWrapper.m_sb[1094] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_CreateFaction);
            MyTextsWrapper.m_sb[1095] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_CreateFactionDescription);
            MyTextsWrapper.m_sb[1096] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_CreateFactionName);
            MyTextsWrapper.m_sb[1097] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_CreateFactionPrivateInfo);
            MyTextsWrapper.m_sb[1098] =
                (MyTextsWrapper.TextInfo)
                    new StringBuilder(MyTexts.TerminalTab_Factions_CreateFactionPrivateInfoToolTip);
            MyTextsWrapper.m_sb[1099] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_CreateFactionTag);
            MyTextsWrapper.m_sb[1100] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_CreateFactionTagToolTip);
            MyTextsWrapper.m_sb[1101] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Spectator);
            MyTextsWrapper.m_sb[1102] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SpectatorControls_Delta);
            MyTextsWrapper.m_sb[1103] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SpectatorControls_Free);
            MyTextsWrapper.m_sb[1104] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SpectatorControls_None);
            MyTextsWrapper.m_sb[1105] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SpectatorControls_Static);
            MyTextsWrapper.m_sb[1106] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Info_ShowMassCenter);
            MyTextsWrapper.m_sb[1107] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxErrorFactionsNameAlreadyExists);
            MyTextsWrapper.m_sb[1108] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxErrorFactionsShortcut);
            MyTextsWrapper.m_sb[1109] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxErrorFactionsShortcutAlreadyExists);
            MyTextsWrapper.m_sb[1110] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxErrorFactionsNameTooShort);
            MyTextsWrapper.m_sb[1111] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_BeforeCreateLeave);
            MyTextsWrapper.m_sb[1112] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Edit);
            MyTextsWrapper.m_sb[1113] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Kick);
            MyTextsWrapper.m_sb[1114] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Leader);
            MyTextsWrapper.m_sb[1115] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Member);
            MyTextsWrapper.m_sb[1116] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxConfirmFactionsKickPlayer);
            MyTextsWrapper.m_sb[1117] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxConfirmFactionsLeave);
            MyTextsWrapper.m_sb[1118] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Promote);
            MyTextsWrapper.m_sb[1119] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsRemoveTrash);
            MyTextsWrapper.m_sb[1120] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_LimitWorldSize);
            MyTextsWrapper.m_sb[1121] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_RemoveTrash);
            MyTextsWrapper.m_sb[1122] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Demote);
            MyTextsWrapper.m_sb[1123] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.AccessDenied);
            MyTextsWrapper.m_sb[1124] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Founder);
            MyTextsWrapper.m_sb[1125] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Status);
            MyTextsWrapper.m_sb[1126] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_Private);
            MyTextsWrapper.m_sb[1127] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Accept);
            MyTextsWrapper.m_sb[1128] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Terminal_BlockAccessDenied);
            MyTextsWrapper.m_sb[1129] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxConfirmFactionsAcceptJoin);
            MyTextsWrapper.m_sb[1130] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxConfirmFactionsDemote);
            MyTextsWrapper.m_sb[1131] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxConfirmFactionsPromote);
            MyTextsWrapper.m_sb[1132] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_EditFaction);
            MyTextsWrapper.m_sb[1133] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Applicant);
            MyTextsWrapper.m_sb[1134] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationRespawnShipDelete);
            MyTextsWrapper.m_sb[1135] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TooltipWorldSettingsRespawnShipDelete);
            MyTextsWrapper.m_sb[1136] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_RespawnShipDelete);
            MyTextsWrapper.m_sb[1137] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Tag);
            MyTextsWrapper.m_sb[1138] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_PendingPeace);
            MyTextsWrapper.m_sb[1139] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_SentPeace);
            MyTextsWrapper.m_sb[1140] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_BreakForce);
            MyTextsWrapper.m_sb[1141] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_WarningChangingWorldSize);
            MyTextsWrapper.m_sb[1142] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_BroadcastRadius);
            MyTextsWrapper.m_sb[1143] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_BroadcastRadius);
            MyTextsWrapper.m_sb[1144] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Default_Astronaut);
            MyTextsWrapper.m_sb[1145] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_CancelJoin);
            MyTextsWrapper.m_sb[1146] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_CancelPeaceRequest);
            MyTextsWrapper.m_sb[1147] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_SentJoinToolTip);
            MyTextsWrapper.m_sb[1148] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockOwner_Me);
            MyTextsWrapper.m_sb[1149] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockOwner_Nobody);
            MyTextsWrapper.m_sb[1150] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockOwner_Owner);
            MyTextsWrapper.m_sb[1151] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockOwner_ShareAll);
            MyTextsWrapper.m_sb[1152] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockOwner_ShareFaction);
            MyTextsWrapper.m_sb[1153] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockOwner_Transfer);
            MyTextsWrapper.m_sb[1154] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_PassengerSeat);
            MyTextsWrapper.m_sb[1155] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Terminal_GroupTitle);
            MyTextsWrapper.m_sb[1156] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_Members);
            MyTextsWrapper.m_sb[1157] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_ResetOwnership);
            MyTextsWrapper.m_sb[1158] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsResetOwnership);
            MyTextsWrapper.m_sb[1159] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SessionDeleteFailed);
            MyTextsWrapper.m_sb[1160] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Medicals_Title);
            MyTextsWrapper.m_sb[1161] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextChangeOwner);
            MyTextsWrapper.m_sb[1162] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Respawn);
            MyTextsWrapper.m_sb[1163] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BatteryBlock);
            MyTextsWrapper.m_sb[1164] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Battery);
            MyTextsWrapper.m_sb[1165] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertiesText_MaxStoredPower);
            MyTextsWrapper.m_sb[1166] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertiesText_StoredPower);
            MyTextsWrapper.m_sb[1167] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipBatteryBlock);
            MyTextsWrapper.m_sb[1168] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_Recharge);
            MyTextsWrapper.m_sb[1169] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockOwner_ShareNone);
            MyTextsWrapper.m_sb[1170] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettings_Grinder_half);
            MyTextsWrapper.m_sb[1171] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettings_Grinder_x1);
            MyTextsWrapper.m_sb[1172] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettings_Grinder_x2);
            MyTextsWrapper.m_sb[1173] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettings_Grinder_x5);
            MyTextsWrapper.m_sb[1174] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettings_Welder_half);
            MyTextsWrapper.m_sb[1175] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettings_Welder_x1);
            MyTextsWrapper.m_sb[1176] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettings_Welder_x2);
            MyTextsWrapper.m_sb[1177] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettings_Welder_x5);
            MyTextsWrapper.m_sb[1178] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_Realistic_half);
            MyTextsWrapper.m_sb[1179] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_Realistic_x2);
            MyTextsWrapper.m_sb[1180] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_Realistic_x5);
            MyTextsWrapper.m_sb[1181] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_GrinderSpeed);
            MyTextsWrapper.m_sb[1182] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_WelderSpeed);
            MyTextsWrapper.m_sb[1183] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsSoundMode);
            MyTextsWrapper.m_sb[1184] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_ArcadeSound);
            MyTextsWrapper.m_sb[1185] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_RealisticSound);
            MyTextsWrapper.m_sb[1186] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_SoundMode);
            MyTextsWrapper.m_sb[1187] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Terminal_ShowOnHUD);
            MyTextsWrapper.m_sb[1188] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Terminal_ShowOnHUDToolTip);
            MyTextsWrapper.m_sb[1189] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MultiplayerJoinSameGameData);
            MyTextsWrapper.m_sb[1190] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_AcceptPeaceRequest);
            MyTextsWrapper.m_sb[1191] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxCaptionRespawn);
            MyTextsWrapper.m_sb[1192] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.RespawnShip);
            MyTextsWrapper.m_sb[1193] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Refresh);
            MyTextsWrapper.m_sb[1194] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.PlayerInfo_Dead);
            MyTextsWrapper.m_sb[1195] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMods_ActiveMods);
            MyTextsWrapper.m_sb[1196] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMods_AvailableMods);
            MyTextsWrapper.m_sb[1197] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipScreenMods_MoveLeft);
            MyTextsWrapper.m_sb[1198] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipScreenMods_MoveLeftAll);
            MyTextsWrapper.m_sb[1199] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipScreenMods_MoveRight);
            MyTextsWrapper.m_sb[1200] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipScreenMods_MoveRightAll);
            MyTextsWrapper.m_sb[1201] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_Mods);
            MyTextsWrapper.m_sb[1202] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorkshopOpenModInWorkshop);
            MyTextsWrapper.m_sb[1203] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorkshopRefreshMod);
            MyTextsWrapper.m_sb[1204] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Factions_EnemyFaction);
            MyTextsWrapper.m_sb[1205] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Factions_NeutralFaction);
            MyTextsWrapper.m_sb[1206] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Factions_YourFaction);
            MyTextsWrapper.m_sb[1207] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipTerminalInventory_ShowInteracted);
            MyTextsWrapper.m_sb[1208] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HideEmpty);
            MyTextsWrapper.m_sb[1209] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalControlPanel_Cockpit_Handbrake);
            MyTextsWrapper.m_sb[1210] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_Motor_Damping);
            MyTextsWrapper.m_sb[1211] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_Motor_Strength);
            MyTextsWrapper.m_sb[1212] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenTerminal_Infinite);
            MyTextsWrapper.m_sb[1213] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_SearchLabel);
            MyTextsWrapper.m_sb[1214] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_SearchTooltip);
            MyTextsWrapper.m_sb[1215] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_ClientCanSave);
            MyTextsWrapper.m_sb[1216] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgressTextDownloadingMods);
            MyTextsWrapper.m_sb[1217] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_Motor_Propulsion);
            MyTextsWrapper.m_sb[1218] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_Motor_Steering);
            MyTextsWrapper.m_sb[1219] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_Motor_Propulsion);
            MyTextsWrapper.m_sb[1220] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_Motor_Steering);
            MyTextsWrapper.m_sb[1221] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationClientCannotSave);
            MyTextsWrapper.m_sb[1222] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_Motor_Friction);
            MyTextsWrapper.m_sb[1223] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_Motor_Friction);
            MyTextsWrapper.m_sb[1224] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Suspension1x1);
            MyTextsWrapper.m_sb[1225] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Suspension3x3);
            MyTextsWrapper.m_sb[1226] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Suspension5x5);
            MyTextsWrapper.m_sb[1227] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationWheelNotPlaced);
            MyTextsWrapper.m_sb[1228] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipScreenMods_MoveDown);
            MyTextsWrapper.m_sb[1229] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipScreenMods_MoveUp);
            MyTextsWrapper.m_sb[1230] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipScreenMods_MoveBottom);
            MyTextsWrapper.m_sb[1231] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipScreenMods_MoveTop);
            MyTextsWrapper.m_sb[1232] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Factions_YourBlock);
            MyTextsWrapper.m_sb[1233] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_Motor_Power);
            MyTextsWrapper.m_sb[1234] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_Motor_Power);
            MyTextsWrapper.m_sb[1235] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_VerticalCen);
            MyTextsWrapper.m_sb[1236] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlDescBrake);
            MyTextsWrapper.m_sb[1237] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlDescLoot);
            MyTextsWrapper.m_sb[1238] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationObstructingBlockDuringMerge);
            MyTextsWrapper.m_sb[1239] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsPermanentDeath);
            MyTextsWrapper.m_sb[1240] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_PermanentDeath);
            MyTextsWrapper.m_sb[1241] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Item_PowerCell);
            MyTextsWrapper.m_sb[1242] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertiesText_DepletedIn);
            MyTextsWrapper.m_sb[1243] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertiesText_RechargedIn);
            MyTextsWrapper.m_sb[1244] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyButtonOff_Retract);
            MyTextsWrapper.m_sb[1245] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyButtonOn_Expand);
            MyTextsWrapper.m_sb[1246] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_Force);
            MyTextsWrapper.m_sb[1247] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_MaximalDistance);
            MyTextsWrapper.m_sb[1248] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_MinimalDistance);
            MyTextsWrapper.m_sb[1249] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_Velocity);
            MyTextsWrapper.m_sb[1250] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextCannotCreateGroup);
            MyTextsWrapper.m_sb[1251] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextCannotDeleteGroup);
            MyTextsWrapper.m_sb[1252] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoNameNumberOfBatteries);
            MyTextsWrapper.m_sb[1253] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_AutoAccept);
            MyTextsWrapper.m_sb[1254] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_AutoAcceptToolTip);
            MyTextsWrapper.m_sb[1255] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_Semiauto);
            MyTextsWrapper.m_sb[1256] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipBatteryBlock_Semiauto);
            MyTextsWrapper.m_sb[1257] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockAction_Toggle);
            MyTextsWrapper.m_sb[1258] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_AutoAcceptRequest);
            MyTextsWrapper.m_sb[1259] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Factions_AutoAcceptRequestToolTip);
            MyTextsWrapper.m_sb[1260] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_MotorRotorDisplacement);
            MyTextsWrapper.m_sb[1261] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_MotorRotorDisplacement);
            MyTextsWrapper.m_sb[1262] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_ArmorCenter);
            MyTextsWrapper.m_sb[1263] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_ArmorCorner);
            MyTextsWrapper.m_sb[1264] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_ArmorSide);
            MyTextsWrapper.m_sb[1265] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockAction_RemoveFromToolbar);
            MyTextsWrapper.m_sb[1266] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_PistonBase);
            MyTextsWrapper.m_sb[1267] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolbarAction_Decrease);
            MyTextsWrapper.m_sb[1268] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolbarAction_Increase);
            MyTextsWrapper.m_sb[1269] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolbarAction_Reset);
            MyTextsWrapper.m_sb[1270] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_ThrustOverride);
            MyTextsWrapper.m_sb[1271] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_ThrustOverride);
            MyTextsWrapper.m_sb[1272] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextYouHaveBeenKickedFromFaction);
            MyTextsWrapper.m_sb[1273] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextYouHaveBeenAcceptedToFaction);
            MyTextsWrapper.m_sb[1274] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockAction_Switch);
            MyTextsWrapper.m_sb[1275] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockAction_DoorClosed);
            MyTextsWrapper.m_sb[1276] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockAction_DoorOpen);
            MyTextsWrapper.m_sb[1277] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_PistonTop);
            MyTextsWrapper.m_sb[1278] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_RotorPart);
            MyTextsWrapper.m_sb[1279] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_ArmorInvCorner);
            MyTextsWrapper.m_sb[1280] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_GyroOverride);
            MyTextsWrapper.m_sb[1281] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_GyroOverride);
            MyTextsWrapper.m_sb[1282] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_GyroPitchOverride);
            MyTextsWrapper.m_sb[1283] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_GyroRollOverride);
            MyTextsWrapper.m_sb[1284] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_GyroYawOverride);
            MyTextsWrapper.m_sb[1285] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_GyroPitchOverride);
            MyTextsWrapper.m_sb[1286] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_GyroRollOverride);
            MyTextsWrapper.m_sb[1287] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_GyroYawOverride);
            MyTextsWrapper.m_sb[1288] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_ToolbarDown);
            MyTextsWrapper.m_sb[1289] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_ToolbarUp);
            MyTextsWrapper.m_sb[1290] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertiesText_PistonCurrentPosition);
            MyTextsWrapper.m_sb[1291] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudEnergyGroupBatteries);
            MyTextsWrapper.m_sb[1292] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockActionTitle_SwitchLock);
            MyTextsWrapper.m_sb[1293] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Description_Animation_Wave);
            MyTextsWrapper.m_sb[1294] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Animation_Wave);
            MyTextsWrapper.m_sb[1295] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DialogTextDownloadModsFailed);
            MyTextsWrapper.m_sb[1296] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgressTextCheckingMods);
            MyTextsWrapper.m_sb[1297] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugOfficial_Caption);
            MyTextsWrapper.m_sb[1298] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugOfficial_EnableDebugDraw);
            MyTextsWrapper.m_sb[1299] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugOfficial_ErrorLogCaption);
            MyTextsWrapper.m_sb[1300] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugOfficial_ModelDummies);
            MyTextsWrapper.m_sb[1301] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugOfficial_MountPoints);
            MyTextsWrapper.m_sb[1302] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugOfficial_NoErrorText);
            MyTextsWrapper.m_sb[1303] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugOfficial_PhysicsPrimitives);
            MyTextsWrapper.m_sb[1304] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_ShowShipName);
            MyTextsWrapper.m_sb[1305] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_ShowShipName);
            MyTextsWrapper.m_sb[1306] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BroadcastStatus_Connected);
            MyTextsWrapper.m_sb[1307] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BroadcastStatus_OutOfBroadcastingRange);
            MyTextsWrapper.m_sb[1308] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BroadcastStatus_OutOfReceivingRange);
            MyTextsWrapper.m_sb[1309] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenTerminalError_ShipHasBeenDisconnected);
            MyTextsWrapper.m_sb[1310] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.CustomShipName_LargeShip);
            MyTextsWrapper.m_sb[1311] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.CustomShipName_MediumShip);
            MyTextsWrapper.m_sb[1312] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.CustomShipName_SmallShip);
            MyTextsWrapper.m_sb[1313] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugOfficial_OpenErrorLog);
            MyTextsWrapper.m_sb[1314] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugOfficial_ReloadTextures);
            MyTextsWrapper.m_sb[1315] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BroadcastStatus_PhysicallyConnected);
            MyTextsWrapper.m_sb[1316] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DialogTextLocalModsDisabledInMultiplayer);
            MyTextsWrapper.m_sb[1317] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMods_LocalMod);
            MyTextsWrapper.m_sb[1318] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMods_MissingDetails);
            MyTextsWrapper.m_sb[1319] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMods_MissingLocalMod);
            MyTextsWrapper.m_sb[1320] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMods_WorkshopMod);
            MyTextsWrapper.m_sb[1321] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockOwner_Unknown);
            MyTextsWrapper.m_sb[1322] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugOfficial_ReloadModels);
            MyTextsWrapper.m_sb[1323] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugOfficial_CopyErrorLogToClipboard);
            MyTextsWrapper.m_sb[1324] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationLeavingWorld_Creative);
            MyTextsWrapper.m_sb[1325] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.PlayerCharacterModel);
            MyTextsWrapper.m_sb[1326] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_ColumnTitle_Mods);
            MyTextsWrapper.m_sb[1327] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHintPressToOpenButtonPanel);
            MyTextsWrapper.m_sb[1328] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHintPressToUse);
            MyTextsWrapper.m_sb[1329] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_GravityFieldRadius);
            MyTextsWrapper.m_sb[1330] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_GravityFieldRadius);
            MyTextsWrapper.m_sb[1331] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_GravityGeneratorSphere);
            MyTextsWrapper.m_sb[1332] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BroadcastStatus_Me);
            MyTextsWrapper.m_sb[1333] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenTerminal_ShipList);
            MyTextsWrapper.m_sb[1334] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.CustomShipName_Platform);
            MyTextsWrapper.m_sb[1335] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoNameBroadcastRange);
            MyTextsWrapper.m_sb[1336] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyText_AnyoneCanUse);
            MyTextsWrapper.m_sb[1337] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_AnyoneCanUse);
            MyTextsWrapper.m_sb[1338] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DefinitionError_BlockWithComputerNotTerminalBlock);
            MyTextsWrapper.m_sb[1339] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_SelectServerToShowModList);
            MyTextsWrapper.m_sb[1340] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_ButtonPanel);
            MyTextsWrapper.m_sb[1341] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMods_SearchLabel);
            MyTextsWrapper.m_sb[1342] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_BadModsListResponse);
            MyTextsWrapper.m_sb[1343] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SpawnInSpaceSuit);
            MyTextsWrapper.m_sb[1344] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudWarnings);
            MyTextsWrapper.m_sb[1345] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NPCIdentityAdded);
            MyTextsWrapper.m_sb[1346] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DialogTextIncompatibleWorldVersion);
            MyTextsWrapper.m_sb[1347] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextPublishFailed_AccessDenied);
            MyTextsWrapper.m_sb[1348] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugOfficial_SavePrefab);
            MyTextsWrapper.m_sb[1349] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipSaveShip);
            MyTextsWrapper.m_sb[1350] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.AddNewNPC);
            MyTextsWrapper.m_sb[1351] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_BlueprintClass_Components);
            MyTextsWrapper.m_sb[1352] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_BlueprintClass_LargeBlocks);
            MyTextsWrapper.m_sb[1353] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_BlueprintClass_SmallBlocks);
            MyTextsWrapper.m_sb[1354] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_BlueprintClass_Tools);
            MyTextsWrapper.m_sb[1355] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCaptionWorkshopTags);
            MyTextsWrapper.m_sb[1356] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorkshopTag_Animation);
            MyTextsWrapper.m_sb[1357] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorkshopTag_Block);
            MyTextsWrapper.m_sb[1358] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorkshopTag_Character);
            MyTextsWrapper.m_sb[1359] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorkshopTag_Other);
            MyTextsWrapper.m_sb[1360] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorkshopTag_Skybox);
            MyTextsWrapper.m_sb[1361] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockActionTitle_View);
            MyTextsWrapper.m_sb[1362] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Camera);
            MyTextsWrapper.m_sb[1363] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextPublishFailed_OwnerMismatchMod);
            MyTextsWrapper.m_sb[1364] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.LoadingError_ModifiedOriginalContent);
            MyTextsWrapper.m_sb[1365] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_BroadcastUsingAntennas);
            MyTextsWrapper.m_sb[1366] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxErrorModLoadingFailure);
            MyTextsWrapper.m_sb[1367] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipItemFilter_GenericProductionBlockInput);
            MyTextsWrapper.m_sb[1368] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipItemFilter_GenericProductionBlockOutput);
            MyTextsWrapper.m_sb[1369] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.RenderIterpolation);
            MyTextsWrapper.m_sb[1370] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipVideoOptionRenderIterpolation);
            MyTextsWrapper.m_sb[1371] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorkshopTag_Production);
            MyTextsWrapper.m_sb[1372] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorkshopTag_RespawnShip);
            MyTextsWrapper.m_sb[1373] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationHintPressToExitCamera);
            MyTextsWrapper.m_sb[1374] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorkshopTag_ModPack);
            MyTextsWrapper.m_sb[1375] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Arc_Furnace);
            MyTextsWrapper.m_sb[1376] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugSpawnMenu_Caption);
            MyTextsWrapper.m_sb[1377] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugSpawnMenu_SpawnAsteroid);
            MyTextsWrapper.m_sb[1378] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SensorFieldDepthMax);
            MyTextsWrapper.m_sb[1379] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SensorFieldDepthMin);
            MyTextsWrapper.m_sb[1380] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SensorFieldHeightMax);
            MyTextsWrapper.m_sb[1381] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SensorFieldHeightMin);
            MyTextsWrapper.m_sb[1382] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SensorFieldWidthMax);
            MyTextsWrapper.m_sb[1383] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SensorFieldWidthMin);
            MyTextsWrapper.m_sb[1384] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Sensor);
            MyTextsWrapper.m_sb[1385] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_LightBlinkInterval);
            MyTextsWrapper.m_sb[1386] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_LightBlinkLenght);
            MyTextsWrapper.m_sb[1387] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_LightBlinkOffset);
            MyTextsWrapper.m_sb[1388] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_LightBlinkInterval);
            MyTextsWrapper.m_sb[1389] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_LightBlinkLenght);
            MyTextsWrapper.m_sb[1390] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_LightBlinkOffset);
            MyTextsWrapper.m_sb[1391] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalControlPanel_Warhead_DetonationTime);
            MyTextsWrapper.m_sb[1392] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalControlPanel_Warhead_StartCountdown);
            MyTextsWrapper.m_sb[1393] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalControlPanel_Warhead_StopCountdown);
            MyTextsWrapper.m_sb[1394] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalControlPanel_Warhead_Safety);
            MyTextsWrapper.m_sb[1395] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalControlPanel_Warhead_Detonate);
            MyTextsWrapper.m_sb[1396] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalControlPanel_Warhead_SwitchTextArmed);
            MyTextsWrapper.m_sb[1397] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalControlPanel_Warhead_SwitchTextDisarmed);
            MyTextsWrapper.m_sb[1398] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_SensorToolbarOpen);
            MyTextsWrapper.m_sb[1399] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SensorToolbarOpen);
            MyTextsWrapper.m_sb[1400] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SensorDetectFloatingObjects);
            MyTextsWrapper.m_sb[1401] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SensorDetectLargeShips);
            MyTextsWrapper.m_sb[1402] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SensorDetectPlayers);
            MyTextsWrapper.m_sb[1403] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SensorDetectSmallShips);
            MyTextsWrapper.m_sb[1404] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_SensorFieldBack);
            MyTextsWrapper.m_sb[1405] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_SensorFieldBottom);
            MyTextsWrapper.m_sb[1406] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_SensorFieldFront);
            MyTextsWrapper.m_sb[1407] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_SensorFieldLeft);
            MyTextsWrapper.m_sb[1408] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_SensorFieldRight);
            MyTextsWrapper.m_sb[1409] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_SensorFieldTop);
            MyTextsWrapper.m_sb[1410] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalControlPanel_Warhead_SafetyTooltip);
            MyTextsWrapper.m_sb[1411] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SensorDetectStations);
            MyTextsWrapper.m_sb[1412] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.CustomText);
            MyTextsWrapper.m_sb[1413] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Info_ShowGravityGizmo);
            MyTextsWrapper.m_sb[1414] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Info_ShowSenzorGizmo);
            MyTextsWrapper.m_sb[1415] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlRemote);
            MyTextsWrapper.m_sb[1416] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_RemoteControl);
            MyTextsWrapper.m_sb[1417] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_TimerBlock);
            MyTextsWrapper.m_sb[1418] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_TimerToolbarOpen);
            MyTextsWrapper.m_sb[1419] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_TimerTrigger);
            MyTextsWrapper.m_sb[1420] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalControlPanel_TimerDelay);
            MyTextsWrapper.m_sb[1421] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_TimerStart);
            MyTextsWrapper.m_sb[1422] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_TimerStop);
            MyTextsWrapper.m_sb[1423] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_TimerToTrigger);
            MyTextsWrapper.m_sb[1424] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCubeBuilderBlockCategories);
            MyTextsWrapper.m_sb[1425] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenCubeBuilderBlockSearch);
            MyTextsWrapper.m_sb[1426] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_SmallRocketLauncherReload);
            MyTextsWrapper.m_sb[1427] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Category_AllBlocks);
            MyTextsWrapper.m_sb[1428] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Category_ShipGroups);
            MyTextsWrapper.m_sb[1429] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Category_ArmorBlocks);
            MyTextsWrapper.m_sb[1430] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Category_CharacterAnimations);
            MyTextsWrapper.m_sb[1431] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Category_CharacterTools);
            MyTextsWrapper.m_sb[1432] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Category_ConveyorBlocks);
            MyTextsWrapper.m_sb[1433] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Category_ShipLights);
            MyTextsWrapper.m_sb[1434] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Category_ShipThrusters);
            MyTextsWrapper.m_sb[1435] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Category_ShipWeaponsTools);
            MyTextsWrapper.m_sb[1436] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Category_WindowBlocks);
            MyTextsWrapper.m_sb[1437] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Category_LargeBlocks);
            MyTextsWrapper.m_sb[1438] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Category_SmallBlocks);
            MyTextsWrapper.m_sb[1439] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_RespawnShip_Assembler);
            MyTextsWrapper.m_sb[1440] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_RespawnShip_EscapePod);
            MyTextsWrapper.m_sb[1441] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_RespawnShip_RefineryAssembler);
            MyTextsWrapper.m_sb[1442] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_RespawnShip_ShipDrill);
            MyTextsWrapper.m_sb[1443] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_RespawnShip_Yellow);
            MyTextsWrapper.m_sb[1444] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMedicals_OwnerTimeoutColumn);
            MyTextsWrapper.m_sb[1445] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMedicals_RespawnInfoMessageRow1);
            MyTextsWrapper.m_sb[1446] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMedicals_RespawnInfoMessageRow2);
            MyTextsWrapper.m_sb[1447] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMedicals_RespawnShipReady);
            MyTextsWrapper.m_sb[1448] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenMedicals_RespawnShipNotReady);
            MyTextsWrapper.m_sb[1449] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Info_ShowAntenaGizmo);
            MyTextsWrapper.m_sb[1450] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_AsteroidAmountNone);
            MyTextsWrapper.m_sb[1451] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_RespawnShipCooldown);
            MyTextsWrapper.m_sb[1452] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_RespawnShip_Default);
            MyTextsWrapper.m_sb[1453] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_RespawnShip_x01);
            MyTextsWrapper.m_sb[1454] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_RespawnShip_x02);
            MyTextsWrapper.m_sb[1455] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_RespawnShip_x05);
            MyTextsWrapper.m_sb[1456] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_RespawnShip_x10);
            MyTextsWrapper.m_sb[1457] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_RespawnShip_x100);
            MyTextsWrapper.m_sb[1458] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_RespawnShip_x2);
            MyTextsWrapper.m_sb[1459] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_RespawnShip_x20);
            MyTextsWrapper.m_sb[1460] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_RespawnShip_x5);
            MyTextsWrapper.m_sb[1461] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_RespawnShip_x50);
            MyTextsWrapper.m_sb[1462] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlDescCopyPasteMove);
            MyTextsWrapper.m_sb[1463] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_RespawnShip_CooldownsDisabled);
            MyTextsWrapper.m_sb[1464] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_FighterCockpit);
            MyTextsWrapper.m_sb[1465] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SensorDetectAsteroids);
            MyTextsWrapper.m_sb[1466] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Category_Cockpit);
            MyTextsWrapper.m_sb[1467] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorkshopTag_Script);
            MyTextsWrapper.m_sb[1468] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationCopyPasteBlockNotAvailable);
            MyTextsWrapper.m_sb[1469] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ConvertingObjs);
            MyTextsWrapper.m_sb[1470] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ConvertToObjDone);
            MyTextsWrapper.m_sb[1471] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ExportingToObj);
            MyTextsWrapper.m_sb[1472] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Category_Power);
            MyTextsWrapper.m_sb[1473] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Category_Production);
            MyTextsWrapper.m_sb[1474] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugSpawnMenu_ItemAmount);
            MyTextsWrapper.m_sb[1475] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugSpawnMenu_ItemType);
            MyTextsWrapper.m_sb[1476] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugSpawnMenu_SpawnObject);
            MyTextsWrapper.m_sb[1477] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextDoYouWantToPasteGridWithMissingBlocks);
            MyTextsWrapper.m_sb[1478] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugSpawnMenu_Asteroids);
            MyTextsWrapper.m_sb[1479] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugSpawnMenu_Items);
            MyTextsWrapper.m_sb[1480] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationCopyPasteFloatingObjectNotAvailable);
            MyTextsWrapper.m_sb[1481] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugSpawnMenu_Asteroid);
            MyTextsWrapper.m_sb[1482] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugSpawnMenu_AsteroidAddRandomMaterials);
            MyTextsWrapper.m_sb[1483] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugSpawnMenu_AsteroidCoreMaterial);
            MyTextsWrapper.m_sb[1484] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugSpawnMenu_AsteroidSurfaceMaterial);
            MyTextsWrapper.m_sb[1485] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Assembler_SlaveMode);
            MyTextsWrapper.m_sb[1486] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ShipWelder_HelpOthers);
            MyTextsWrapper.m_sb[1487] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Ammo_Assembler);
            MyTextsWrapper.m_sb[1488] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Base_Components_Assembler);
            MyTextsWrapper.m_sb[1489] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Big_Arc_Furnace);
            MyTextsWrapper.m_sb[1490] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Big_Gas_Centrifugal_Refinery);
            MyTextsWrapper.m_sb[1491] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Big_Precious_Furnace);
            MyTextsWrapper.m_sb[1492] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Big_Solids_Refinery);
            MyTextsWrapper.m_sb[1493] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Construction_Components_Assembler);
            MyTextsWrapper.m_sb[1494] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Electronics_Assembler);
            MyTextsWrapper.m_sb[1495] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_BlueprintClass_Ammo);
            MyTextsWrapper.m_sb[1496] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_BlueprintClass_Base_Components);
            MyTextsWrapper.m_sb[1497] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_BlueprintClass_CommonMetals);
            MyTextsWrapper.m_sb[1498] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_BlueprintClass_Construction_Components);
            MyTextsWrapper.m_sb[1499] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_BlueprintClass_Electronics);
            MyTextsWrapper.m_sb[1500] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_BlueprintClass_EnergeticIngots);
            MyTextsWrapper.m_sb[1501] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_BlueprintClass_Ingots);
            MyTextsWrapper.m_sb[1502] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_BlueprintClass_PreciousMetals);
            MyTextsWrapper.m_sb[1503] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_BlueprintClass_Solids);
            MyTextsWrapper.m_sb[1504] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MessageBoxTextAreYouSureToRemoveAsteroid);
            MyTextsWrapper.m_sb[1505] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugSpawnMenu_AsteroidGenerationCanTakeLong);
            MyTextsWrapper.m_sb[1506] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Antenna_EnableBroadcast);
            MyTextsWrapper.m_sb[1507] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlName_Broadcasting);
            MyTextsWrapper.m_sb[1508] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.LargeMissileTurretReloadingNotification);
            MyTextsWrapper.m_sb[1509] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.HudInfoBroadcasting);
            MyTextsWrapper.m_sb[1510] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationCharacterBroadcastingOff);
            MyTextsWrapper.m_sb[1511] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationCharacterBroadcastingOn);
            MyTextsWrapper.m_sb[1512] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationCopyPasteAsteroidObstructed);
            MyTextsWrapper.m_sb[1513] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_AdvancedRotor);
            MyTextsWrapper.m_sb[1514] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_AdvancedRotorPart);
            MyTextsWrapper.m_sb[1515] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugSpawnMenu_InvalidAmount);
            MyTextsWrapper.m_sb[1516] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.PlacingObjectsToScene);
            MyTextsWrapper.m_sb[1517] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ControlTypeSystems3);
            MyTextsWrapper.m_sb[1518] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipTerminalProduction_SlaveMode);
            MyTextsWrapper.m_sb[1519] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugSpawnMenu_PredefinedAsteroids);
            MyTextsWrapper.m_sb[1520] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugSpawnMenu_ProceduralAsteroids);
            MyTextsWrapper.m_sb[1521] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugSpawnMenu_ProceduralSeed);
            MyTextsWrapper.m_sb[1522] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugSpawnMenu_ProceduralSize);
            MyTextsWrapper.m_sb[1523] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugSpawnMenu_SelectAsteroidType);
            MyTextsWrapper.m_sb[1524] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationSwitchedToWeapon);
            MyTextsWrapper.m_sb[1525] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipItemFilter_AmmoMagazineInput);
            MyTextsWrapper.m_sb[1526] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockActionTitle_Detach);
            MyTextsWrapper.m_sb[1527] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockActionTitle_Attach);
            MyTextsWrapper.m_sb[1528] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Thrust_Back);
            MyTextsWrapper.m_sb[1529] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Thrust_Down);
            MyTextsWrapper.m_sb[1530] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Thrust_Forward);
            MyTextsWrapper.m_sb[1531] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Thrust_Left);
            MyTextsWrapper.m_sb[1532] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Thrust_Right);
            MyTextsWrapper.m_sb[1533] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Thrust_Up);
            MyTextsWrapper.m_sb[1534] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Notification_NoControl);
            MyTextsWrapper.m_sb[1535] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Notification_NoControlStation);
            MyTextsWrapper.m_sb[1536] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.MissileLauncherReloadingNotification);
            MyTextsWrapper.m_sb[1537] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_ProjectionOffsetX);
            MyTextsWrapper.m_sb[1538] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_ProjectionOffsetY);
            MyTextsWrapper.m_sb[1539] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_ProjectionOffsetZ);
            MyTextsWrapper.m_sb[1540] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_ProjectionRotationX);
            MyTextsWrapper.m_sb[1541] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_ProjectionRotationY);
            MyTextsWrapper.m_sb[1542] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_ProjectionRotationZ);
            MyTextsWrapper.m_sb[1543] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_Projector);
            MyTextsWrapper.m_sb[1544] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationProjectorGridSize);
            MyTextsWrapper.m_sb[1545] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationProjectorMultipleGrids);
            MyTextsWrapper.m_sb[1546] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SelectBlueprint);
            MyTextsWrapper.m_sb[1547] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Info_PivotBtn);
            MyTextsWrapper.m_sb[1548] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Animation_Facepalm);
            MyTextsWrapper.m_sb[1549] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Animation_ThumbUp);
            MyTextsWrapper.m_sb[1550] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Animation_Victory);
            MyTextsWrapper.m_sb[1551] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_ControlPanel);
            MyTextsWrapper.m_sb[1552] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_SteelCatwalkCorner);
            MyTextsWrapper.m_sb[1553] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_SteelCatwalkPlate);
            MyTextsWrapper.m_sb[1554] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_SteelCatwalkTwoSides);
            MyTextsWrapper.m_sb[1555] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.AvailableBlueprints);
            MyTextsWrapper.m_sb[1556] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeepProjectionToggle);
            MyTextsWrapper.m_sb[1557] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.KeepProjectionTooltip);
            MyTextsWrapper.m_sb[1558] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.RemoveProjectionButton);
            MyTextsWrapper.m_sb[1559] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_SpaceBall);
            MyTextsWrapper.m_sb[1560] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Category_VoxelHands);
            MyTextsWrapper.m_sb[1561] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_SpaceBallFriction);
            MyTextsWrapper.m_sb[1562] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_SpaceBallVirtualMass);
            MyTextsWrapper.m_sb[1563] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_SoundBlockRange);
            MyTextsWrapper.m_sb[1564] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_SoundBlockVolume);
            MyTextsWrapper.m_sb[1565] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SoundBlockRange);
            MyTextsWrapper.m_sb[1566] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SoundBlockVolume);
            MyTextsWrapper.m_sb[1567] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Block_SoundBlock);
            MyTextsWrapper.m_sb[1568] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_VoxelHand_Box);
            MyTextsWrapper.m_sb[1569] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_VoxelHand_Sphere);
            MyTextsWrapper.m_sb[1570] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.VoxelHandProperty_Sphere_Radius);
            MyTextsWrapper.m_sb[1571] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.VoxelHandProperty_Box_Width);
            MyTextsWrapper.m_sb[1572] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.VoxelHandProperty_Box_Depth);
            MyTextsWrapper.m_sb[1573] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.VoxelHandProperty_Box_Height);
            MyTextsWrapper.m_sb[1574] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsLimitWorldSize);
            MyTextsWrapper.m_sb[1575] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_WorldSize100Km);
            MyTextsWrapper.m_sb[1576] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_WorldSize10Km);
            MyTextsWrapper.m_sb[1577] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_WorldSize20Km);
            MyTextsWrapper.m_sb[1578] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_WorldSize50Km);
            MyTextsWrapper.m_sb[1579] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_WorldSizeUnlimited);
            MyTextsWrapper.m_sb[1580] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_WorldSizeCustom);
            MyTextsWrapper.m_sb[1581] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.VoxelHandSettingScreen_HandDistance);
            MyTextsWrapper.m_sb[1582] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SoundBlockLoopTime);
            MyTextsWrapper.m_sb[1583] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SoundBlockPlay);
            MyTextsWrapper.m_sb[1584] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SoundBlockSoundList);
            MyTextsWrapper.m_sb[1585] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SoundBlockStop);
            MyTextsWrapper.m_sb[1586] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertiesText_LoopTimer);
            MyTextsWrapper.m_sb[1587] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.VoxelHandSettingScreen_HandSettings);
            MyTextsWrapper.m_sb[1588] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.VoxelHandSettingScreen_HandTransparency);
            MyTextsWrapper.m_sb[1589] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.VoxelHandSettingScreen_ShapeSettings);
            MyTextsWrapper.m_sb[1590] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_VoxelHand_AutoLevel);
            MyTextsWrapper.m_sb[1591] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_VoxelHand_Capsule);
            MyTextsWrapper.m_sb[1592] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.VoxelHandProperty_Capsule_Length);
            MyTextsWrapper.m_sb[1593] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.VoxelHandProperty_Capsule_Radius);
            MyTextsWrapper.m_sb[1594] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SoundBlock_SoundName_Alert1);
            MyTextsWrapper.m_sb[1595] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SoundBlock_SoundName_Alert2);
            MyTextsWrapper.m_sb[1596] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SoundBlock_SoundName_Alert3);
            MyTextsWrapper.m_sb[1597] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SoundBlock_SoundName_EnemyDetected);
            MyTextsWrapper.m_sb[1598] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SoundBlock_SoundName_LightsOff);
            MyTextsWrapper.m_sb[1599] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SoundBlock_SoundName_LightsOn);
            MyTextsWrapper.m_sb[1600] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SoundBlock_SoundName_Music1);
            MyTextsWrapper.m_sb[1601] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SoundBlock_SoundName_Music2);
            MyTextsWrapper.m_sb[1602] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.SoundBlock_SoundName_ObjectiveComplete);
            MyTextsWrapper.m_sb[1603] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalControlPanel_EditCode);
            MyTextsWrapper.m_sb[1604] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalControlPanel_RunCode);
            MyTextsWrapper.m_sb[1605] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ExportToObjModded);
            MyTextsWrapper.m_sb[1606] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_VoxelHand_Ramp);
            MyTextsWrapper.m_sb[1607] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.VoxelHandSettingScreen_HandSnapToVoxel);
            MyTextsWrapper.m_sb[1608] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.VoxelHandProperty_AutoLevel_Area);
            MyTextsWrapper.m_sb[1609] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.VoxelHandProperty_AutoLevel_Axis);
            MyTextsWrapper.m_sb[1610] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.VoxelHandProperty_AutoLevel_AxisX);
            MyTextsWrapper.m_sb[1611] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.VoxelHandProperty_AutoLevel_AxisY);
            MyTextsWrapper.m_sb[1612] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.VoxelHandProperty_AutoLevel_AxisZ);
            MyTextsWrapper.m_sb[1613] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.VoxelHandSettingScreen_HandMaterial);
            MyTextsWrapper.m_sb[1614] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_AsteroidAmountProceduralHigh);
            MyTextsWrapper.m_sb[1615] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_AsteroidAmountProceduralLow);
            MyTextsWrapper.m_sb[1616] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_AsteroidAmountProceduralNormal);
            MyTextsWrapper.m_sb[1617] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsDestructibleBlocks);
            MyTextsWrapper.m_sb[1618] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_DestructibleBlocks);
            MyTextsWrapper.m_sb[1619] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorkshopTag_Exploration);
            MyTextsWrapper.m_sb[1620] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.DisplayName_Programmable_Block);
            MyTextsWrapper.m_sb[1621] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_CodeChanged);
            MyTextsWrapper.m_sb[1622] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_CodeEditor_SaveExit);
            MyTextsWrapper.m_sb[1623] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_CodeEditor_Title);
            MyTextsWrapper.m_sb[1624] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_Exception_AllreadyRunning);
            MyTextsWrapper.m_sb[1625] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_Exception_ExceptionCaught);
            MyTextsWrapper.m_sb[1626] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_Exception_NoAssembly);
            MyTextsWrapper.m_sb[1627] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_Exception_NoMain);
            MyTextsWrapper.m_sb[1628] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_Exception_TooComplex);
            MyTextsWrapper.m_sb[1629] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_SaveChanges);
            MyTextsWrapper.m_sb[1630] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalControlPanel_EditCode_Tooltip);
            MyTextsWrapper.m_sb[1631] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalControlPanel_RunCode_Tooltip);
            MyTextsWrapper.m_sb[1632] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_CodeEditor_SaveExit_Tooltip);
            MyTextsWrapper.m_sb[1633] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_Editor_BrowseWorkshop_Tooltip);
            MyTextsWrapper.m_sb[1634] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_Editor_CheckCode);
            MyTextsWrapper.m_sb[1635] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_Editor_CheckCode_Tooltip);
            MyTextsWrapper.m_sb[1636] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_Editor_CompilationFailed);
            MyTextsWrapper.m_sb[1637] =
                (MyTextsWrapper.TextInfo)
                    new StringBuilder(MyTexts.ProgrammableBlock_Editor_CompilationFailedErrorFormat);
            MyTextsWrapper.m_sb[1638] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_Editor_CompilationFailedErrorList);
            MyTextsWrapper.m_sb[1639] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_Editor_CompilationOk);
            MyTextsWrapper.m_sb[1640] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_Editor_LineNo);
            MyTextsWrapper.m_sb[1641] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_Editor_RememberCode);
            MyTextsWrapper.m_sb[1642] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_Editor_RememberCode_Tooltip);
            MyTextsWrapper.m_sb[1643] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_ButtonCreateFromEditor);
            MyTextsWrapper.m_sb[1644] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_ButtonDetails);
            MyTextsWrapper.m_sb[1645] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_ButtonRefreshScripts);
            MyTextsWrapper.m_sb[1646] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_ButtonRename);
            MyTextsWrapper.m_sb[1647] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_ButtonReplaceFromEditor);
            MyTextsWrapper.m_sb[1648] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_NewScriptName);
            MyTextsWrapper.m_sb[1649] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_OpenInWorkshop);
            MyTextsWrapper.m_sb[1650] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_PublishScriptDialogText);
            MyTextsWrapper.m_sb[1651] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_PublishScriptPublished);
            MyTextsWrapper.m_sb[1652] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_ReplaceScriptDialogText);
            MyTextsWrapper.m_sb[1653] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_ReplaceScriptNameDialogText);
            MyTextsWrapper.m_sb[1654] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_ReplaceScriptNameDialogTitle);
            MyTextsWrapper.m_sb[1655] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_ReplaceScriptNameUsed);
            MyTextsWrapper.m_sb[1656] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_ScriptNotFound);
            MyTextsWrapper.m_sb[1657] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_ScriptsScreenTitle);
            MyTextsWrapper.m_sb[1658] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_Editor_Help);
            MyTextsWrapper.m_sb[1659] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_Editor_HelpTooltip);
            MyTextsWrapper.m_sb[1660] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_DeleteScriptDialogText);
            MyTextsWrapper.m_sb[1661] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_Exception_NotAllowed);
            MyTextsWrapper.m_sb[1662] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_EnableIngameScripts);
            MyTextsWrapper.m_sb[1663] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SensorDetectEnemy);
            MyTextsWrapper.m_sb[1664] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SensorDetectFriendly);
            MyTextsWrapper.m_sb[1665] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SensorDetectOwner);
            MyTextsWrapper.m_sb[1666] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyTitle_SensorDetectNeutral);
            MyTextsWrapper.m_sb[1667] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ProgrammableBlock_Exception_Ownershipchanged);
            MyTextsWrapper.m_sb[1668] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationNewFactionChatMessage);
            MyTextsWrapper.m_sb[1669] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationNewGlobalChatMessage);
            MyTextsWrapper.m_sb[1670] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.NotificationNewPlayerChatMessage);
            MyTextsWrapper.m_sb[1671] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Chat_GlobalChat);
            MyTextsWrapper.m_sb[1672] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Chat);
            MyTextsWrapper.m_sb[1673] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ErrorDescriptionTooLong);
            MyTextsWrapper.m_sb[1674] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.Description);
            MyTextsWrapper.m_sb[1675] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_ViewDistance);
            MyTextsWrapper.m_sb[1676] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_ViewDistance_10_Km);
            MyTextsWrapper.m_sb[1677] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_ViewDistance_15_Km);
            MyTextsWrapper.m_sb[1678] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_ViewDistance_20_Km);
            MyTextsWrapper.m_sb[1679] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_ViewDistance_30_Km);
            MyTextsWrapper.m_sb[1680] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_ViewDistance_40_Km);
            MyTextsWrapper.m_sb[1681] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_ViewDistance_50_Km);
            MyTextsWrapper.m_sb[1682] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_ViewDistance_5_Km);
            MyTextsWrapper.m_sb[1683] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_ViewDistance_7_Km);
            MyTextsWrapper.m_sb[1684] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.WorldSettings_ViewDistance_Custom);
            MyTextsWrapper.m_sb[1685] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ToolTipWorldSettingsViewDistance);
            MyTextsWrapper.m_sb[1686] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.BlockPropertyDescription_SpaceBallRestitution);
            MyTextsWrapper.m_sb[1687] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TooltipScreenMods_Category_All);
            MyTextsWrapper.m_sb[1688] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TooltipScreenMods_Category_Animation);
            MyTextsWrapper.m_sb[1689] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TooltipScreenMods_Category_Block);
            MyTextsWrapper.m_sb[1690] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TooltipScreenMods_Category_Character);
            MyTextsWrapper.m_sb[1691] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TooltipScreenMods_Category_Modpack);
            MyTextsWrapper.m_sb[1692] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TooltipScreenMods_Category_Other);
            MyTextsWrapper.m_sb[1693] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TooltipScreenMods_Category_Production);
            MyTextsWrapper.m_sb[1694] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TooltipScreenMods_Category_RespawnShip);
            MyTextsWrapper.m_sb[1695] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TooltipScreenMods_Category_Script);
            MyTextsWrapper.m_sb[1696] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TooltipScreenMods_Category_Skybox);
            MyTextsWrapper.m_sb[1697] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TooltipScreenMods_SelectCategories);
            MyTextsWrapper.m_sb[1698] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.ScreenDebugSpawnMenu_GenerateSeed);
            MyTextsWrapper.m_sb[1699] =
                (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.JoinGame_GameTypeToolTip_ViewDistance);
            MyTextsWrapper.m_sb[1700] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Chat_NoFaction);
            MyTextsWrapper.m_sb[1701] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Chat_Offline);
            MyTextsWrapper.m_sb[1702] = (MyTextsWrapper.TextInfo) new StringBuilder(MyTexts.TerminalTab_Chat_Pending);
        }

        private struct TextInfo
        {
            public StringBuilder StringBuilder;
            public string String;

            public static implicit operator MyTextsWrapper.TextInfo(StringBuilder stringBuilder)
            {
                return new MyTextsWrapper.TextInfo()
                {
                    StringBuilder = stringBuilder,
                    String = ((object) stringBuilder).ToString()
                };
            }
        }
    }
}