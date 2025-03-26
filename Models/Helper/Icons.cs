using System.Collections.Generic;
using Colossal.UI;

namespace Mod.Models.Helper;

public static class Icons
{
    private static readonly Dictionary<string, List<string>> pathToIconLoaded = [];
    internal static readonly string IconsResourceKey = "kelvinspaces-hotkey";
    internal static readonly string COUIBaseLocation = $"coui://{IconsResourceKey}";

    public static void LoadIconsFolder(string uri, string path, bool shouldWatch = false)
    {

        if (pathToIconLoaded.ContainsKey(uri))
        {
            if (pathToIconLoaded[uri].Contains(path)) return;
            pathToIconLoaded[uri].Add(path);
        }
        else
        {
            pathToIconLoaded.Add(uri, [path]);
        }

        UIManager.defaultUISystem.AddHostLocation(uri, path, shouldWatch);
    }

}