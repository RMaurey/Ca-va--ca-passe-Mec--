using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiButtonEnzo : MonoBehaviour
{
    public void OnDeathRestartE()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void OnDeathReturnE()
    {
        SceneManager.LoadScene(8);
        Time.timeScale = 1f;
    }
}