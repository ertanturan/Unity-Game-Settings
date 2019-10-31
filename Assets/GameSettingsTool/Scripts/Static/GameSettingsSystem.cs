using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public static class GameSettingsSystem
{

    private static int _currentQualityIndex;

    private static bool _releaseSystem = false;

    public static void Init()
    {
        _releaseSystem = true;

        SetSettings(GameSettingsManager.Instance.QualityDefaults);

    }

    public static void SetSettings(GameSetting setting)
    {
        if (_releaseSystem)
        {
            if (QualitySettings.GetQualityLevel() != setting.QualityIndex)
            {
                QualitySettings.SetQualityLevel(setting.QualityIndex, setting.ApplyExpensiveSettings);
            }

            if (GameSettingsManager.Instance.PPVolume.profile != setting.PostProcessProfile)
            {
                GameSettingsManager.Instance.PPVolume.profile = setting.PostProcessProfile;
                GameSettingsManager.Instance.Cam.farClipPlane = setting.CameraFar;
            }
        }
        else
        {
            ReturnMessage();
        }

    }

    public static void OnResolutionChange(TMP_Dropdown _ddResolution)
    {
        if (_releaseSystem)
        {
            int width = int.Parse(_ddResolution.options[_ddResolution.value].text.Split('x')[0]);

            int height = int.Parse(_ddResolution.options[_ddResolution.value].text.Split('x')[1]);

            Screen.SetResolution(width, height, true);
        }
        else
        {
            ReturnMessage();
        }
    }

    private static void ReturnMessage(string message = "System was not released game " +
                                                     "settings won't work if not released...")
    {
        Debug.LogError(message);
    }
}
