using UnityEngine;
using System.Collections;

public class Flicker : MonoBehaviour {

	private Color tint;
	public float saturation = 5.0f;
	private int intervalCount;
	public int intervalTarget = 15;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (intervalCount == intervalTarget)
		{
			tint.b = Random.value * saturation;
			tint.r = Random.value * saturation;
			tint.g = Random.value * saturation;

			renderer.material.color = tint;
			intervalCount = 0;
		}
		else
		{
			intervalCount += 1;
		}
	}
}
