using UnityEngine;
using System.Collections;

public class Coroutine : MonoBehaviour {

	public int number;
	public int maxNumber;
	public int ammo;

	void Start(){
		StartCoroutine (Health ());
		StartCoroutine (AmmoLoad ());
	}

	IEnumerator Health(){
		while (number < maxNumber) {
			yield return new WaitForSeconds (2);
			print ("Health at " + number);
			number++;
		}
	}

	IEnumerator AmmoLoad(){
		while (ammo < 15) {
			yield return new WaitForSeconds (1);
			print ("Ammo at " + ammo);
			ammo++;
		}

	}
			
}
