using UnityEngine;
using System.Collections;

public class CheckpointController : MonoBehaviour {
	
	public checkpoint[] createdCheckpoints;
	public int latestCheckpoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	// This method should get called when the player collides with a checkpoint, this is in the checkpoint script.
	public int GetLatestCheckpoint()
	{
		for (int i = createdCheckpoints.Length - 1; i >= 0; i--)
		{
			if (createdCheckpoints[i].triggered)
			{
				latestCheckpoint = i;
				break;
			}
		}
		return latestCheckpoint;
	}

	public Vector3 WhereIsLatestCheckpoint()
	{
		return createdCheckpoints[GetLatestCheckpoint()].respawnLocation;
	}
}
