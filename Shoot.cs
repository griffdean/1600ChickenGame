using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public Rigidbody bullet;
	public Transform SpawnPoint;
	public int shootSpeed;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			Rigidbody clone;
			clone = (Rigidbody)Instantiate (bullet, SpawnPoint.position, bullet.rotation);
			clone.velocity = SpawnPoint.TransformDirection (Vector3.forward * shootSpeed);
		}
	}
}
