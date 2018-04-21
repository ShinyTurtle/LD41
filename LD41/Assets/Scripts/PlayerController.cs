using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	public float speed;

	//private Rigidbody rb;

	// Called on the first frame that the script is active
	void Start()
	{
		//rb = GetComponent<Rigidbody>();
	}

	// Called before rendering a frame
	void Update() 
	{
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);

		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			Fire();
		}
	}

	// Called before performing any physics calculations
	void FixedUpdate()
	{
		/*float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		// Set y to z since we don't want the player to move up at all
		Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

		rb.AddForce(movement * speed);*/
	}

	void Fire() 
	{
		// Create the Bullet from the Bullet Prefab
		var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

		// Add velocity to the bullet
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

		// Destroy the bullet after 2 seconds
		Destroy(bullet, 2.0f);
	}
}