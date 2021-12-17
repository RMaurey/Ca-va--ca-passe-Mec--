using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiButtonAnton : MonoBehaviour
{
    public void OnDeathRestartA()
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 1f;
    }

    public void OnDeathReturnA()
    {
        SceneManager.LoadScene(8);
        Time.timeScale = 1f;
    }
}
