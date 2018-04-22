using System.Collections;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {

	public GameObject blockPrefab;
	public int numberOfBlocks;

	// Use this for initialization
	void Start () {
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
		}
	}
}
