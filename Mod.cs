using Colossal.IO.AssetDatabase;
using Colossal.Localization;
using Colossal.Logging;
using Game;
using Game.Modding;
using Game.SceneFlow;
using Mod.Debugger;
using Mod.Models.Localization;
using System.Reflection;
using Mod.UiSystem;
using System.IO;
using Mod.Models.Extension;

namespace Mod
{
    public class Hotkey : IMod
    {
        public static ModSettings ModSettings;
        private LocalizationManager LocalizationManager => GameManager.instance.localizationManager;

        public static ILog Logger = LogManager.GetLogger("Kelvinspaces.Hotkey").SetShowsErrorsInUI(false);

		public void OnLoad(UpdateSystem updateSystem)
        {
            Logger.Info(nameof(OnLoad));

            if (GameManager.instance.modManager.TryGetExecutableAsset(this, out var asset))
                Logger.Info($"Current mod asset at {asset.path}");

            Localization.LoadLocalization(Assembly.GetExecutingAssembly());

			FileInfo fileInfo = new(asset.path);
			Icons.LoadIconsFolder(Icons.IconsResourceKey, fileInfo.Directory.FullName);

			ModSettings = new ModSettings(this);
            ModSettings.RegisterInOptionsUI();
            ModSettings.RegisterKeyBindings();
            AssetDatabase.global.LoadSettings(nameof(Mod), ModSettings, new ModSettings(this));
            ModSettings.ApplyAndSave();

            updateSystem.UpdateAt<UISystem>(SystemUpdatePhase.UIUpdate);
        }

        public void OnDispose()
        {
            Logger.Info($"{nameof(Hotkey)}.{nameof(OnDispose)}");

            if (ModSettings != null)
            {
                ModSettings.UnregisterInOptionsUI();
                ModSettings = null;
            }
            else
            {
                Logger.Info($"ModSettings is NULL");
            }
        }
    }
}
