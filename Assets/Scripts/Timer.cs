using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public BoolVariable TimerEnabled;
    public FloatVariable MainTime;
    public FloatVariable MaxTime;
    public BoolVariable MaxTimeReached;
    public Event MaxTimeReachedEvent;

    void Update()
    {
        if (TimerEnabled.Value)
        {
            MainTime.SetValue(MainTime.Value += Time.deltaTime); 
        }        
        if (MainTime.Value > MaxTime.Value){
            MaxTimeReached.SetValue(true);
            TimerEnabled.SetValue(false);
            MainTime.SetValue(MaxTime.Value);
            MaxTimeReachedEvent.Raise();           
        }
    }    
}
