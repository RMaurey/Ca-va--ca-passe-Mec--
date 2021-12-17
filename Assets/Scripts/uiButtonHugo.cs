using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiButtonHugo : MonoBehaviour
{
    public void OnDeathRestartH()
    {
        SceneManager.LoadScene(6);
        Time.timeScale = 1f;
    }

    public void OnDeathReturnH()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
