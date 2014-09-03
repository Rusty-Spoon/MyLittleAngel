using UnityEngine;
using System.Collections;

public class FadeAndMove : MonoBehaviour {

	// Exposed variables
	public float fadeSpeed = 0.01f;
	public float wait = 190;
	public float accelerate = 0.01f;
	public float topSpeed = 0.7f;
	public GameObject lensCap;

	private bool checkedLoc = false;
	private bool readyToGo = false;
	private Color tempColour;
	private Vector3 tempLoc;
	// private Vector3 lastLoc;
	private Vector3 deltaPos;

	// Use this for initialization
	void Start () {
		// lastLoc = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if (!readyToGo)
		{														// Fade up
			FadeUp ();
		}

		// Extra pause
		if (readyToGo)
		{
			if (wait > 0)
			{
				wait -= 1;
			}
			else
			{
				wait = 0;
			}
		}

		if (wait == 0)
		{
			MoveCredits();
		}

	}

	void MoveCredits()
	{

		if (!checkedLoc)
		{	// Take first location and measure it
			tempLoc = transform.position;
			checkedLoc = true;
		}

		Vector3 moveUp;
		moveUp.x = 0.0f;
		moveUp.y = 0.06f;
		if (moveUp.y < topSpeed)
		{
			moveUp.y = 0.1f + deltaPos.y;
		}

		moveUp.z = 0.0f;

		transform.position += moveUp;

		// Calculate delta from original location
		deltaPos = tempLoc - transform.position;

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
}
