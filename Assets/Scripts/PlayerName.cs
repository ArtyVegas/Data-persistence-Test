using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    // Variables
    public static Text playerName;

    // Store and pass the player name between scenes
    private void Awake()
    {
        DontDestroyOnLoad(playerName);
    }
}
