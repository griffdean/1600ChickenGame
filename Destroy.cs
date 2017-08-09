using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	public Transform spawnPoint;
	public int points;

	void OnCollisionEnter(Collision other){
		if(other.gameObject.name == "Farmer"){
			//Destroy (gameObject);
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;
			ScoreManager.AddPoints(points);
		}
}
}
