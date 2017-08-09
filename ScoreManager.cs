using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static int chicks;
	public Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		chicks = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (chicks < 0) {
			chicks = 0;
		}
		text.text = " " + chicks;
	}

	public static void AddPoints(int pointsToAdd){
		chicks += pointsToAdd;
		if (chicks == 12) {
			SceneManager.LoadScene ("Winning_scene");
		}
	}

	public void Reset(){
		chicks = 0;
	}
}
