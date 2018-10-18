using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeNode : MonoBehaviour {

	[Header("Node Info")] 
	public string NodeName;
	public string NodeDescription;
	public string NodeStatus;
	public string NodeNetworkStatus;
	public string NodeInput;
	public string NodeOutput;
	public string NodeTime;

	[Header ("GameObjects")]
	private NodeUI NodeUI;
	public StatusImageController StatusImageController;
	public enum Status {Idle, Activated, Completed, Failed};
	
	// Use this for initialization
	void Awake () {
		NodeUI = GetComponent<NodeUI>();
	}

	public void setNodeStatus(int status){
		Status stat = (Status) status;					//convert int to enum
		NodeStatus = stat.ToString();					//convert enum to string
		NodeUI.setNodeStatus(NodeStatus);				//set UI text
		StatusImageController.setStatusImage(status);	//set UI img
	}
}
