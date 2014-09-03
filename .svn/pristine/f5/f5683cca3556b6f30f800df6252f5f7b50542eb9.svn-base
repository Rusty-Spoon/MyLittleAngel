using UnityEngine;
using System.Collections;

public class EnemyControllerCs : MonoBehaviour {

	public Transform targetToChase;
	public float moveSpeed = 3;
	public float rotationSpeed = 3;
	public float radiusOfSearch = 25;

	private float clampNear = 4.5f;					// Clamp high X
	private float clampFar = -4.279793f;				// Clamp low X
	public float clampLeft;							// Clamp low Z
	public float clampRight;						// Clamp high Z
	public float clampHeight;						// Clamp low Y

	public int upperLimitOfWaitToTurn = 600;

	private int waitToTurn = 500;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		if (CheckDistance ()) {
			FindPlayer ();
				} else {
			Wander ();
				}
		transform.position = Clamp (transform.position);

	}

	void FindPlayer()
	{
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(targetToChase.position - transform.position), rotationSpeed*Time.deltaTime);
		transform.position += transform.forward * moveSpeed * Time.deltaTime;

	}

	bool CheckDistance()
	{
		float x1 = targetToChase.position.x;
		float y1 = targetToChase.position.y;
		float z1 = targetToChase.position.z;

		float x2 = transform.position.x;
		float y2 = transform.position.y;
		float z2 = transform.position.z;

		float xDist = x1 - x2;
		float yDist = y1 - y2;
		float zDist = z1 - z2;

		if (xDist < 0) xDist *= -1;
		if (yDist < 0) yDist *= -1;
		if (zDist < 0) zDist *= -1;

		if (
			xDist <= radiusOfSearch
			&&
			yDist <= radiusOfSearch
			&&
			zDist <= radiusOfSearch
			) {
						return true;
				} else {
			return false;
				}
	}

	void Wander()
	{
		if (waitToTurn > 0)
		{
			waitToTurn -= 1;
		}

		if (waitToTurn < 1)
		{
			float willITurn = Random.value;
			if (willITurn > 0.5)
			{
				transform.rotation *= Quaternion.Euler(0.0f, 90.0f, 0.0f);
				waitToTurn = (int)(Random.value * upperLimitOfWaitToTurn);
			}
			else
			{
				transform.rotation *= Quaternion.Euler(0.0f, -90.0f, 0.0f);
				waitToTurn = (int)(Random.value * upperLimitOfWaitToTurn);
			}

		}


		transform.position += transform.forward * moveSpeed * Time.deltaTime;

	}

	Vector3 Clamp(Vector3 playerPosition)
	{
		// Clamp left and right
		playerPosition.z = Mathf.Clamp(playerPosition.z, clampLeft, clampRight);
		
		// Clamp near and far
		playerPosition.x = Mathf.Clamp(playerPosition.x, clampFar, clampNear);

		// Clamp height
		playerPosition.y = Mathf.Clamp(playerPosition.y, clampHeight, clampHeight);
		
		return playerPosition;
	}
}
