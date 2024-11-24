using Game.UI.InGame;
using Game.UI;
using System;
using System.Reflection;
using System.Reflection.Emit;
using Game.Rendering;
using Colossal.UI.Binding;
using Game.Tools;
using Game.Simulation;
using Unity.Entities;
using Game.UI.Widgets;
using System.Collections.Generic;
using Game;
using Game.Rendering.CinematicCamera;
using Game.Rendering.Utilities;
using ColorAdjustmentsMod.XML;
using UnityEngine;
// The entirety of this code stands as the creation of Nyoko. Any attempt to redistribute or share this code without explicit authorization is strictly prohibited.
namespace RenderMastery.Systems
{
    public partial class RenderMasterySystem : SystemBase
    {
        RenderingSystem renderingSystem = World.DefaultGameObjectInjectionWorld?.GetExistingSystemManaged<RenderingSystem>();
        protected override void OnUpdate()
        {
            SetPrivateFieldValue();

        }
        public void SetPrivateFieldValue()
        {
            Type type = typeof(Game.Rendering.Utilities.AdaptiveDynamicResolutionScale);
            FieldInfo fieldInfo = type.GetField("s_CurrentScaleFraction", BindingFlags.NonPublic | BindingFlags.Static);

            if (fieldInfo != null)
            {
                // Setting the value to whatever Fraction is.
                fieldInfo.SetValue(null, GlobalVariables.Instance.DynamicResScale);

            }
            else
            {
                Console.WriteLine("[Critical] CurrentScaleFraction not found.");
            }

            if (GlobalVariables.Instance.UseRenderMastery) {

                RenderingSystem renderingSystem = World.DefaultGameObjectInjectionWorld?.GetExistingSystemManaged<RenderingSystem>();
                renderingSystem.levelOfDetail = GlobalVariables.Instance.levelOfDetail;
                QualitySettings.SetQualityLevel(GlobalVariables.Instance.GlobalQualityLevel, true); 
            QualitySettings.globalTextureMipmapLimit = GlobalVariables.Instance.GlobalTextureMipmapLimit; // Reduces texture quality to minimum
            QualitySettings.shadows = ShadowQuality.Disable; // Disable shadows
            QualitySettings.shadowResolution = ShadowResolution.Low; // Set shadow resolution to low
            QualitySettings.shadowDistance = GlobalVariables.Instance.ShadowDistance; // Set shadow distance to 0
            QualitySettings.shadowCascades = GlobalVariables.Instance.ShadowCascades; // Disable shadow cascades
            QualitySettings.shadowProjection = ShadowProjection.CloseFit; // Use close-fit shadow projection
            QualitySettings.shadowNearPlaneOffset = GlobalVariables.Instance.ShadowDistance; // Set shadow near plane offset
            QualitySettings.realtimeReflectionProbes = GlobalVariables.Instance.RealtimeReflectionProbes; // Disable realtime reflection probes
            QualitySettings.billboardsFaceCameraPosition = GlobalVariables.Instance.BillboardsFaceCameraPosition; // Billboards don't face camera position
            QualitySettings.antiAliasing = 0; // Disable anti-aliasing
            QualitySettings.asyncUploadTimeSlice = GlobalVariables.Instance.AsyncUploadTimeSlice; // Set async upload time slice
            QualitySettings.asyncUploadBufferSize = GlobalVariables.Instance.AsyncUploadBufferSize; // Set async upload buffer size
            QualitySettings.terrainDetailDensityScale = GlobalVariables.Instance.TerrainDetailDensityScale;
            QualitySettings.terrainPixelError = GlobalVariables.Instance.TerrainPixelError;

            QualitySettings.terrainBasemapDistance = GlobalVariables.Instance.terrainBasemapDistance;
            QualitySettings.terrainDetailDistance = GlobalVariables.Instance.terrainDetailDistance;
            QualitySettings.terrainTreeDistance = GlobalVariables.Instance.terrainTreeDistance;
            QualitySettings.terrainBillboardStart = GlobalVariables.Instance.terrainBillboardStart;
            QualitySettings.terrainFadeLength = GlobalVariables.Instance.terrainFadeLength;
            }


        }
    }
}




// The entirety of this code stands as the creation of Nyoko. Any attempt to redistribute or share this code without explicit authorization is strictly prohibited.