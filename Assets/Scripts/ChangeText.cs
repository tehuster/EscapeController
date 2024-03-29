﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour {
	private Text thisText;
	public BoolVariable PlayPauseToggle;

	private void Awake() {
		thisText = GetComponent<Text>();
	}

	public void changeText(){			
		if(PlayPauseToggle.Value){
			thisText.text = "PLAY";
		}else{
			thisText.text = "PAUSE";
		}
	}	
}
