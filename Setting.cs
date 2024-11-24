using ColorAdjustmentsMod.XML;
using Colossal;
using Colossal.IO.AssetDatabase;
using Game.Modding;
using Game.Rendering;
using Game.Settings;
using Game.UI;
using Game.UI.Widgets;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using Unity.Entities;
using static System.Net.WebRequestMethods;

namespace RenderMastery
{
    [FileLocation(nameof(RenderMastery))]
    [SettingsUIGroupOrder(kToggleGroup, kSliderGroup, kDropdownGroup, kButtonGroup)]
    [SettingsUITabOrder(kBasicTab, kSection)]
    [SettingsUIShowGroupName(kToggleGroup, kSliderGroup, kDropdownGroup,kBasicGroup, kButtonGroup)]
    public class Setting : ModSetting
    {
        public const string kSection = "Main";
        public string SettingsPath = GlobalVariables.SettingsPath();
        public const string kButtonGroup = "Button";
        public const string kToggleGroup = "Toggle";
        public const string kSliderGroup = "Slider";
        public const string kDropdownGroup = "Dropdown";


        public const string kBasicTab = "Basic";
        public const string kBasicGroup = "Basic Settings";

        public Setting(IMod mod) : base(mod)
        {

        }

        [SettingsUISection(kBasicTab, kBasicGroup)]
        [SettingsUIMultilineText("https://raw.githubusercontent.com/NyokoDev/LuminaCS2/refs/heads/master/HTTP/Lumina.svg")]
        public string LuminaByNyoko => string.Empty;

        [SettingsUISection(kBasicTab, kBasicGroup)]
        public bool UseRenderMastery
        {
            get => GlobalVariables.Instance.UseRenderMastery;
            set => GlobalVariables.Instance.UseRenderMastery = value;
        }


        [SettingsUISlider(min = -100, max = 300, step = 1, scalarMultiplier = 1, unit = Unit.kInteger)]
        [SettingsUISection(kSection, kSliderGroup)]
        public int AdaptiveDynamicResolutionScale
        {
            get => GlobalVariables.Instance.DynamicResScale;
            set => GlobalVariables.Instance.DynamicResScale = value;
        }

        [SettingsUISlider(min = -100, max = 300, step = 1, scalarMultiplier = 1, unit = Unit.kInteger)]
        [SettingsUISection(kSection, kSliderGroup)]
        public float levelOfDetail
        {
            get => GlobalVariables.Instance.levelOfDetail;
            set => GlobalVariables.Instance.levelOfDetail = value;
        }


        [SettingsUISlider(min = -100, max = 300, step = 1, scalarMultiplier = 1, unit = Unit.kInteger)]
        [SettingsUISection(kSection, kSliderGroup)]
        public int GlobalQualityLevel
        {
            get => GlobalVariables.Instance.GlobalQualityLevel;
            set => GlobalVariables.Instance.GlobalQualityLevel = value;
        }

        [SettingsUISlider(min = -100, max = 300, step = 1, scalarMultiplier = 1, unit = Unit.kInteger)]
        [SettingsUISection(kSection, kSliderGroup)]
        public int GlobalTextureMipmapLimit
        {
            get => GlobalVariables.Instance.GlobalTextureMipmapLimit;
            set => GlobalVariables.Instance.GlobalTextureMipmapLimit = value;
        }

        [SettingsUISlider(min = -100, max = 300, step = 1, scalarMultiplier = 1, unit = Unit.kInteger)]
        [SettingsUISection(kSection, kSliderGroup)]
        public int ShadowDistance
        {
            get => GlobalVariables.Instance.ShadowDistance;
            set => GlobalVariables.Instance.ShadowDistance = value;
        }

        [SettingsUISlider(min = -100, max = 300, step = 1, scalarMultiplier = 1, unit = Unit.kInteger)]
        [SettingsUISection(kSection, kSliderGroup)]
        public int ShadowCascades
        {
            get => GlobalVariables.Instance.ShadowCascades;
            set => GlobalVariables.Instance.ShadowCascades = value;
        }

        [SettingsUISlider(min = -100, max = 300, step = 1, scalarMultiplier = 1, unit = Unit.kInteger)]
        [SettingsUISection(kSection, kSliderGroup)]
        public int ShadowProjection
        {
            get => GlobalVariables.Instance.ShadowProjection;
            set => GlobalVariables.Instance.ShadowProjection = value;
        }

        [SettingsUISlider(min = -100, max = 300, step = 1, scalarMultiplier = 1, unit = Unit.kInteger)]
        [SettingsUISection(kSection, kSliderGroup)]
        public int ShadowNearPlaneOffset
        {
            get => GlobalVariables.Instance.ShadowNearPlaneOffset;
            set => GlobalVariables.Instance.ShadowNearPlaneOffset = value;
        }


        [SettingsUISection(kBasicTab, kBasicGroup)]
        public bool RealtimeReflectionProbes
        {
            get => GlobalVariables.Instance.RealtimeReflectionProbes;
            set => GlobalVariables.Instance.RealtimeReflectionProbes = value;
        }

        [SettingsUISection(kBasicTab, kBasicGroup)]
        public bool BillboardsFaceCameraPosition
        {
            get => GlobalVariables.Instance.BillboardsFaceCameraPosition;
            set => GlobalVariables.Instance.BillboardsFaceCameraPosition = value;
        }

        [SettingsUISlider(min = -100, max = 300, step = 1, scalarMultiplier = 1, unit = Unit.kInteger)]
        [SettingsUISection(kSection, kSliderGroup)]
        public int AntiAliasing
        {
            get => GlobalVariables.Instance.AntiAliasing;
            set => GlobalVariables.Instance.AntiAliasing = value;
        }

        [SettingsUISlider(min = -100, max = 300, step = 1, scalarMultiplier = 1, unit = Unit.kInteger)]
        [SettingsUISection(kSection, kSliderGroup)]
        public int AsyncUploadTimeSlice
        {
            get => GlobalVariables.Instance.AsyncUploadTimeSlice;
            set => GlobalVariables.Instance.AsyncUploadTimeSlice = value;
        }

        [SettingsUISlider(min = -100, max = 300, step = 1, scalarMultiplier = 1, unit = Unit.kInteger)]
        [SettingsUISection(kSection, kSliderGroup)]
        public int AsyncUploadBufferSize
        {
            get => GlobalVariables.Instance.AsyncUploadBufferSize;
            set => GlobalVariables.Instance.AsyncUploadBufferSize = value;
        }

        [SettingsUISlider(min = -100, max = 300, step = 1, scalarMultiplier = 1, unit = Unit.kInteger)]
        [SettingsUISection(kSection, kSliderGroup)]
        public int TerrainDetailDensityScale
        {
            get => GlobalVariables.Instance.TerrainDetailDensityScale;
            set => GlobalVariables.Instance.TerrainDetailDensityScale = value;
        }

        [SettingsUISlider(min = -100, max = 300, step = 1, scalarMultiplier = 1, unit = Unit.kInteger)]
        [SettingsUISection(kSection, kSliderGroup)]
        public int TerrainPixelError
        {
            get => GlobalVariables.Instance.TerrainPixelError;
            set => GlobalVariables.Instance.TerrainPixelError = value;
        }


        [SettingsUISlider(min = -100, max = 300, step = 1, scalarMultiplier = 1, unit = Unit.kInteger)]
        [SettingsUISection(kSection, kSliderGroup)]
        public float terrainBasemapDistance
        {
            get => GlobalVariables.Instance.terrainBasemapDistance;
            set => GlobalVariables.Instance.terrainBasemapDistance = value;
        }

        [SettingsUISlider(min = -100, max = 300, step = 1, scalarMultiplier = 1, unit = Unit.kInteger)]
        [SettingsUISection(kSection, kSliderGroup)]
        public float terrainDetailDistance
        {
            get => GlobalVariables.Instance.terrainDetailDistance;
            set => GlobalVariables.Instance.terrainDetailDistance = value;
        }

        [SettingsUISlider(min = -100, max = 300, step = 1, scalarMultiplier = 1, unit = Unit.kInteger)]
        [SettingsUISection(kSection, kSliderGroup)]
        public float terrainTreeDistance
        {
            get => GlobalVariables.Instance.terrainTreeDistance;
            set => GlobalVariables.Instance.terrainTreeDistance = value;
        }

        [SettingsUISlider(min = -100, max = 300, step = 1, scalarMultiplier = 1, unit = Unit.kInteger)]
        [SettingsUISection(kSection, kSliderGroup)]
        public float terrainBillboardStart
        {
            get => GlobalVariables.Instance.terrainBillboardStart;
            set => GlobalVariables.Instance.terrainBillboardStart = value;
        }

        [SettingsUISlider(min = -100, max = 300, step = 1, scalarMultiplier = 1, unit = Unit.kInteger)]
        [SettingsUISection(kSection, kSliderGroup)]
        public float terrainFadeLength
        {
            get => GlobalVariables.Instance.terrainFadeLength;
            set => GlobalVariables.Instance.terrainFadeLength = value;
        }

        [SettingsUISlider(min = -100, max = 300, step = 1, scalarMultiplier = 1, unit = Unit.kInteger)]
        [SettingsUISection(kSection, kSliderGroup)]
        public float terrainMaxTrees
        {
            get => GlobalVariables.Instance.terrainMaxTrees;
            set => GlobalVariables.Instance.terrainMaxTrees = value;
        }





        [SettingsUIConfirmation]
        [SettingsUIButton]
        [SettingsUISection(kSection, kButtonGroup)]
        public bool Button { set { SetFloatsAndIntsToOne(); ; } }

        [SettingsUIButton]
        [SettingsUISection(kSection, kButtonGroup)]
        public bool Support
        {
            set { OpenDiscordServerasProcess(); }
        }

        private void OpenDiscordServerasProcess()
        {
            // Discord server Path
            string discordPath = "https://discord.gg/5gZgRNm29e";

      
                // Start the Discord process
                Process.Start(discordPath);
            
      
        
    }

    private void SetFloatsAndIntsToOne()
        {
            // Use reflection to get all float and int properties
            PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (property.PropertyType == typeof(float))
                {
                    property.SetValue(this, 1f);
                }
                else if (property.PropertyType == typeof(int))
                {
                    property.SetValue(this, 1);
                }
                Mod.log.Info("Settings reset to default.");
                GlobalVariables.SaveToFile(SettingsPath);
            }
        
    }

    public override void Apply()
        {
            base.Apply();
            GlobalVariables.SaveToFile(SettingsPath);
        }



        public override void SetDefaults()
        {
            
        }

        public enum SomeEnum
        {
            Value1,
            Value2,
            Value3,
        }
    }

    

     
    }

