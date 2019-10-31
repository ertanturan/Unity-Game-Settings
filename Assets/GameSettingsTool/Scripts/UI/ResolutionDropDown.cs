using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMP_Dropdown))]
public class ResolutionDropDown : MonoBehaviour
{
    private TMP_Dropdown _ddResolution;


    private void Awake()
    {
        _ddResolution = GetComponent<TMP_Dropdown>();
        _ddResolution.onValueChanged.AddListener(
            delegate
            {
                GameSettingsSystem.OnResolutionChange(_ddResolution);
            }
            );


    }

    private void Start()
    {
        for (int i = 0; i < GameSettingsManager.Instance._resolutions.Count; i++)
        {
            _ddResolution.options.Add(new TMP_Dropdown.OptionData(
                GameSettingsManager.Instance._resolutions[i].x + "x" +
                GameSettingsManager.Instance._resolutions[i].y
            ));
        }
    }
}
