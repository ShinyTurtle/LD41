using System.Collections;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {

	public GameObject blockPrefab;
	public int numberOfBlocks;
	public GameObject[] colorPrefabs;
	public Material[] colorMaterials;

	// Use this for initialization
	void Start () {
		// Initialize color prefab array


		for (int i = 0; i < numberOfBlocks; i++)
		{
			// Random position
			var spawnPosition = new Vector3(
				                   Random.Range(-8, 8),
				                   -0.5f,
				                   Random.Range(-8, 8));
		
			// Fixed rotation
			var spawnRotation = new Quaternion(
				                   0,
				                   0,
				                   0,
				                   0);

			var block = (GameObject)Instantiate(blockPrefab, spawnPosition, spawnRotation);

			var renderer = GetComponent<Renderer>();
			if (renderer != null)
			{
				renderer.material = colorMaterials[0];
			}
		}
	}
}
