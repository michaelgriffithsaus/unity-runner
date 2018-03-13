using UnityEngine;
using System.Collections;


public class boxSpawner : MonoBehaviour {

	//box management
	public Transform prefab;
	bool boxSpawned;

	//score management
	public scoreController scoreController;
	public int pointValue;

	//time management
	public float aliveTime;
	float timeSpawned;

	int tempId;
	public SmoothFollow SmoothFollow;


	// Use this for initialization
	void Start () {
		//Debug.Log (transform.position);
		timeSpawned = Time.time;
		tempId = 0;

	}
	
	// Update is called once per frame
	void Update () {
		//If the box has been alive longer that the allowed time, disable the object.
		if (Time.time - timeSpawned > aliveTime) {
			Debug.Log("DESTROYING BOX " + Time.time);
			gameObject.SetActive (false);
		}
	}
		

	public void spawnBox(Transform playerTransform, int transformId){
		if (!boxSpawned) {

			//Spawn another box directly in front of this one
			Instantiate (prefab, transform.position + new Vector3 (Random.Range(-5.0f, 5.0f), 0.0f, 22.0f), Quaternion.identity);
			boxSpawned = true;

			//update the score
			Debug.Log ("Updating Score " + pointValue);
			scoreController.addToScore (1);


			//if the player who collided with this box is new
			if (tempId != transformId) {

				tempId = transformId;

				//tell the camera to look at this player
				SmoothFollow.changeTarget (playerTransform);

			}


		}
	}		
}