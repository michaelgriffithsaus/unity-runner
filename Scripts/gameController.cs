using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class gameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Backspace)) {

			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);

		}
	}

}
