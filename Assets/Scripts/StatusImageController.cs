using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusImageController : MonoBehaviour {	
	private RawImage StatusImage; 	
	public Texture[] Textures;

	private void Awake() {
		StatusImage = GetComponent<RawImage>();
	}
	public void setStatusImage(int status){
		StatusImage.texture = Textures[status];
	}
}
