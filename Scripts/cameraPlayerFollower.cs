using UnityEngine;
using System.Collections;

public class cameraPlayerFollower : MonoBehaviour {

    public Transform target;
    public float distance = 10;

	// Update is called once per frame
	void Update () {

        Vector3 targetLocation = new Vector3(target.position.x, target.position.y, target.position.z);


	}
}
