using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	public string levelToLoad;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey("enter") || Input.GetKey("return"))
		{
			Application.LoadLevel(levelToLoad);
		}
		if (Input.GetKey("escape"))
		{
			Application.Quit();
		}
	}
}