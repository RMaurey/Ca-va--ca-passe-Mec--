using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiButton : MonoBehaviour
{
    public void OnDeathRestart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void OnDeathReturn()
    {
        Debug.Log("Return");
    }
}
