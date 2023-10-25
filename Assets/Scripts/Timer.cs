using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 0;
    public bool timeIsRunning = true;
    public TMP_Text timeText;
    void Start()
    {
        timeIsRunning = true;
    }

    
    void Update()
    {
        if(timeIsRunning)
        {
            if(timeRemaining >= 0)
            {
                timeRemaining += Time.deltaTime;
                DisplayTime(timeRemaining);
            }
        }
        if(timeIsRunning)
        {
            if(timeRemaining >= 60)
            {
                timeIsRunning = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{00}",seconds);
    }
}
