using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

	public Material[] colorMaterials;

	// Use this for initialization
	void Start () {
		// Set the color of the block to a random color
		/*Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
		GetComponent<Renderer>().material.color = newColor;*/

		var renderer = GetComponent<Renderer>();
		if (renderer != null)
		{
			int colorIndex = Random.Range(0, colorMaterials.Length);
			renderer.material = colorMaterials[colorIndex];
		}
	}
}
