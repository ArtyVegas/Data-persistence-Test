using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    //This is the handler of the main menu scene
    [SerializeField] Text PlayerNameInput;

    // Save the player name from the input field
    public void SetPlayerName()
    {
        PlayerDataHandle.Instance.PlayerName = PlayerNameInput.text;
    }

    // Action when clicking on Start button
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    // Action when clicking on Quit button
    public void QuitButton()
    {

        //Depending on this button is tested
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
