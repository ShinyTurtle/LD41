using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

	public Material[] colorMaterials;

	private BlockSpawner spawner;
	private Material myMaterial;

	// Use this for initialization
	void Start () {
		spawner = GameObject.FindObjectOfType(typeof(BlockSpawner)) as BlockSpawner;

		var renderer = GetComponent<Renderer>();
		if (renderer != null)
		{
			int colorIndex = Random.Range(0, colorMaterials.Length);
			myMaterial = colorMaterials[colorIndex];
			renderer.material = myMaterial;
		}
	}

	public void OnHit()
	{
		// Determine if any objects next to this one are the same color
		Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position, /*new Vector3(0.5f, 0.5f, 0.5f)*/ transform.localScale / 2);

		int multiplier = 1;
		foreach (Collider collider in hitColliders)
		{
			if (collider.gameObject.CompareTag("Block") && gameObject != collider.gameObject)
			{
				var renderer = collider.gameObject.GetComponent<Renderer>();

				if (renderer.material.color.Equals(myMaterial.color))
				{
					collider.gameObject.GetComponent<Block>().OnSame(multiplier);
					multiplier++;
				}
			}
		}
		
		spawner.BlockDestroyed(multiplier);
		Destroy(gameObject);
	}

	public void OnSame(int multiplier)
	{
		spawner.BlockDestroyed(multiplier);
		Destroy(gameObject);
	}
}
