using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
	{
		// Handle collision with a block
		var collisionObj = collision.gameObject;
		if (collisionObj.CompareTag("Block"))
		{
			// Collided with a block - destroy the block
			Destroy(collisionObj);
		}

		// Destroy the bullet
		Destroy(gameObject);
	}
}
