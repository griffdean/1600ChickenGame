using UnityEngine;
using System.Collections;

public class WolfAI : MonoBehaviour {

	public float moveSpeed;
	public Transform target;
	public int damage;

	void OnTriggerStay(Collider other){
		if (other.gameObject.name == "Farmer") {
			transform.LookAt (target);
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		}
	}

	void OnCollisionEnter(Collision other){
		var hit = other.gameObject;
		var health = hit.GetComponent<PlayerHealth> ();
		if(health != null){
			health.TakeDamage (damage);
		}
	}
}

