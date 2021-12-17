using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiButtonQuentin : MonoBehaviour
{
    public void OnDeathRestartQ()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void OnDeathReturnQ()
    {
        SceneManager.LoadScene(8);
        Time.timeScale = 1f;
    }
}
