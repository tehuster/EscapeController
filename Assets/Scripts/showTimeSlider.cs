using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showTimeSlider : MonoBehaviour {

	public FloatVariable MainTime;
	public FloatVariable MaxTime;
	private Slider MainTimeSlider;

	// Use this for initialization
	void Awake () {
		MainTimeSlider = GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
		float mappedValue = map(MainTime.Value, 0f,  MaxTime.Value, 0f, 1f);
		MainTimeSlider.value = mappedValue;		
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
