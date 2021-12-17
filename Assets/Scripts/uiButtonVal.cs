using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiButtonVal : MonoBehaviour
{
    public void OnDeathRestartV()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }

    public void OnDeathReturnV()
    {
        SceneManager.LoadScene(8);
        Time.timeScale = 1f;
    }
}
