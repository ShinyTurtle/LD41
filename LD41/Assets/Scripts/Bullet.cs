using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
	{
		// Handle collision with a block
		var collisionObj = collision.gameObject;
		if (collisionObj.CompareTag("Block"))
		{
			// Collided with a block
			collisionObj.GetComponent<Block>().OnHit();
		}

		// Destroy the bullet
		Destroy(gameObject);
	}
}
