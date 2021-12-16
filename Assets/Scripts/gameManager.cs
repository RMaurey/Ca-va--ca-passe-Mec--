using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class gameManager : MonoBehaviour
{
    public int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;
    public Timer time;
    public playerManager player;

    void FixedUpdate()
    {
        scoreText.text = score.ToString("0");
    }

    public void Bank(InputAction.CallbackContext ctx)
    {
        score = 9999;
    }
}
