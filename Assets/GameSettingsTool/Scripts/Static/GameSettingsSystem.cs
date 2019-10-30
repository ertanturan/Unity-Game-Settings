using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameSettingsSystem
{

    public static void Init()
    {

    }

    public static void SetSettings(SettingType type)
    {
        switch (type)
        {
            case SettingType.Fast:
                SetSettingsFast();
                break;
            case SettingType.High:
                SetSettingsHigh();
                break;
            case SettingType.Medium:
                SetSettingsMedium();
                break;
        }

        GameSettingsManager.Instance.OnGameSettingChange.Invoke();
    }

    private static void SetSettingsFast()
    {
        Debug.Log("FAST");
    }

    private static void SetSettingsHigh()
    {
        Debug.Log("HIGH");
    }

    private static void SetSettingsMedium()
    {
        Debug.Log("MEDIUM");
    }

}
