using System;
using Colossal;
using System.Collections.Generic;

namespace KSExtraHotkeys
{
    public class LocaleEN : IDictionarySource
    {
        private readonly ModSettings m_Setting;
        public LocaleEN(ModSettings setting)
        {
            m_Setting = setting;
        }
        public IEnumerable<KeyValuePair<string, string>> ReadEntries(IList<IDictionaryEntryError> errors, Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                // General, section and group translations
                { m_Setting.GetSettingsLocaleID(), ModAssemblyInfo.Title },
                { m_Setting.GetOptionTabLocaleID(ModSettings.sGeneral), "Others" },
                { m_Setting.GetOptionTabLocaleID(ModSettings.sToolKeybindings), "Gameplay" },

                { m_Setting.GetOptionGroupLocaleID(ModSettings.gOpenToolsKeybindings), "Open Tool Windows" },
                { m_Setting.GetOptionGroupLocaleID(ModSettings.gRoadToolModeKeybindings), "Tool Modes (Road)" },
                { m_Setting.GetOptionGroupLocaleID(ModSettings.gZoneToolModeKeybindings), "Tool Modes (Zones)" },
                { m_Setting.GetOptionGroupLocaleID(ModSettings.gSnappingKeybindings), "Snapping Options" },

                { m_Setting.GetOptionGroupLocaleID(ModSettings.gGeneral), "General Settings" },
                { m_Setting.GetOptionGroupLocaleID(ModSettings.gToolRelated), "Quality Of Life Settings" },
                { m_Setting.GetOptionGroupLocaleID(ModSettings.gAbout), "About Mod" },


                // General settings translations
                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.EnableMod)), "Enable mod" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.EnableMod)), "Enable or disable the mod" },

                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.ResetBindings)), "Reset all key bindings" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.ResetBindings)), "Reset all key bindings of the mod" },


                // Tool related translations
                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.EnableElevationScroll)), "Enable elevation scroll" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.EnableElevationScroll)), "Enable to set elevation via Ctrl + scroll wheel." },

                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.EnableElevationStepScroll)), "Enable elevation steps scroll" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.EnableElevationStepScroll)), "Enable to set elevation steps via Alt + scroll wheel." },

                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.EnableResetElevation)), "Enable elevation reset" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.EnableResetElevation)), "Enable to reset elevation with Ctrl + right mouse click." },

                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.EnableBrushSizeScroll)), "Enable brush-size scroll" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.EnableBrushSizeScroll)), "Enable to set brush-size via Ctrl + scroll wheel in terrain tool." },

                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.EnableBrushStrengthScroll)), "Enable brush-strength scroll" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.EnableBrushStrengthScroll)), "Enable to set brush-strength via Alt + scroll wheel in terrain tool." },


                // Tool mode (Road)
                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.RoadStraight)), "Straight" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.RoadStraight)), "Set tool mode straight for roads" },

                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.RoadSimpleCurve)), "Simple Curve" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.RoadSimpleCurve)), "Set tool mode simple curve for roads" },

                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.RoadComplexCurve)), "Complex Curve" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.RoadComplexCurve)), "Set tool mode complex curve for roads" },

                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.RoadContinuous)), "Continuous" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.RoadContinuous)), "Set tool mode continuous for roads" },

                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.RoadGrid)), "Grid" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.RoadGrid)), "Set tool mode grid for roads" },

                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.RoadReplace)), "Replace" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.RoadReplace)), "Set tool mode replace for roads" },


        // Tool mode (Zones)
                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.ZoneFill)), "Fill" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.ZoneFill)), "Set tool mode straight for roads or fill for zones" },

                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.ZoneMarquee)), "Marquee" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.ZoneMarquee)), "Set tool mode marquee for zones" },

                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.ZonePaint)), "Paint" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.ZonePaint)), "Set tool mode paint for zones" },

              

                // Snapping options translations
                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.SnapToExistingGeometryKeyBinding)), "Existing geometry" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.SnapToExistingGeometryKeyBinding)), "Snap to existing geometry" },

                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.SnapToCellLengthKeyBinding)), "Zoning cell length" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.SnapToCellLengthKeyBinding)), "Snap to zoning cell length" },

                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.SnapTo90DegreeAnglesKeyBinding)), "90 degree angles" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.SnapTo90DegreeAnglesKeyBinding)), "Snap to 90 degree angles" },

                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.SnapToBuildingSidesKeyBinding)), "Building sides" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.SnapToBuildingSidesKeyBinding)), "Snap to building sides" },

                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.SnapToGuidelinesKeyBinding)), "Guidelines" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.SnapToGuidelinesKeyBinding)), "Snap to guidelines" },

                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.SnapToNearbyGeometryKeyBinding)), "Nearby geometry" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.SnapToNearbyGeometryKeyBinding)), "Snap to nearby geometry" },

                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.SnapToZoneGridKeyBinding)), "Zone grid" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.SnapToZoneGridKeyBinding)), "Snap to zone grid" },

                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.SnapToRoadSidesKeyBinding)), "Road sides" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.SnapToRoadSidesKeyBinding)), "Snap to road sides" },

                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.ShowContourLinesKeyBinding)), "Contour lines" },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.ShowContourLinesKeyBinding)), "Show contour lines" },


                // About mod translations
                { m_Setting.GetOptionLabelLocaleID(nameof(ModSettings.ModVersion)), $"{ModAssemblyInfo.Title}, ©" + DateTime.Today.Year + "  by Fenrir, Update by Kelvin." },
                { m_Setting.GetOptionDescLocaleID(nameof(ModSettings.ModVersion)), $"V{ModAssemblyInfo.Version}" },
            };
        }

        public void Unload()
        {

        }
    }
}
