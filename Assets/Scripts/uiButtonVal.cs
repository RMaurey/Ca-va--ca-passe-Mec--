using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiButtonVal : MonoBehaviour
{
    public void OnDeathRestartV()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1f;
    }

    public void OnDeathReturnV()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
