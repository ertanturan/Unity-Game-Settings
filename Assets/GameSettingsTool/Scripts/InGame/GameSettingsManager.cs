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


    private void Awake()
    {


        Instance = this;
        if (PPLayer == null || PPVolume == null)
        {
            Debug.LogError("Post process volume or post process layer is null !. " +
                           "Won't initialize the game settings system .. ");
        }
        else
        {
            Debug.Log("No error occured. Will init ...");
            GameSettingsSystem.Init(true);
        }
    }



}
