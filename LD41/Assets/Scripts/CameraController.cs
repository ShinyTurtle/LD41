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
}
