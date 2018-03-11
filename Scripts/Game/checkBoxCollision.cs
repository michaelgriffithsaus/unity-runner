using UnityEngine;
using System.Collections;

public class checkBoxCollision : MonoBehaviour {

	WheelCollider wheel;
	// Use this for initialization
	void Start () {
		wheel = GetComponent<WheelCollider>();
	}
	
	// Update is called once per frame
	void Update () {
		checkWheelCollision ();
	}


	void checkWheelCollision(){
		WheelHit hit;

		if (wheel.GetGroundHit(out hit)) {
			if (hit.collider.gameObject.name.StartsWith ("Cube")) {
				hit.collider.gameObject.GetComponent<boxSpawner> ().spawnBox ();
			}
	}
}
}