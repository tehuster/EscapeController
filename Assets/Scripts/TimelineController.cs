using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimelineController : MonoBehaviour
{

    [SerializeField] private Text uiStartPauseText;
    [SerializeField] private Text uiTimeRemainingText;
    [SerializeField] private Slider uiTimeRemainingSlider;
    [SerializeField] private float timeDuration;

    private float time;
    private int minutes;
    private int seconds;
    private bool timeEnabled = false;
    private bool doOnce = false;

    void Start()
    {
        time = timeDuration * 60;
    }

    void Update()
    {

        if (time >= 0.0f && timeEnabled)
        {
            time -= Time.deltaTime;
            minutes = Mathf.FloorToInt(time / 60F);
            seconds = Mathf.FloorToInt(time - minutes * 60);
            uiTimeRemainingText.text = "TIME REMAINING: " + string.Format("{0:0}:{1:00}", minutes, seconds);
            uiTimeRemainingSlider.value = map(time, 0, timeDuration*60, 1, 0);
        }
        else if (time <= 0.0f && !doOnce)
        {
            timeEnabled = false;
            doOnce = true;
            uiTimeRemainingText.text = "GAME OVER";
            time = 0.0f;
        }
    }

    public void startTime()
    {
        Debug.Log("Hi");
        timeEnabled = !timeEnabled;
        if (timeEnabled == true)
        {
            uiStartPauseText.text = "PAUSE";
        }
        else if (timeEnabled == false)
        {
            uiStartPauseText.text = "START";
        }
    }

 private float map(float from, float fromMin, float fromMax, float toMin,  float toMax)
    {
        var fromAbs  =  from - fromMin;
        var fromMaxAbs = fromMax - fromMin;      
       
        var normal = fromAbs / fromMaxAbs;
 
        var toMaxAbs = toMax - toMin;
        var toAbs = toMaxAbs * normal;
 
        var to = toAbs + toMin;
       
        return to;
    }

}
