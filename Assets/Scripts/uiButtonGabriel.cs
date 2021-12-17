using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiButtonGabriel : MonoBehaviour
{
    public void OnDeathRestartG()
    {
        SceneManager.LoadScene(6);
        Time.timeScale = 1f;
    }

    public void OnDeathReturnG()
    {
        SceneManager.LoadScene(8);
        Time.timeScale = 1f;
    }
}
