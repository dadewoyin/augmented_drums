using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class DrumAudio : MonoBehaviour, IInputClickHandler {

	AudioSource m_MyAudioSource;

	struct Drum {
		public float DrumTime;
		public object DrumSound;
	}

	void GetDrumTime(object drumSound) {

		Drum drum;
		drum.DrumTime = FindObjectOfType<MetronomePro_Player> ().amount;
		drum.DrumSound = drumSound;

		Debug.Log("drum time:");
		Debug.Log(drum.DrumTime);

		Debug.Log("drum sound:");
		Debug.Log(drum.DrumSound);
	}

	// Use this for initialization
	void Start () {
		
		// Fetch the AudioSource from the GameObject
		m_MyAudioSource = GetComponent<AudioSource>();

	}

	public void OnInputClicked(InputClickedEventData eventData) {
		Debug.Log ("Testing");
		m_MyAudioSource.Play ();
		Debug.Log (m_MyAudioSource);

		GetDrumTime(m_MyAudioSource);
	}	

	// Update is called once per frame
	void Update () {
		//Debug.Log("Update");
	}

}
