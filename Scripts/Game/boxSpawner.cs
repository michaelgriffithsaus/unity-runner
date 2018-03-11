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

	//get transform
	Transform boxTransform;

	public CameraFollow CameraFollow;

	// Use this for initialization
	void Start () {
		//Debug.Log (transform.position);
		timeSpawned = Time.time;
		boxTransform = GetComponent<Transform> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - timeSpawned > aliveTime) {
			Debug.Log("DESTROYING BOX " + Time.time);
			gameObject.SetActive (false);
		}
	}


	void OnCollisionEnter(){
		if (!boxSpawned) {
			spawnBox ();
		}
	}


	public void spawnBox(){
		if (!boxSpawned) {
			
			Instantiate (prefab, transform.position + new Vector3 (Random.Range(-5.0f, 5.0f), 0.0f, 22.0f), Quaternion.identity);
			boxSpawned = true;
			Debug.Log ("Updating Score " + pointValue);
			scoreController.addToScore (1);
			CameraFollow.changeTarget (boxTransform);
		}
	}		
}