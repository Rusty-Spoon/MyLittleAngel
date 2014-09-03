using UnityEngine;
using System.Collections;

public class TimedLevelChange : MonoBehaviour {
	public string LevelToLoad;
	public int delay;
	public GameObject lensCap; 

	private bool readyToFadeUp;
	private Color tempColor;

	// Use this for initialization
	void Start () {
		readyToFadeUp = true;
	}
	
	// Update is called once per frame
	void Update()
	{
		if (readyToFadeUp) FadeUp ();

		if (!readyToFadeUp) WaitABit();
	}

	void FadeUp()
	{
		if (lensCap.renderer.material.color.a > 0.0f)
			{
				tempColor = lensCap.renderer.material.color;
				tempColor.a -= 0.01f;
				lensCap.renderer.material.color = tempColor;
			}
		if (lensCap.renderer.material.color.a <= 0.0f)
			{
				tempColor = lensCap.renderer.material.color;
				tempColor.a = 0.0f;
				lensCap.renderer.material.color = tempColor;
				readyToFadeUp = false;
			}
	}

	void FadeDown()
	{
		if (lensCap.renderer.material.color.a <= 1.0f)
		{
			tempColor = lensCap.renderer.material.color;
			tempColor.a += 0.01f;
			lensCap.renderer.material.color = tempColor;
		}
		if (lensCap.renderer.material.color.a >= 1.0f)
		{
			tempColor = lensCap.renderer.material.color;
			tempColor.a = 1.0f;
			lensCap.renderer.material.color = tempColor;
			if (LevelToLoad != "")
				Application.LoadLevel(LevelToLoad);
		}
	}

	void WaitABit()
	{
		if (delay > 0)
		{
			delay -= 1;
		}
		if (delay == 0)
		{
			FadeDown();
		}
	}
}