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
        Debug.Log("Return");
    }
}