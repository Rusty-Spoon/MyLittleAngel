﻿using UnityEngine;
using System.Collections;

namespace Fungus
{
	/**
	 * Attach this component to a sprite object to apply a simple parallax scrolling effect.
	 * The parallax offset is calculated based on the distance from the camera to the position of the parent Room.
	 */
	public class Parallax : MonoBehaviour 
	{
		/**
		 * Scale factor for calculating the parallax offset.
		 */
		public Vector2 parallaxScale = new Vector2(0.25f, 0f);

		Vector3 startPosition;

		Room parentRoom;

		void Start () 
		{
			// Store the starting position of the sprite object
			startPosition = transform.position;

			// Store a reference to the parent Room object
			Transform ancestor = transform.parent;
			while (ancestor != null)
			{
				Room room = ancestor.GetComponent<Room>();
				if (room != null)
				{
					parentRoom = room;
					break;
				}
				ancestor = ancestor.transform.parent;
			}
		}

		void Update () 
		{
			if (parentRoom == null)
			{
				// Don't apply offset if the sprite is not a child of a Room
				return;
			}

			if (Game.GetInstance().activeRoom != parentRoom)
			{
				// Early out if this sprite is not in the currently active Room
				return;
			}

			Vector3 offset = Game.GetInstance().GetParallaxOffset(parallaxScale);
	
			// Set new position for sprite
			transform.position = startPosition + offset;
		}
	}
}
