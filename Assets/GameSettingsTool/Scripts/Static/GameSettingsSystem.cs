using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public static class GameSettingsSystem
{

    private static int _currentQualityIndex;

    private static bool _releaseSystem = false;

    public static void Init(bool runDefaults = false)
    {
        _releaseSystem = true;

        if (runDefaults)
        {
            SetSettings(GameSettingsManager.Instance.QualityDefaults);
        }
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
            }
        }


    }

    public static void OnResolutionChange(TMP_Dropdown _ddResolution)
    {
        int width = int.Parse(_ddResolution.options[_ddResolution.value].text.Split('x')[0]);

        int height = int.Parse(_ddResolution.options[_ddResolution.value].text.Split('x')[1]);

        Screen.SetResolution(width, height, true);
    }
}
