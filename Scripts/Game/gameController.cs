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
	
	    //Detect if the controller wants to reset the scene by checking for the reset button input
		if (Input.GetAxis ("reset") > 0) {
			resetScene ();
		}
	}



	private void resetScene(){
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}