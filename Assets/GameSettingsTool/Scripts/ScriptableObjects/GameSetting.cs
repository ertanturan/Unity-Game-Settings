using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[CreateAssetMenu(fileName = "New Game Setting", menuName = "Game Settings/New Game Setting")]
public class GameSetting : ScriptableObject
{

    [Header("Identifiers")]
    public SettingType Type;

    [Space]
    [Header("Quality Settings")]

    public int QualityIndex;
    public bool ApplyExpensiveSettings;
    public PostProcessProfile PostProcessProfile;

    public float CameraFar = 1000f;

}
