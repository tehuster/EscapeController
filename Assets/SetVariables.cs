using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVariables : MonoBehaviour {
	
	public float mainTime;
	public bool mainTimeEnabled;	
	public FloatVariable mainTimeSO;
	public BoolVariable mainTimeEnabledSO;

	[HideInInspector]
	public int currentTab;
	public string currentTabString;

	void Awake () {
		mainTimeSO.SetValue(mainTime);
		mainTimeEnabledSO.SetValue(mainTimeEnabled);
	}
}
