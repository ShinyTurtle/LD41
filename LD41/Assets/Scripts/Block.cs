using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Set the color of the block to a random color
		Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
		GetComponent<Renderer>().material.color = newColor;
	}
}
