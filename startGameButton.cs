using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class startGameButton : MonoBehaviour {

	public string sceneName;

	// Use this for initialization
	void Start () {
	
	}

	public void OnClick(string sceneName) {
		SceneManager.LoadScene (sceneName, LoadSceneMode.Additive);
	
	}

}
