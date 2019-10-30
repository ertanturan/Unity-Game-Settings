using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameSettingsManager : MonoBehaviour
{
    public static GameSettingsManager Instance;


    private GameSetting [] Settings;
    public SettingType GameSetting;

    public UnityAction SettingChangeAction;
    public UnityEvent OnGameSettingChange;

    private void Awake()
    {
        Instance = this;
        
        Settings = Resources.LoadAll<GameSetting>("GameSettingsTool/Presets");
        GameSettingsSystem.Init();

        SettingChangeAction += OnSettingsChange;
        OnGameSettingChange.AddListener(SettingChangeAction);
    }


    private void OnSettingsChange()
    {
        Debug.Log("ON CHANGE");
    }
}
