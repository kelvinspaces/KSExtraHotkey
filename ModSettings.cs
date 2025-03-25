using Colossal.IO.AssetDatabase;
using Game.Input;
using Game.Modding;
using Game.Settings;
using System.Linq;
using System;
using System.Reflection;
using Mod.Models.Ui;

namespace Mod
{
    [FileLocation(nameof(Mod))]
    [SettingsUIGroupOrder(gOpenToolsKeybindings, gRoadToolModeKeybindings, gZoneToolModeKeybindings, gSnappingKeybindings, gGeneral, gToolRelated, gAbout)]
    [SettingsUIShowGroupName(gOpenToolsKeybindings, gRoadToolModeKeybindings, gZoneToolModeKeybindings, gSnappingKeybindings, gGeneral, gToolRelated, gAbout)]


    public class ModSettings(IMod mod) : ModSetting(mod)
    {
        // Section names
        public const string sToolKeybindings            = "Tool Keybindings";
        public const string sGeneral                    = "General";

        // Group names
        public const string gOpenToolsKeybindings       = "Open tools";
        public const string gRoadToolModeKeybindings    = "Tool modes (Road)";
        public const string gZoneToolModeKeybindings    = "Tool modes (Zones)";
        public const string gSnappingKeybindings        = "Snapping options";
        
        public const string gGeneral                    = "General";
        public const string gToolRelated                = "Tool related";
        public const string gAbout                      = "About";


        //[SettingsUIKeyboardBinding(BindingKeyboard.None, nameof(RoadStraight))]
        [UIAttributes.CustomUIExtendedKeybinding("coui://ui-mods/Icons/Straight.svg", BindingKeyboard.None, "ButtonBinding")]
        [SettingsUISection(sToolKeybindings, gRoadToolModeKeybindings)]
        public ProxyBinding RoadStraight { get; set; }

        // Simple curve for net tools or marquee for zone tools
        [SettingsUIKeyboardBinding(BindingKeyboard.None, nameof(RoadSimpleCurve))]
        [SettingsUISection(sToolKeybindings, gRoadToolModeKeybindings)]
        [SettingsUIMultilineText("coui://Hotkey/Assets/Icons/Straight.svg")]
        public ProxyBinding RoadSimpleCurve { get; set; }

        // Complex curve for net tools or paint for zone tools
        [SettingsUIKeyboardBinding(BindingKeyboard.None, nameof(RoadComplexCurve))]
        [SettingsUISection(sToolKeybindings, gRoadToolModeKeybindings)]
        public ProxyBinding RoadComplexCurve { get; set; }

        // Continuous 
        [SettingsUIKeyboardBinding(BindingKeyboard.None, nameof(RoadContinuous))]
        [SettingsUISection(sToolKeybindings, gRoadToolModeKeybindings)]
        [SettingsUIMultilineText("TEST 2")]
        public ProxyBinding RoadContinuous { get; set; }

        // Grid
        [SettingsUIKeyboardBinding(BindingKeyboard.None, nameof(RoadGrid))]
        [SettingsUISection(sToolKeybindings, gRoadToolModeKeybindings)]
        public ProxyBinding RoadGrid { get; set; }

        // Replace
        [SettingsUIKeyboardBinding(BindingKeyboard.None, nameof(RoadReplace))]
        [SettingsUISection(sToolKeybindings, gRoadToolModeKeybindings)]
        public ProxyBinding RoadReplace { get; set; }


        // Zone mode keybindings
        // Fill for zone tools
        [SettingsUIKeyboardBinding(BindingKeyboard.None, nameof(ZoneFill))]
        [SettingsUISection(sToolKeybindings, gZoneToolModeKeybindings)]
        public ProxyBinding ZoneFill { get; set; }

        // Marquee for zone tools
        [SettingsUIKeyboardBinding(BindingKeyboard.None, nameof(ZoneMarquee))]
        [SettingsUISection(sToolKeybindings, gZoneToolModeKeybindings)]
        public ProxyBinding ZoneMarquee { get; set; }

        // Paint for zone tools
        [SettingsUIKeyboardBinding(BindingKeyboard.None, nameof(ZonePaint))]
        [SettingsUISection(sToolKeybindings, gZoneToolModeKeybindings)]
        public ProxyBinding ZonePaint { get; set; }


        // Snapping options
        // Snap to existing geometry
        [SettingsUIKeyboardBinding(BindingKeyboard.None, nameof(SnapToExistingGeometryKeyBinding))]
        [SettingsUISection(sToolKeybindings, gSnappingKeybindings)]
        public ProxyBinding SnapToExistingGeometryKeyBinding { get; set; }

        // Snap to zoning cell length
        [SettingsUIKeyboardBinding(BindingKeyboard.None, nameof(SnapToCellLengthKeyBinding))]
        [SettingsUISection(sToolKeybindings, gSnappingKeybindings)]
        public ProxyBinding SnapToCellLengthKeyBinding { get; set; }

        // Snap to 90 degree angles
        [SettingsUIKeyboardBinding(BindingKeyboard.None, nameof(SnapTo90DegreeAnglesKeyBinding))]
        [SettingsUISection(sToolKeybindings, gSnappingKeybindings)]
        public ProxyBinding SnapTo90DegreeAnglesKeyBinding { get; set; }

        // Snap to sides of a building
        [SettingsUIKeyboardBinding(BindingKeyboard.None, nameof(SnapToBuildingSidesKeyBinding))]
        [SettingsUISection(sToolKeybindings, gSnappingKeybindings)]
        public ProxyBinding SnapToBuildingSidesKeyBinding { get; set; }

        // Snap to guidelines
        [SettingsUIKeyboardBinding(BindingKeyboard.None, nameof(SnapToGuidelinesKeyBinding))]
        [SettingsUISection(sToolKeybindings, gSnappingKeybindings)]
        public ProxyBinding SnapToGuidelinesKeyBinding { get; set; }

        // Snap to nearby geometry
        [SettingsUIKeyboardBinding(BindingKeyboard.None, nameof(SnapToNearbyGeometryKeyBinding))]
        [SettingsUISection(sToolKeybindings, gSnappingKeybindings)]
        public ProxyBinding SnapToNearbyGeometryKeyBinding { get; set; }

        // Snap to zone grid
        [SettingsUIKeyboardBinding(BindingKeyboard.None, nameof(SnapToZoneGridKeyBinding))]
        [SettingsUISection(sToolKeybindings, gSnappingKeybindings)]
        public ProxyBinding SnapToZoneGridKeyBinding { get; set; }

        // Snap to the sides of a road
        [SettingsUIKeyboardBinding(BindingKeyboard.None, nameof(SnapToRoadSidesKeyBinding))]
        [SettingsUISection(sToolKeybindings, gSnappingKeybindings)]
        public ProxyBinding SnapToRoadSidesKeyBinding { get; set; }

        // Show contour lines
        [SettingsUIKeyboardBinding(BindingKeyboard.None, nameof(ShowContourLinesKeyBinding))]
        [SettingsUISection(sToolKeybindings, gSnappingKeybindings)]
        public ProxyBinding ShowContourLinesKeyBinding { get; set; }


        // General settings
        // Enable mod
        [SettingsUISection(sGeneral, gGeneral)]
        public bool EnableMod { get; set; } = true;

        // Reset key bindings
        [SettingsUISection(sGeneral, gGeneral)]
        [SettingsUIConfirmation()]
        public bool ResetBindings
        {
            set
            {
                Hotkey.Logger.Info("Reset key bindings");
                ResetKeyBindings();
            }
        }

        // Tool related settings
        // Enable elevation scroll (Ctrl + scroll wheel)
        [SettingsUISection(sGeneral, gToolRelated)]
        public bool EnableElevationScroll { get; set; } = false;

        // Enable elevation steps (Alt + scroll wheel)
        [SettingsUISection(sGeneral, gToolRelated)]
        public bool EnableElevationStepScroll { get; set; } = false;

        // Enable reset elevation (Alt + right click)
        [SettingsUISection(sGeneral, gToolRelated)]
        public bool EnableResetElevation { get; set; } = false;

        // Hidden elevation scroll key bindings
        [SettingsUIMouseBinding(BindingMouse.Right, nameof(ResetElevation), ctrl: true)]
        [SettingsUIHidden]
        public ProxyBinding ResetElevation { get; set; }

        // Enable brush size scroll (Ctrl + scroll wheel)
        [SettingsUISection(sGeneral, gToolRelated)]
        public bool EnableBrushSizeScroll { get; set; } = false;

        // Enable brush strength scroll (Alt + scroll wheel)
        [SettingsUISection(sGeneral, gToolRelated)]
        public bool EnableBrushStrengthScroll { get; set; } = false;



        // About mod
        [SettingsUISection(sGeneral, gAbout)]
        public string ModVersion => $"V{Assembly.GetExecutingAssembly().GetName().Version.ToString(3)}";

        public override void SetDefaults()
        {
            try
            {
                EnableMod                   = true;
                EnableElevationScroll       = false;
                EnableElevationStepScroll   = false;
                EnableResetElevation        = false;
                EnableBrushSizeScroll       = false;
                EnableBrushStrengthScroll   = false;

                var properties = GetType().GetProperties()
                    .Where(p => p.PropertyType == typeof(ProxyBinding));

                foreach (var property in properties.ToList())
                {
                    property.SetValue(this, new ProxyBinding());
                }
            }
            catch (Exception ex)
            {
                Hotkey.Logger.Error(ex.Message);
            }
        }
    }
}
