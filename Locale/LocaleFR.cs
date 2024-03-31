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
    /// Représente la configuration régionale en français pour Render Mastery.
    /// </summary>
    public class LocaleFR : IDictionarySource
    {
        private readonly Setting m_Setting;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="LocaleFR"/> avec la configuration spécifiée.
        /// </summary>
        /// <param name="setting">La configuration à utiliser.</param>
        public LocaleFR(Setting setting)
        {
            m_Setting = setting;
        }

        /// <summary>
        /// Lit les entrées de la configuration régionale avec des erreurs possibles et des comptages d'index.
        /// </summary>
        /// <param name="errors">Liste pour capturer toute erreur survenue.</param>
        /// <param name="indexCounts">Comptages des entrées indexées.</param>
        /// <returns>Une collection de paires clé-valeur représentant les entrées régionales.</returns>
        public IEnumerable<KeyValuePair<string, string>> ReadEntries(IList<IDictionaryEntryError> errors, Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                { m_Setting.GetSettingsLocaleID(), "Maîtrise du Rendu" },
                { m_Setting.GetOptionTabLocaleID(Setting.kSection), "Maîtrise du Rendu" },
                { m_Setting.GetOptionTabLocaleID(Setting.kBasicTab), "Onglet de Base" },

                { m_Setting.GetOptionGroupLocaleID(Setting.kButtonGroup), "Maîtrise du Rendu" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kToggleGroup), "Maîtrise du Rendu" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kSliderGroup), "Maîtrise du Rendu" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kDropdownGroup), "Maîtrise du Rendu" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kBasicGroup), "Paramètres de Base"  },

                // Bouton
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.Button)), "Bouton" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.Button)), $"Un simple bouton unique. Il doit s'agir d'une propriété booléenne avec seulement un setter ou utilisez [{nameof(SettingsUIButtonAttribute)}] pour créer un bouton à partir d'une propriété booléenne avec à la fois un getter et un setter." },


                // Échelle de Résolution Dynamique Adaptative
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AdaptiveDynamicResolutionScale)), "Échelle de Résolution Dynamique Adaptative" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AdaptiveDynamicResolutionScale)), "Ajustez l'échelle de résolution dynamique adaptative." },

                // Niveau de Détail
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.levelOfDetail)), "Niveau de Détail" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.levelOfDetail)), "Forcez le réglage et changez les paramètres de niveau de détail." },

                // Niveau de Qualité Global
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.GlobalQualityLevel)), "Niveau de Qualité Global" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.GlobalQualityLevel)), "Ajustez le niveau de qualité global du rendu." },

                // Limite de Mipmap de Texture Global
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.GlobalTextureMipmapLimit)), "Limite de Mipmap de Texture Global" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.GlobalTextureMipmapLimit)), "Définissez la limite de mipmap de texture globale." },

                // Distance des Ombres
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShadowDistance)), "Distance des Ombres" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShadowDistance)), "Contrôlez la distance à laquelle les ombres sont rendues." },

                // Cascades d'Ombres
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShadowCascades)), "Cascades d'Ombres" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShadowCascades)), "Ajustez le nombre de cascades d'ombres." },

                // Projection d'Ombres
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShadowProjection)), "Projection d'Ombres" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShadowProjection)), "Définissez le mode de projection d'ombres." },

                // Décalage du Plan de Projection des Ombres Proches
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShadowNearPlaneOffset)), "Décalage du Plan de Projection des Ombres Proches" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShadowNearPlaneOffset)), "Ajustez le décalage du plan de projection des ombres proches." },

                // Sondes de Réflexion en Temps Réel
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.RealtimeReflectionProbes)), "Sondes de Réflexion en Temps Réel" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.RealtimeReflectionProbes)), "Activez/désactivez les sondes de réflexion en temps réel." },

                // Affichage des Panneaux Publicitaires Face à la Position de la Caméra
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BillboardsFaceCameraPosition)), "Affichage des Panneaux Publicitaires Face à la Position de la Caméra" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BillboardsFaceCameraPosition)), "Activez/désactivez les panneaux publicitaires qui font face à la position de la caméra." },

                // Anti-Aliasing
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AntiAliasing)), "Anti-Aliasing" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AntiAliasing)), "Ajustez les paramètres d'anti-aliasing. Cette fonctionnalité est expérimentale et peut entrer en conflit avec l'Échelle de Résolution Dynamique Adaptative et peut ne pas fonctionner comme prévu." },

                // Tranche de Temps de Téléchargement Asynchrone
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AsyncUploadTimeSlice)), "Tranche de Temps de Téléchargement Asynchrone" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AsyncUploadTimeSlice)), "Définissez la tranche de temps de téléchargement asynchrone." },

                // Taille du Tampon de Téléchargement Asynchrone
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AsyncUploadBufferSize)), "Taille du Tampon de Téléchargement Asynchrone" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AsyncUploadBufferSize)), "Définissez la taille du tampon de téléchargement asynchrone." },

                // Échelle de Densité de Détails du Terrain
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TerrainDetailDensityScale)), "Échelle de Densité de Détails du Terrain" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TerrainDetailDensityScale)), "Ajustez l'échelle de densité de détails du terrain." },

                // Erreur de Pixel du Terrain
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TerrainPixelError)), "Erreur de Pixel du Terrain" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TerrainPixelError)), "Définissez l'erreur de pixel du terrain." },

                // Distance de Base du Terrain
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.terrainBasemapDistance)), "Distance de Base du Terrain" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.terrainBasemapDistance)), "Définissez la distance de base du terrain." },

                // Distance de Détail du Terrain
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.terrainDetailDistance)), "Distance de Détail du Terrain" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.terrainDetailDistance)), "Définissez la distance de détail du terrain." },

                // Distance des Arbres du Terrain
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.terrainTreeDistance)), "Distance des Arbres du Terrain" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.terrainTreeDistance)), "Définissez la distance des arbres du terrain." },

                // Début des Panneaux Publicitaires du Terrain
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.terrainBillboardStart)), "Début des Panneaux Publicitaires du Terrain" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.terrainBillboardStart)), "Définissez le début des panneaux publicitaires du terrain." },

                // Longueur de Fondu du Terrain
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.terrainFadeLength)), "Longueur de Fondu du Terrain" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.terrainFadeLength)), "Définissez la longueur de fondu du terrain." },

                // Maximum d'Arbres du Terrain
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.terrainMaxTrees)), "Maximum d'Arbres du Terrain" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.terrainMaxTrees)), "Maximum d'arbres du terrain. Aussi une fonctionnalité expérimentale." },

                // Valeurs de SomeEnum
                { m_Setting.GetEnumValueLocaleID(Setting.SomeEnum.Value1), "Valeur 1" },
                { m_Setting.GetEnumValueLocaleID(Setting.SomeEnum.Value2), "Valeur 2" },
                { m_Setting.GetEnumValueLocaleID(Setting.SomeEnum.Value3), "Valeur 3" },
            };
        }

        /// <summary>
        /// Décharge la configuration régionale.
        /// </summary>
        public void Unload()
        {

        }
    }
}
