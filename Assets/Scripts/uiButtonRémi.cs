using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiButtonRémi : MonoBehaviour
{
    public void OnDeathRestartR()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1f;
    }

    public void OnDeathReturnR()
    {
        Debug.Log("Return");
    }
}
