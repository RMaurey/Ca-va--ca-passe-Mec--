using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public gameManager game;
    public playerManager player;
    public float currentTime;
    public float startingTime;
    private int rnd;
    public Sprite[] Sprites;
    public int spriteValue;
    [SerializeField] GameObject Shadow;

    [SerializeField] TextMeshProUGUI timerText;

    void Start()
    {
        currentTime = startingTime;
        StartCoroutine(RunTimer());
    }

    private IEnumerator RunTimer()
    {
        while (true)
        {
            currentTime -= 1;
            timerText.text = currentTime.ToString("0");
            yield return new WaitForSeconds(1);

            if (currentTime == 0)
            {
                StartCoroutine(ScoreTest());
                startingTime = Random.Range(2, 5);
                currentTime = startingTime;
                rnd = Random.Range(0, Sprites.Length);
                Shadow.gameObject.GetComponent<SpriteRenderer>().sprite = Sprites[rnd];
                spriteValue = rnd;
            }
        }
    }

    private IEnumerator ScoreTest()
    {
        if (player.playerInt == spriteValue)
        {
            game.score += 1;
        }
        else
        {
            Debug.Log("loose");
        }

        yield return null;
    }
}