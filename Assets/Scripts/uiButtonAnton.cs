using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiButtonAnton : MonoBehaviour
{
    public void OnDeathRestartA()
    {
        SceneManager.LoadScene(7);
        Time.timeScale = 1f;
    }

    public void OnDeathReturnA()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
