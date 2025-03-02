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
    /// Representa la configuración regional en inglés para Render Mastery.
    /// </summary>
    public class LocaleES : IDictionarySource
    {
        private readonly Setting m_Setting;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="LocaleEN"/> con la configuración especificada.
        /// </summary>
        /// <param name="setting">La configuración a utilizar.</param>
        public LocaleES(Setting setting)
        {
            m_Setting = setting;
        }

        /// <summary>
        /// Lee las entradas de la configuración regional con posibles errores y recuentos de índices.
        /// </summary>
        /// <param name="errors">Lista para capturar cualquier error que ocurra.</param>
        /// <param name="indexCounts">Recuentos de entradas indexadas.</param>
        /// <returns>Una colección de pares clave-valor que representan las entradas regionales.</returns>
        public IEnumerable<KeyValuePair<string, string>> ReadEntries(IList<IDictionaryEntryError> errors, Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                               { m_Setting.GetOptionLabelLocaleID(nameof(Setting.RenderMasteryByNyoko)), $"Render Mastery by Nyoko" },
                { m_Setting.GetSettingsLocaleID(), "Render Mastery" },
                { m_Setting.GetOptionTabLocaleID(Setting.kSection), "Render Mastery" },
                { m_Setting.GetOptionTabLocaleID(Setting.kBasicTab), "Pestaña Básica" },

                { m_Setting.GetOptionGroupLocaleID(Setting.kButtonGroup), "Render Mastery" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kToggleGroup), "Render Mastery" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kSliderGroup), "Render Mastery" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kDropdownGroup), "Render Mastery" },
                          { m_Setting.GetOptionGroupLocaleID(Setting.kBasicGroup), "RENDER MASTERY"  },

                // Botón
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.Button)), "Botón" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.Button)), $"Un simple botón único. Debe ser una propiedad booleana con solo un setter o use [{nameof(SettingsUIButtonAttribute)}] para crear un botón a partir de una propiedad booleana con ambos getter y setter." },


                // Use Render Mastery
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.UseRenderMastery)), "Activar Render Mastery" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.UseRenderMastery)), "Activar o desactivar Render Mastery. Tiene que estar activada para el funcionamiento del resto de las funciones." },

                // Escala de Resolución Dinámica Adaptativa
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AdaptiveDynamicResolutionScale)), "Escala de Resolución Dinámica Adaptativa" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AdaptiveDynamicResolutionScale)), "Ajusta la escala de resolución dinámica adaptativa." },

                // Nivel de Detalle
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.levelOfDetail)), "Nivel de Detalle" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.levelOfDetail)), "Ajusta y cambia forzosamente la configuración del nivel de detalle." },

                // Nivel de Calidad Global
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.GlobalQualityLevel)), "Nivel de Calidad Global" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.GlobalQualityLevel)), "Ajusta el nivel de calidad global del renderizado." },

                // Límite de Mipmap de Textura Global
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.GlobalTextureMipmapLimit)), "Límite de Mipmap de Textura Global" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.GlobalTextureMipmapLimit)), "Establece el límite de mipmap de textura global." },

                // Distancia de las Sombras
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShadowDistance)), "Distancia de las Sombras" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShadowDistance)), "Controla la distancia a la que se renderizan las sombras." },

                // Cascadas de Sombras
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShadowCascades)), "Cascadas de Sombras" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShadowCascades)), "Ajusta el número de cascadas de sombras." },

                // Proyección de Sombras
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShadowProjection)), "Proyección de Sombras" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShadowProjection)), "Establece el modo de proyección de sombras." },

                // Desplazamiento del Plano de las Sombras Cercanas
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ShadowNearPlaneOffset)), "Desplazamiento del Plano de las Sombras Cercanas" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ShadowNearPlaneOffset)), "Ajusta el desplazamiento del plano de las sombras cercanas." },

                // Sondeos de Reflexión en Tiempo Real
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.RealtimeReflectionProbes)), "Sondeos de Reflexión en Tiempo Real" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.RealtimeReflectionProbes)), "Activa/desactiva los sondeos de reflexión en tiempo real." },

                // Caras de Posición de la Cámara de los Carteles
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.BillboardsFaceCameraPosition)), "Caras de Posición de la Cámara de los Carteles" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.BillboardsFaceCameraPosition)), "Activa/desactiva los carteles que miran hacia la posición de la cámara." },

                // Anti-Aliasing
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AntiAliasing)), "Anti-Aliasing" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AntiAliasing)), "Ajusta la configuración de anti-aliasing. Esta función es experimental y puede entrar en conflicto con la Escala de Resolución Dinámica Adaptativa y es posible que no funcione como se espera." },

                // Corte de Tiempo de Carga Asíncrona
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AsyncUploadTimeSlice)), "Corte de Tiempo de Carga Asíncrona" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AsyncUploadTimeSlice)), "Establece el corte de tiempo de carga asíncrona." },

                // Tamaño del Búfer de Carga Asíncrona
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AsyncUploadBufferSize)), "Tamaño del Búfer de Carga Asíncrona" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AsyncUploadBufferSize)), "Establece el tamaño del búfer de carga asíncrona." },

                // Escala de Densidad de Detalles del Terreno
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TerrainDetailDensityScale)), "Escala de Densidad de Detalles del Terreno" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TerrainDetailDensityScale)), "Ajusta la escala de densidad de detalles del terreno." },

                // Error de Píxel del Terreno
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TerrainPixelError)), "Error de Píxel del Terreno" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TerrainPixelError)), "Establece el error de píxel del terreno." },

                // Distancia del Mapa Base del Terreno
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.terrainBasemapDistance)), "Distancia del Mapa Base del Terreno" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.terrainBasemapDistance)), "Establece la distancia del mapa base del terreno." },

                // Distancia del Detalle del Terreno
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.terrainDetailDistance)), "Distancia del Detalle del Terreno" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.terrainDetailDistance)), "Establece la distancia del detalle del terreno." },

                // Distancia del Árbol del Terreno
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.terrainTreeDistance)), "Distancia del Árbol del Terreno" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.terrainTreeDistance)), "Establece la distancia del árbol del terreno." },

                // Inicio de los Carteles del Terreno
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.terrainBillboardStart)), "Inicio de los Carteles del Terreno" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.terrainBillboardStart)), "Establece el inicio de los carteles del terreno." },

                // Longitud del Desvanecimiento del Terreno
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.terrainFadeLength)), "Longitud del Desvanecimiento del Terreno" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.terrainFadeLength)), "Establece la longitud del desvanecimiento del terreno." },

                // Máximo de Árboles del Terreno
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.terrainMaxTrees)), "Máximo de Árboles del Terreno" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.terrainMaxTrees)), "Máximo de árboles del terreno. También una característica experimental." },

                // Valores de SomeEnum
                { m_Setting.GetEnumValueLocaleID(Setting.SomeEnum.Value1), "Valor 1" },
                { m_Setting.GetEnumValueLocaleID(Setting.SomeEnum.Value2), "Valor 2" },
                { m_Setting.GetEnumValueLocaleID(Setting.SomeEnum.Value3), "Valor 3" },

                 { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ReloadSettings)), "Recargar ajustes" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ReloadSettings)), "Recarga los ajustes desde el archivo XML." },
            };
        }

        /// <summary>
        /// Descarga la configuración regional.
        /// </summary>
        public void Unload()
        {

        }
    }
}
