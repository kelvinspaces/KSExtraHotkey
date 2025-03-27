﻿using cohtml.Net;
using Game.SceneFlow;
using Game.Tools;
using KSExtraHotkey.Input;
using System;
using KSExtraHotkey.Settings;

namespace KSExtraHotkey.Models.Tools;

public class ElevationManager(ModSettings modSettings, UIInputManager uiInputManager, NetToolSystem netToolSystem)
{
    private readonly View _uiView = GameManager.instance.userInterface.view.View;

    private readonly float[] _elevationSteps = [1.25f, 2.5f, 5f, 10f];

    public void OnElevationScroll()
    {
        if (!modSettings.EnableElevationScroll) return;

        if (uiInputManager.IsZoomingIn())
        {
            netToolSystem.ElevationUp();
            PlayUISound("increase-elevation");
        }
        else if (uiInputManager.IsZoomingOut())
        {
            netToolSystem.ElevationDown();
            PlayUISound("decrease-elevation");
        }
    }

    public void OnElevationStepScroll()
    {
        if (!modSettings.EnableElevationStepScroll) return;

        int currentIndex = Array.IndexOf(_elevationSteps, netToolSystem.elevationStep);

        if (uiInputManager.IsZoomingIn())
        {
            IncreaseElevationStep(currentIndex);
        }
        else if (uiInputManager.IsZoomingOut())
        {
            DecreaseElevationStep(currentIndex);
        }
    }

    private void IncreaseElevationStep(int currentIndex)
    {
        if (currentIndex < _elevationSteps.Length - 1)
        {
            SetElevationStep(_elevationSteps[currentIndex + 1]);
            PlayUISound("select-item");
        }
    }

    private void DecreaseElevationStep(int currentIndex)
    {
        if (currentIndex > 0)
        {
            SetElevationStep(_elevationSteps[currentIndex - 1]);
            PlayUISound("select-item");
        }
    }

    private void SetElevationStep(float newStep)
    {
        _uiView.TriggerEvent("tool.setElevationStep", newStep);
    }

    private void PlayUISound(string soundName)
    {
        _uiView.TriggerEvent("audio.playSound", soundName, 1);
    }
}
