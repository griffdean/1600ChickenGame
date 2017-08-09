using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class LoadLevel : MonoBehaviour {

	public void StartGame(){
		SceneManager.LoadScene ("ChickenGathering");
	}

	public void RetryGame(){
		SceneManager.LoadScene ("ChickenGathering");
	}

	public void QuitToMenu(){
		SceneManager.LoadScene ("Main_menu");
	}
}
