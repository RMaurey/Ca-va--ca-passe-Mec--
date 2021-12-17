using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiButtonEnzo : MonoBehaviour
{
    public void OnDeathRestartE()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1f;
    }

    public void OnDeathReturnE()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}