using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTimeText : MonoBehaviour {
	private Text thisText;
	private float seconds;
	private float minutes;
	public FloatVariable mainTime;
	

	private void Awake() {
		thisText = GetComponent<Text>();
	}

	private void Update() {
		minutes = Mathf.FloorToInt(mainTime.Value / 60F);
        seconds = Mathf.FloorToInt(mainTime.Value - minutes * 60);
        thisText.text = "ELAPSED TIME: " + string.Format("{0:0}:{1:00}", minutes, seconds);
	}
}