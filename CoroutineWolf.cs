using UnityEngine;
using System.Collections;

public class CoroutineWolf : MonoBehaviour {

	public float smoothing = 1f;
	public Transform target;

	//Use this for initialization
	void Start(){
		StartCoroutine (MyCoroutine (target));
	}

	IEnumerator MyCoroutine (Transform target){
		while (Vector3.Distance (transform.position, target.position) > 0.05f) {
			transform.position = Vector3.Lerp (transform.position, target.position, smoothing * Time.deltaTime);
			yield return null;
		}
	}
}
