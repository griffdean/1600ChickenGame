using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public const int maxHealth = 100;
	public int currentHealth = maxHealth;

	public Text hp;
	public Text maxHP;
	
	// Update is called once per frame
	void Update () {
		hp.text = currentHealth.ToString ();
		maxHP.text = maxHealth.ToString ();
	}

	public void TakeDamage(int amount){
		currentHealth -= amount;
		if(currentHealth <= 0){
			currentHealth = 0;
			SceneManager.LoadScene ("Game_OverScene");
		}
	}
}
