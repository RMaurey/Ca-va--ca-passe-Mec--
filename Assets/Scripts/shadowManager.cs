using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shadowManager : MonoBehaviour
{
    public Timer time;
    private int rnd;
    public Sprite[] Sprites;
    public int spriteValue;
    void FixedUpdate()
    {
        if (time.currentTime == 0)
        {
            rnd = Random.Range(0, Sprites.Length);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprites[rnd];
            spriteValue = rnd;
        }

    }
}
