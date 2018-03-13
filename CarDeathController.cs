using UnityEngine;
using System.Collections;

public class CarDeathController : MonoBehaviour {

	public Vector3 deathZone;
	Transform playerTransform;

	// Use this for initialization
	void Start () {
		playerTransform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		//if the player falls off the edge kill the player
		if (playerTransform.position.y < -5)
			gameObject.SetActive (false);
	}
}
