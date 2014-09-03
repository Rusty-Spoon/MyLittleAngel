using UnityEngine;
using System.Collections;

public class ZombieKill : MonoBehaviour
{
	public CheckpointController controller;
	public GameObject lensCap;
	public bool fadeUpFlag = true;
	private Vector3 tempPos;
	public float verticalOffsetForRespawn = 4.0f;

	void OnTriggerEnter (Collider other)
	{

		if (other.CompareTag ("Enemy"))
		{
			tempPos = controller.WhereIsLatestCheckpoint();
			tempPos.y += verticalOffsetForRespawn;
			FadeDown();
			transform.position = tempPos;
			Vector3 nullVelocity;
			nullVelocity.x = 0.0f;
			nullVelocity.y = 0.0f;
			nullVelocity.z = 0.0f;
			rigidbody.velocity = nullVelocity;
			if (fadeUpFlag)
			FadeUp();
		}
	}

	void FadeDown()
	{
		Color tempColor;
			tempColor = lensCap.renderer.material.color;
			tempColor.a = 1.00f;
			lensCap.renderer.material.color = tempColor;		
	}
	
	void FadeUp()
	{
		Color fading;
		while (lensCap.renderer.material.color.a >= 0.01f)
		{
			fading = lensCap.renderer.material.color;
			fading.a -= 0.1f;
			lensCap.renderer.material.color = fading;
		}
		fading = lensCap.renderer.material.color;
		fading.a = 0.0f;
		lensCap.renderer.material.color = fading;
	}
}