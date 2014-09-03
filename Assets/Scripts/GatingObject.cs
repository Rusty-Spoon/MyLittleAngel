using UnityEngine;
using System.Collections;

public class GatingObject : MonoBehaviour {
	
	public LevelChanger oper;

	// Use this for initialization
	void Start () 
	{	
		oper.activeGate = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other) {

		if (other.gameObject.tag == "Player")
		{
			oper.activeGate = true;
			DestroyObject(GameObject.FindGameObjectWithTag("Axe"));
		}

	}
}