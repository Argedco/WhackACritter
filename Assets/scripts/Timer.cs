using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    //Display Visual Timer
    public TextMesh displayText;

    //Starting time for the timer.
    public float timerDuration;

    //Seconds remeaning on the timer
    private float timeRemaining = 0;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		if (IsTimerRunning())
        {
            //Timer Is running, so process.

            //Updated the time remaining this frame
            timeRemaining = timeRemaining - Time.deltaTime;

            //Check if we have run out of time
            if (timeRemaining <= 0)
            {
                StopTimer();
            }

            //Update the visual display
            displayText.text = Mathf.CeilToInt(timeRemaining).ToString();
        }
	}

    public void StartTimer()
    {
        timeRemaining = timerDuration;
        displayText.text = Mathf.CeilToInt(timeRemaining).ToString();

    }

    public void StopTimer()
    {
        displayText.text = Mathf.CeilToInt(timeRemaining).ToString();
        timeRemaining = 0;
    }

    //Is the timer currently running?
    public bool IsTimerRunning()
    {
        if (timeRemaining != 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
