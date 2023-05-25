using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Canvas playerUI;
    bool isPaused = false;

    void Start()
    {
        GetComponent<Canvas>().enabled= false;
        playerUI = playerUI.GetComponent<Canvas>();
    }

    public void MenuPausa()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            Time.timeScale = 0;
            playerUI.enabled = false;
            GetComponent<Canvas>().enabled = true;
            Cursor.visible = true;
        }
        else
        {
            Time.timeScale = 1;
            playerUI.enabled = true;
            GetComponent<Canvas>().enabled = false;
            Cursor.visible = false;
        }
    }

    public void QuitBtn()
    {
        Application.Quit();
    }
}
