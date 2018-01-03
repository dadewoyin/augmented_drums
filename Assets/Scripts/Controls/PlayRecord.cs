using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRecord : MonoBehaviour {

	private bool isRecording;
	private float timeCounter;

	// Use this for initialization
	void Start () {
		
	}

	public void onStartRecording() {
		timeCounter = 0f;
		isRecording = true;
		Debug.Log ("Play button");
	}
	
	// Update is called once per frame
	void Update () {
		if (isRecording) {
			timeCounter++;
//			Debug.Log ("We live baby");
		}
	}
}
