using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float currentTime;
    public float startingTime;

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
                startingTime = Random.Range(2, 7);
                currentTime = startingTime;
            }
        }
    }
}