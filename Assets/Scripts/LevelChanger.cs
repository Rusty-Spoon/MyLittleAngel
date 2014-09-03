using UnityEngine;
using System.Collections;

public class LevelChanger : MonoBehaviour {

	// Exposed variables
	public bool activeGate = true;														// Is the gate active? True by default – can be blocked by key script.
	public GameObject pointToLensCap;													// Allow control over the fade.
	public string levelName = "Enter level name here. Names are case-sensitive.";		// The name of the level to call on trigger.
	public float fadeRate = 0.01f;														// The rade of the fade out.

	// Private variables
	private bool fadeUp = false;				// Set to fade up?
	private bool fadeDown = false;				// Set to fade down?
	private Color fading;						// The value of the opacity

	// Use this for initialization
	void Start () {
		fadeUp = true;							// Set the fade up to true
		fading.a = 1.0f;						// Set the opacity to full
		fading.r = 0.0f;						// Zero out the other values
		fading.g = 0.0f;
		fading.b = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

		if (fadeUp)
		{
			FadingUp();							// If the fade up flag is true, fade up
		}

		if (fadeDown && activeGate)
		{
			FadingDown();						// If the fade down flag is true AND the active gate flag is true, fade down
		}

	}

	// The method for fading up from full opacity to fully transparent.
	void FadingUp() {
		if (pointToLensCap.renderer.material.color.a > 0)			// if the lens cap is anything other than completely transparent
		
		{
			fading.a -= fadeRate;									// Subtract the fade rate
			pointToLensCap.renderer.material.color = fading;		// Apply the new colour to the lens cap
		}
		else
		{
			fading.a = 0;											// If the lens cap is completely transparent
			pointToLensCap.renderer.material.color = fading;		// Confirm this by setting it to exactly zero opacity	
			fadeUp = false;											// False out the fade up flag – we've faded up!
		}	
	}

	// The method to initialise a fade down
	public void FadingDown() {						
		if (pointToLensCap.renderer.material.color.a < 1.0f)		// FIXED the alpha value down to 1.0f from erroneous 254.0f
																	// If the lens cap is anything other than completely opaque
		{
			fading.a += fadeRate;									// Add the fade rate
			pointToLensCap.renderer.material.color = fading;		// Assign the colour to the material with the new opacity
		}
		else
		{															// If the lens cap is completely opaque
			fading.a = 1.0f;										// Set the opacity to full (FIXED the opacity by setting it to 1.0f)
			pointToLensCap.renderer.material.color = fading;		// Assign the new opacity value
			fadeDown = false;										// False out the fade down flag - we're done
			CallNextLevel();										// Call the next level
		}
		CallNextLevel();											// TODO fix this function so that action is frozen and the fade out happens fast.
	}

	// Checking for trigger alerts
	void OnTriggerEnter(Collider other) {
		if(other.CompareTag ("Player"))								// Check to see if this object is colliding with the player.

			fadeDown = true;										// If it is, and we're triggered, set the fadedown flag to true.
	}

	// Call the next level
	void CallNextLevel() {

			Application.LoadLevel(levelName);						// Load the next level using the string variable from the start of the class. 
	}
}
