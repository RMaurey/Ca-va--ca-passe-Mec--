using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiButtonLorenzo : MonoBehaviour
{
    public void OnDeathRestartLo()
    {
        SceneManager.LoadScene(9);
        Time.timeScale = 1f;
    }

    public void OnDeathReturnLo()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
