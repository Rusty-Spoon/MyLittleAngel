using UnityEngine;
using System.Collections;

public class checkpoint : MonoBehaviour {
	public CheckpointController controller;
	
	public Vector3 respawnLocation;
	public bool triggered;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Player"))
		triggered = true;
		controller.GetLatestCheckpoint();
		respawnLocation = other.transform.position;
	}
}
