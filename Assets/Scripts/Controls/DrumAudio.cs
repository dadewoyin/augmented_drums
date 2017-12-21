using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumAudio : MonoBehaviour {

	AudioSource m_MyAudioSource;

	// Use this for initialization
	void Start () {
		
		//Fetch the AudioSource from the GameObject
		m_MyAudioSource = GetComponent<AudioSource>();

	}

	void OnMouseDown() {
		Debug.Log ("Testing");
		m_MyAudioSource.Play ();
		Debug.Log (m_MyAudioSource);
	}	

	// Update is called once per frame
	void Update () {
		//Debug.Log("Update");
	}

}
