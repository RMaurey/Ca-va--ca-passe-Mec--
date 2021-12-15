using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    private bool spritesEquals = false;
    public Timer time;
    public playerManager player;
    public shadowManager shadow;
    void FixedUpdate()
    {
        if (player.playerInt == shadow.spriteValue)
        {
            spritesEquals = true;
        }
        else spritesEquals = false;

        if (time.currentTime == 1)
        {
            Debug.Log("bien joué");
        }
    }
}
