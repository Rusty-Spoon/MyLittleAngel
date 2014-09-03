using UnityEngine;
using System.Collections;

public class FadeAndMove_doyou : MonoBehaviour {

	// Exposed variables
	public float fadeSpeed = 0.01f;
	public int wait = 860;
	public int waitExtra = 600;
	public float accelerate = 0.01f;
	public float topSpeed = 0.7f;
	public GameObject lensCap;
	
	private bool readyToGo = false;
	private Color tempColour;
	private Vector3 tempLoc;
	private Vector3 deltaPos;
	private Vector3 lastLoc;

	// Use this for initialization
	void Start () {
		lastLoc.x = 0.0f;
		lastLoc.y = 0.0f;
		lastLoc.z = 0.0f;
		lastLoc = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!readyToGo)
		{
			if (wait > 0)
				{
					wait -= 1;
				}
				else
				{
					wait = 0;
				}


			if (wait == 0)
			{
				FadeUp();
				if (waitExtra > 100)
				{
					waitExtra -= 1;
				}
				else
				{
					waitExtra = 0;
				}
			}
		}

		if (readyToGo)
		{
			if (waitExtra <= 0) 
			{
				FadeOut();
			}
		}

	}

	void FadeUp()
	{
		if (lensCap.renderer.material.color.a > 0.0f)
		{
			readyToGo = false;
			tempColour = lensCap.renderer.material.color;
			tempColour.a -= fadeSpeed;
			lensCap.renderer.material.color = tempColour;
		}
		else
		{
			tempColour = lensCap.renderer.material.color;
			tempColour.a = 0.0f;
			lensCap.renderer.material.color = tempColour;
			readyToGo  = true;
		}
	}

	void FadeOut()
	{
		if (lensCap.renderer.material.color.a < 1.0f)
		{
			tempColour = lensCap.renderer.material.color;
			tempColour.a += fadeSpeed;
			lensCap.renderer.material.color = tempColour;
		}

		if (lensCap.renderer.material.color.a >= 1.0f)
		{
			Application.LoadLevel(1);

		}
	}
}
