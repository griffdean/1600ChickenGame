using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	public float moveSpeed;
	public Transform target;

	void OnTriggerStay(Collider other){
		if (other.gameObject.name == "Farmer") {
			transform.LookAt (target);
			transform.Translate (Vector3.forward * -moveSpeed * Time.deltaTime);
		}
			
}
}
