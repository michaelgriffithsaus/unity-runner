using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreController : MonoBehaviour {

	public Text scoreText;
	int score = 0;

	// Use this for initialization
	void Start () {
		scoreText.text = "Score: " + score.ToString();
	}

	public void addToScore(int addScore) {

		score = score + addScore;
		Debug.Log ("Updating score to " + score);
		scoreText.text = "Score: " + score.ToString();
	}
}
