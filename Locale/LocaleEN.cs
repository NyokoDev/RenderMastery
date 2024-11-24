using Colossal;
using Game.Rendering.Utilities;
using Game.Settings;
using Game.UI.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenderMastery.Locale
{
    /// <summary>
    /// Represents the English locale for Render Mastery.
    /// </summary>
    public class LocaleEN : IDictionarySource
    {
        private readonly Setting m_Setting;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocaleEN"/> class with the specified setting.
        /// </summary>
        /// <param name="setting">The setting to use.</param>
        public LocaleEN(Setting setting)
        {
            m_Setting = setting;
        }

        /// <summary>
        /// Reads entries from the locale with possible errors and index counts.
        /// </summary>
        /// <param name="errors">List to capture any errors that occur.</param>
        /// <param name="indexCounts">Counts of entries indexed.</param>
        /// <returns>A collection of key-value pairs representing the locale entries.</returns>
        public IEnumerable<KeyValuePair<string, string>> ReadEntries(IList<IDictionaryEntryError> errors, Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.RenderMasteryByNyoko)), $"Render Mastery by Nyoko" },
                { m_Setting.GetSettingsLocaleID(), "Render Mastery" },
                { m_Setting.GetOptionTabLocaleID(Setting.kSection), "Advanced" },
                { m_Setting.GetOptionTabLocaleID(Setting.kBasicTab), "Basic Tab" },

                { m_Setting.GetOptionGroupLocaleID(Setting.kButtonGroup), "Render Mastery" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kToggleGroup), "Render Mastery" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kSliderGroup), "Render Mastery" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kDropdownGroup), "Render Mastery" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kBasicGroup), "RENDER MASTERY"  },

                // Button
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.Button)), "Reset settings" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.Button)), "This will reset Render Mastery's default settings." },
                { m_Setting.GetOptionWarningLocaleID(nameof(Setting.Button)), "This will reset Render Mastery's default settings. Wish to proceed?" },

                // Use Render Mastery
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.UseRenderMastery)), "Enable Render Mastery" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.UseRenderMastery)), "Enable or disable Render Mastery. Must enable this to utilize the rest of the functions." },


                // AdaptiveDynamicResolutionScale
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AdaptiveDynamicResolutionScale)), "Adaptive Dynamic Resolution Scale" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AdaptiveDynamicResolutionScale)), "Adjust the adaptive dynamic resolution scale." },

                // Level of Detail
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.levelOfDetail)), "Level of Detail" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.levelOfDetail)), "Force-tune and switch the level of detail settings." },

                // Global Quality Level
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.GlobalQualityLevel)), "Global Quality Level" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.GlobalQualityLevel)), "Adjust the global quality level of rendering." },

                // Global Texture Mipmap Limit
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.GlobalTextureMipmapLimit)), "Global Texture Mipmap Limit" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.GlobalTextureMipmapLimit)), "Set the global texture mipmap limit." },

                // Shadow Distance
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShadowDistance)), "Shadow Distance" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShadowDistance)), "Control the distance at which shadows are rendered." },

                // Shadow Cascades
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShadowCascades)), "Shadow Cascades" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShadowCascades)), "Adjust the number of shadow cascades." },

                // Shadow Projection
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShadowProjection)), "Shadow Projection" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShadowProjection)), "Set the shadow projection mode." },

                // Shadow Near Plane Offset
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShadowNearPlaneOffset)), "Shadow Near Plane Offset" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShadowNearPlaneOffset)), "Adjust the shadow near plane offset." },

                // Realtime Reflection Probes
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.RealtimeReflectionProbes)), "Realtime Reflection Probes" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.RealtimeReflectionProbes)), "Toggle realtime reflection probes." },

                // Billboards Face Camera Position
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BillboardsFaceCameraPosition)), "Billboards Face Camera Position" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BillboardsFaceCameraPosition)), "Toggle billboards facing the camera position." },

                // Anti-Aliasing
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AntiAliasing)), "Anti-Aliasing" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AntiAliasing)), "Adjust anti-aliasing settings. This feature is experimental and might conflict with the Adaptive Dynamic Resolution Scale and might not work as expected." },

                // Async Upload Time Slice
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AsyncUploadTimeSlice)), "Async Upload Time Slice" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AsyncUploadTimeSlice)), "Set the async upload time slice." },

                // Async Upload Buffer Size
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AsyncUploadBufferSize)), "Async Upload Buffer Size" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AsyncUploadBufferSize)), "Set the async upload buffer size." },

                // Terrain Detail Density Scale
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TerrainDetailDensityScale)), "Terrain Detail Density Scale" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TerrainDetailDensityScale)), "Adjust the terrain detail density scale." },

                // Terrain Pixel Error
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TerrainPixelError)), "Terrain Pixel Error" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TerrainPixelError)), "Set the terrain pixel error." },

                // Terrain basemap distance
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.terrainBasemapDistance)), "Terrain Basemap Distance" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.terrainBasemapDistance)), "Set the terrain basemap distance." },

                // Terrain detail distance
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.terrainDetailDistance)), "Terrain Detail Distance" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.terrainDetailDistance)), "Set the terrain detail distance." },

                // Terrain tree distance
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.terrainTreeDistance)), "Terrain Tree Distance" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.terrainTreeDistance)), "Set the terrain tree distance." },

                // terrainBillboardStart
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.terrainBillboardStart)), "Terrain Billboard Start" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.terrainBillboardStart)), "Set the terrain billboard start." },

                // terrainFadeLength
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.terrainFadeLength)), "Terrain Fade Length" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.terrainFadeLength)), "Set the terrain fade length." },

                // terrainMaxTrees
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.terrainMaxTrees)), "Terrain Max Trees" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.terrainMaxTrees)), "Terrain max trees. Also an experimental feature." },

               { m_Setting.GetOptionLabelLocaleID(nameof(Setting.Support)), "Support Server" },
               { m_Setting.GetOptionDescLocaleID(nameof(Setting.Support)), "Opens the SkyLinx Discord server in your default browser. Join our server for direct assistance from our team and community. Get help with troubleshooting, share your ideas, and stay updated on the latest news and updates. Our support server is the best place to connect with other users and receive personalized assistance." },

                // SomeEnum values
                { m_Setting.GetEnumValueLocaleID(Setting.SomeEnum.Value1), "Value 1" },
                { m_Setting.GetEnumValueLocaleID(Setting.SomeEnum.Value2), "Value 2" },
                { m_Setting.GetEnumValueLocaleID(Setting.SomeEnum.Value3), "Value 3" },
            };
        }

        /// <summary>
        /// Unloads the locale.
        /// </summary>
        public void Unload()
        {

        }
    }
}
