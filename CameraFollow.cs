using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	Transform cameraTranform;

	public float smoothSpeed = 0.125f;
	public Vector3 offset;

	void Start() {
		cameraTranform = GetComponent<Transform> ();
	}

	void FixedUpdate() {

		Vector3 desiredPosition = target.position + offset;
		Vector3 smoothedPosition = Vector3.Lerp (cameraTranform.position,
			desiredPosition, 
			smoothSpeed
		);
		cameraTranform.position = smoothedPosition;

		//transform.LookAt (target);
	}

	public void changeTarget(Transform newTarget){
		this.target = newTarget;
	}


}
