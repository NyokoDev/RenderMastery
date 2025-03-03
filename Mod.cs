﻿using ColorAdjustmentsMod.XML;
using Colossal;
using Colossal.IO.AssetDatabase;
using Colossal.Logging;
using Game;
using Game.Modding;
using Game.SceneFlow;
using RenderMastery.Locale;
using RenderMastery.Systems;
using System.IO;
using System;
using Game.Settings;

namespace RenderMastery
{
    public class Mod : IMod
    {
        public static ILog log = LogManager.GetLogger($"{nameof(RenderMastery)}.{nameof(Mod)}").SetShowsErrorsInUI(false);
        private Setting m_Setting;
        private string SettingsPath = GlobalVariables.SettingsPath();

        public void OnLoad(UpdateSystem updateSystem)
        {
            log.Info(nameof(OnLoad));

            if (GameManager.instance.modManager.TryGetExecutableAsset(this, out var asset))
                log.Info($"Current mod asset at {asset.path}");

            LoadSettings();
            m_Setting = new Setting(this);
            m_Setting.RegisterInOptionsUI();

            // Initialize translations: 
            GameManager.instance.localizationManager.AddSource("en-US", new LocaleEN(m_Setting));
            GameManager.instance.localizationManager.AddSource("es-ES", new LocaleES(m_Setting));
            GameManager.instance.localizationManager.AddSource("fr-FR", new LocaleFR(m_Setting));


            // Initialize systems:
            updateSystem.UpdateAfter<RenderMasterySystem>(SystemUpdatePhase.PreSimulation);
            updateSystem.UpdateAfter<RenderMasterySystem>(SystemUpdatePhase.GameSimulation);





            //            AssetDatabase.global.LoadSettings(nameof(RenderMastery), m_Setting, new Setting(this));  Prevent settings from loading and override with our own.

            // Ensure that the SettingsPath is not null or empty

        }

        private void LoadSettings()
        {
            if (string.IsNullOrEmpty(SettingsPath))
            {
                Mod.log.Info("Render Mastery: Initializing settings.");
                SettingsPath = GlobalVariables.SettingsPath();
            }
            GlobalVariables.LoadFromFile(SettingsPath);
        }

        public void OnDispose()
        {
            log.Info(nameof(OnDispose));
            if (m_Setting != null)
            {
                m_Setting.UnregisterInOptionsUI();
                m_Setting = null;
            }
        }
    }
}

    
