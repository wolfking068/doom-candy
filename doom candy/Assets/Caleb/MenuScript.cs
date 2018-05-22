﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public float Delay;
    float t = 0;
    public void StartGame()
    {
        while (t < 1)
        {
            t += Time.deltaTime / Delay;
            SceneManager.LoadScene("GameMode");
        }
    }

    public void controls()
    {
        while (t < 1)
        {
            t += Time.deltaTime / Delay;
            SceneManager.LoadScene("ControlsMenu");
        }
    }

    public void PvP()
    {
        while (t < 1)
        {
            t += Time.deltaTime / Delay;
            SceneManager.LoadScene("");
        }
    }

    public void Caracter()
    {
        while (t < 1)
        {
            t += Time.deltaTime / Delay;
            SceneManager.LoadScene("");
        }
    }

    public void PvE()
    {
        while (t < 1)
        {
            t += Time.deltaTime / Delay;
            SceneManager.LoadScene("");
        }
    }

    public void MainMenu()
    {
        while (t < 1)
        {
            t += Time.deltaTime / Delay;
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void QuitGame()
    {
        while (t < 1)
        {
            t += Time.deltaTime / Delay;
            Application.Quit();
        }
    }

}
