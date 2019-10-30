using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameSettingsSystem
{
    private static GameSetting [] _gameSettings;
    private static GameSetting _currentSetting;

    public static void Init(GameSetting[] array)
    {
        _gameSettings = array;
    }

    public static void SetSettings(GameSetting type)
    {
        

        GameSettingsManager.Instance.OnGameSettingChange.Invoke();
    }





}
