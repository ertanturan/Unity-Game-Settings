using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class GameSettingsManager : MonoBehaviour
{
    public static GameSettingsManager Instance;

    [Header("Quality Settings")]
    public PostProcessVolume PPVolume;
    public PostProcessLayer PPLayer;

    public GameSetting QualityDefaults;
    [Header("Resolution Set")]
    public List<Vector2> _resolutions;

    [Header("Camera")]
    public Camera Cam;

    private void Awake()
    {


        Instance = this;
        if (PPLayer == null || PPVolume == null || Cam == null)
        {
            Debug.LogError("At least one of the required attributes is null . Change it and retry . " +
                           "Won't initialize the game settings system .. ");
        }
        else
        {
            Debug.Log("No error occured. Will init ...");
            GameSettingsSystem.Init();
        }
    }



}
