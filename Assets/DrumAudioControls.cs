using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumAudioControls : MonoBehaviour {

	AudioSource m_MyAudioSource;

	//Play the music
	private bool m_Play;
	//Detect when you use the toggle, ensures music isn’t played multiple times
	private bool m_ToggleChange;

	// Use this for initialization
	void Start () {
		//Fetch the AudioSource from the GameObject
		m_MyAudioSource = GetComponent<AudioSource>();
		//Ensure the toggle is set to true for the music to play at start-up
		m_Play = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
