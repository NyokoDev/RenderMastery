using RenderMastery;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace ColorAdjustmentsMod.XML
{
    [Serializable]
    public class GlobalVariables
    {
        /// <summary>

        [XmlElement]
        public int DynamicResScale { get; set; }

        [XmlElement]
        public float levelOfDetail { get; set; }

        [XmlElement]
        public int GlobalQualityLevel { get; set; }

        [XmlElement]
        public int GlobalTextureMipmapLimit { get; set; }

        [XmlElement]
        public int ShadowDistance { get; set; }

        [XmlElement]
        public int ShadowCascades { get; set; }

        [XmlElement]
        public int ShadowProjection { get; set; }

        [XmlElement]
        public int ShadowNearPlaneOffset { get; set; }

        [XmlElement]
        public bool RealtimeReflectionProbes { get; set; }

        [XmlElement]
        public bool BillboardsFaceCameraPosition { get; set; }

        [XmlElement]
        public int AntiAliasing { get; set; }

        [XmlElement]
        public int AsyncUploadTimeSlice { get; set; }

        [XmlElement]
        public int AsyncUploadBufferSize { get; set; }

        [XmlElement]
        public int TerrainDetailDensityScale { get; set; }

        [XmlElement]
        public int TerrainPixelError { get; set; }

        [XmlElement]
        public float terrainBasemapDistance { get; set; }


        [XmlElement]
        public float terrainDetailDistance { get; set; }

        [XmlElement]
        public float terrainTreeDistance { get; set; }

        [XmlElement]
        public float terrainBillboardStart { get; set; }

        [XmlElement]
        public float terrainFadeLength { get; set; }

        [XmlElement]
        public float terrainMaxTrees { get; set; }



   
        public static void SaveToFile(string filePath)
        {
            try
            {
                // Create an XmlSerializer for the GlobalVariables type.
                XmlSerializer serializer = new XmlSerializer(typeof(GlobalVariables));

                // Create or open the file for writing.
                using (TextWriter writer = new StreamWriter(filePath))
                {
                    // Serialize the current static object to the file.
                    serializer.Serialize(writer, Instance);
                }


            }
            catch (Exception ex)
            {
                Mod.log.Info($"Error saving Render Mastery GlobalVariables to file: {ex.Message}");
            }
        }

        public static GlobalVariables LoadFromFile(string filePath)
        {
            try
            {
                // Create an XmlSerializer for the GlobalVariables type.
                XmlSerializer serializer = new XmlSerializer(typeof(GlobalVariables));

                // Open the file for reading.
                using (TextReader reader = new StreamReader(filePath))
                {
                    // Deserialize the object from the file.
                    GlobalVariables loadedVariables = (GlobalVariables)serializer.Deserialize(reader);

                    // Set the loaded values to the corresponding properties.
                    GlobalVariables.Instance.DynamicResScale = loadedVariables.DynamicResScale;
                    GlobalVariables.Instance.levelOfDetail = loadedVariables.levelOfDetail;
                    GlobalVariables.Instance.GlobalQualityLevel = loadedVariables.GlobalQualityLevel;
                    GlobalVariables.Instance.GlobalTextureMipmapLimit = loadedVariables.GlobalTextureMipmapLimit;
                    GlobalVariables.Instance.ShadowDistance = loadedVariables.ShadowDistance;
                    GlobalVariables.Instance.ShadowCascades = loadedVariables.ShadowCascades;
                    GlobalVariables.Instance.ShadowProjection = loadedVariables.ShadowProjection;
                    GlobalVariables.Instance.ShadowNearPlaneOffset = loadedVariables.ShadowNearPlaneOffset;
                    GlobalVariables.Instance.RealtimeReflectionProbes = loadedVariables.RealtimeReflectionProbes;
                    GlobalVariables.Instance.BillboardsFaceCameraPosition = loadedVariables.BillboardsFaceCameraPosition;
                    GlobalVariables.Instance.AntiAliasing = loadedVariables.AntiAliasing;
                    GlobalVariables.Instance.AsyncUploadTimeSlice = loadedVariables.AsyncUploadTimeSlice;
                    GlobalVariables.Instance.AsyncUploadBufferSize = loadedVariables.AsyncUploadBufferSize;
                    GlobalVariables.Instance.TerrainDetailDensityScale = loadedVariables.TerrainDetailDensityScale;
                    GlobalVariables.Instance.TerrainPixelError = loadedVariables.TerrainPixelError;
                    GlobalVariables.Instance.terrainBasemapDistance = loadedVariables.terrainBasemapDistance;
                    GlobalVariables.Instance.terrainDetailDistance = loadedVariables.terrainDetailDistance;
                    GlobalVariables.Instance.terrainTreeDistance = loadedVariables.terrainTreeDistance;
                    GlobalVariables.Instance.terrainBillboardStart = loadedVariables.terrainBillboardStart;
                    GlobalVariables.Instance.terrainFadeLength = loadedVariables.terrainFadeLength;
                    GlobalVariables.Instance.terrainMaxTrees = loadedVariables.terrainMaxTrees;







                    return loadedVariables;
                }
            }
            catch (Exception ex)
            {
                Mod.log.Info("Failed to load RenderMastery settings. Ensure that at least one setting is set.");
                return null;
            }
        }


        // Singleton pattern to ensure only one instance of GlobalVariables exists.
        private static GlobalVariables instance;
        public static GlobalVariables Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GlobalVariables();
                }
                return instance;
            }
        }


    }
}