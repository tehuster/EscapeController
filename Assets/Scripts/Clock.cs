using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public BoolVariable PlayPauseBool;
    public FloatVariable MainTime;
    public FloatVariable MaxTime;
    public BoolVariable MaxTimeReached;
    public Event MaxTimeReachedEvent;

    private void Awake() {
        MainTime.SetValue(0f);
        PlayPauseBool.SetValue(false);
        MaxTimeReached.SetValue(false);        
    }

    void Update()
    {
        if (PlayPauseBool.Value)
        {
            MainTime.SetValue(MainTime.Value += Time.deltaTime); 
        }        
        if (MainTime.Value > MaxTime.Value){
            MaxTimeReached.SetValue(true);
            PlayPauseBool.SetValue(false);
            MainTime.SetValue(MaxTime.Value);
            MaxTimeReachedEvent.Raise();           
        }
    }    
}
