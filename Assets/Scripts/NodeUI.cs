using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour {	
	public EscapeNode EscapeNode;
	public Text NodeName;
	public Text NodeDescription;
	public Text NodeStatus;
	public Text NodeNetworkStatus;
	public Text NodeInput;
	public Text NodeOutput;
	public Text NodeTime;
	private void Awake() {
		NodeName.text = EscapeNode.NodeName;
		NodeDescription.text = EscapeNode.NodeDescription;
		NodeStatus.text = EscapeNode.NodeStatus;
		NodeNetworkStatus.text = EscapeNode.NodeNetworkStatus;
		NodeInput.text = EscapeNode.NodeInput;
		NodeOutput.text = EscapeNode.NodeOutput;
		NodeTime.text = EscapeNode.NodeTime;
	}

	public void setNodeStatus(string nodestatus){
		NodeStatus.text = nodestatus;
	}
}
