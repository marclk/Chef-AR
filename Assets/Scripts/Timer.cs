using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Diagnostics;

public class Timer : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;

    public float deleteTimerTimeLeft = 5;

    public TextMeshProUGUI TimerTxt;
    public AudioSource audioSource;
    public GameObject gameObject;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource.Stop();
        TimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerOn)
        {
            TimeLeft -= Time.deltaTime;
            updateTimer(TimeLeft);
            if (TimeLeft <= 0)
            {
                UnityEngine.Debug.Log("0");
                TimerOn = false;
                audioSource.Play();
            }
        }
        else
        {
            UnityEngine.Debug.Log("Time is UP!");
            TimeLeft = 0;
            deleteTimerTimeLeft -= Time.deltaTime;
            if (deleteTimerTimeLeft <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
