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

        [XmlElement]
        public bool UseRenderMastery { get; set; }

        public static string SettingsPath()
        {
            // Construct the path to the settings directory
            string localLowDirectory = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "..", "LocalLow");

            string directoryPath = Path.Combine(
                localLowDirectory,
                "Colossal Order", "Cities Skylines II", "ModsData", "RenderMastery");

            // Ensure the directory exists
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Construct the full path to the settings file
            string settingsFilePath = Path.Combine(directoryPath, "RenderMastery.xml");

            // Ensure the settings file exists
            if (!File.Exists(settingsFilePath))
            {
                File.Create(settingsFilePath); // Create the file and immediately close it
            }

            // Return the full path to the settings file
            return settingsFilePath;
        }


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

                // Log success message
                Mod.log.Info($"Successfully saved Render Mastery GlobalVariables to file: {filePath}");

            }
            catch (Exception ex)
            {
                Mod.log.Error($"Error saving Render Mastery GlobalVariables to file: {ex.Message}");
            }
        }

        public static GlobalVariables LoadFromFile(string filePath)
        {
            try
            {
                // Create an XmlSerializer for the GlobalVariables type.
                XmlSerializer serializer = new XmlSerializer(typeof(GlobalVariables));

                // Open the file and deserialize the object.
                using (TextReader reader = new StreamReader(filePath))
                {
                    GlobalVariables loadedVariables = (GlobalVariables)serializer.Deserialize(reader);

                    // If GlobalVariables.Instance is not null, set the properties dynamically
                    if (GlobalVariables.Instance != null)
                    {
                        // Get the type of GlobalVariables.Instance
                        Type instanceType = GlobalVariables.Instance.GetType();

                        // Get all public properties of the instance
                        var properties = instanceType.GetProperties();

                        foreach (var property in properties)
                        {
                            // Check if the property exists in the loadedVariables object
                            var loadedProperty = loadedVariables.GetType().GetProperty(property.Name);
                            if (loadedProperty != null && loadedProperty.CanRead)
                            {
                                // Get the value of the property from loadedVariables
                                var value = loadedProperty.GetValue(loadedVariables);

                                // Set the value to the corresponding property in GlobalVariables.Instance
                                property.SetValue(GlobalVariables.Instance, value);
                            }
                        }

                        // Log success message
                        Mod.log.Info($"Successfully loaded Render Mastery settings from {filePath}");
                    }
                    else
                    {
                        Mod.log.Error("GlobalVariables.Instance is null. Settings not applied.");
                        return null;
                    }

                    return loadedVariables;
                }
            }
            catch (Exception ex)
            {
                Mod.log.Error($"Error loading Render Mastery settings: {ex.Message}");
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