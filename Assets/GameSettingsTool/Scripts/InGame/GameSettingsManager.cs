using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering.PostProcessing;

public class GameSettingsManager : MonoBehaviour
{

    public static GameSettingsManager Instance;

    private GameSetting [] _settings;
    public SettingType GameSetting;
    public PostProcessVolume PPVolume;

    public UnityAction SettingChangeAction;
    public UnityEvent OnGameSettingChange;


    private void Awake()
    {

    }

    private void OnSettingsChange()
    {
        Debug.Log("ON CHANGE");
    }

}
