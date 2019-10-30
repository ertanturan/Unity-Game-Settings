using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Game Setting",menuName = "Game Settings/New Game Setting")]
public class GameSetting : ScriptableObject
{

    public AntiAliasing AntiAliasing = AntiAliasing.None;

}
