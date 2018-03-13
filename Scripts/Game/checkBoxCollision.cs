using UnityEngine;
using System.Collections;

public class checkBoxCollision : MonoBehaviour {

	WheelCollider wheel;
	Transform playerTransform;

	// Use this for initialization
	void Start () {
		wheel = GetComponent<WheelCollider>();
		playerTransform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		checkWheelCollision ();
	}


	void checkWheelCollision(){
		WheelHit hit;

		if (wheel.GetGroundHit(out hit)) {
			if (hit.collider.gameObject.name.StartsWith ("Cube")) {
				hit.collider.gameObject.GetComponent<boxSpawner> ().spawnBox (playerTransform, GetInstanceID());
			}
	}
}
}