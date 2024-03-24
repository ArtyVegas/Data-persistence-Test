using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainUIHandler : MonoBehaviour
{
    // Action when clicking on Menu Button
    public void MenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
