using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class GameSettingsButton : MonoBehaviour
{
    private Button _button;

    public GameSetting Setting;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        GameSettingsSystem.SetSettings(Setting);
    }

}
