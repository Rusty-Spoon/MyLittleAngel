using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

	public float threshold = -4.0f;
	public float newHeight = -0.1f;
	private Vector3 temporaryLocation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (transform.position.y < threshold)
		{
			temporaryLocation.y = 0.5f;
			temporaryLocation.x = -0.1f;
			temporaryLocation.z = transform.position.z;
			transform.position = temporaryLocation;
		}

	}
}
