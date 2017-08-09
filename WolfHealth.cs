using UnityEngine;
using System.Collections;

public class WolfHealth : MonoBehaviour {

	public int currentHealth;
	public int points;
	public Transform spawnPoint;
	public int maxHealth;

	public void TakeDamage(int amount){
		currentHealth -= amount;
		if(currentHealth <= 0){
			//Keep score at zero
			currentHealth = 0;
			print ("Wolf is Dead.");
			//Add points for killing wolf
			ScoreManager.AddPoints(points);
			//Move wolf to spawn point 
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;
			//Reset Wolf Health
			currentHealth = maxHealth;
}
	}
}
