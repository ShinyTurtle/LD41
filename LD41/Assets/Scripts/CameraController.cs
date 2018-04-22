using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;
	private Vector3 playerPrevPos, playerMoveDir;
	private float distance;

	// Use this for initialization
	void Start() {
		offset = transform.position - player.transform.position;
		distance = offset.magnitude;

		playerPrevPos = player.transform.position;
	}

	// Runs every frame, but gauranteed to run after all items have been processed in Update
	void LateUpdate() 
	{
		/*playerMoveDir = player.transform.position - playerPrevPos;

		if (playerMoveDir != Vector3.zero)
		{
			playerMoveDir.Normalize();

			transform.position = player.transform.position - playerMoveDir * distance;
			float positionY = transform.position.y + 5f;
			transform.position = new Vector3(transform.position.x, positionY, transform.position.z);

			transform.LookAt(player.transform.position);

			playerPrevPos = player.transform.position;
		}*/
	}
}
