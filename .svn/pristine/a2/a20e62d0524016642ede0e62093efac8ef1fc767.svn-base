using UnityEngine;
using System.Collections;

public class lightflicker : MonoBehaviour {

	float timeOn = 0.1f;
	float timeOff = 0.5f;
	private float changeTime = 0.0f;
	
	void Update() {
		if (Time.time > changeTime) {
			light.enabled = !light.enabled;
			if (light.enabled) {
				changeTime = Time.time + timeOn;
			} else {
				changeTime = Time.time + timeOff;
			}
		}
	}
}
