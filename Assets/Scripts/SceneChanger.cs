using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{

    public void loadEnzo()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void loadAnton()
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 1f;
    }

    public void loadQuentin()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void loadValentin()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }

    public void loadRemi()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1f;
    }

    public void loadGabriel()
    {
        SceneManager.LoadScene(6);
        Time.timeScale = 1f;
    }

    public void loadLorenzo()
    {
        SceneManager.LoadScene(7);
        Time.timeScale = 1f;
    }

    public void loadHugo()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1f;
    }

}
