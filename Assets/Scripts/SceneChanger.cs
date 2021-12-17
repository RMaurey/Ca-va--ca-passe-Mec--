using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{

    public void loadEnzo()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1f;
    }

    public void loadAnton()
    {
        SceneManager.LoadScene(7);
        Time.timeScale = 1f;
    }

    public void loadQuentin()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }

    public void loadValentin()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1f;
    }

    public void loadRemi()
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 1f;
    }

    public void loadGabriel()
    {
        SceneManager.LoadScene(8);
        Time.timeScale = 1f;
    }

    public void loadLorenzo()
    {
        SceneManager.LoadScene(9);
        Time.timeScale = 1f;
    }

    public void loadHugo()
    {
        SceneManager.LoadScene(6);
        Time.timeScale = 1f;
    }

}
