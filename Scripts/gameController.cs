using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class gameController : MonoBehaviour {

	public controllerManager controllerManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		//If the keyboard is being used we check for backspace

		//If a controller is being used we use the back or select button
		if (controllerManager.PS4_Controller == 1 || controllerManager.Xbox_One_Controller == 1) {

			if (Input.GetKeyDown(KeyCode.Joystick1Button6)) {
				resetScene();
			}
		}
		else if (Input.GetKeyDown(KeyCode.Backspace)){
			resetScene ();
		}

		}

	private void resetScene(){
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}