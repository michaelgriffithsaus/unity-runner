using UnityEngine;
using System.Collections;

public class movementController : MonoBehaviour {

    public float moveSpeed = 10.0f;
    public float rotationSpeed = 100.0f;

	//jump variables
	public bool isGrounded = true;
	public float jumpForce = 2.0f;
	public Vector3 jump;

	Rigidbody rb;


    // Use this for initialization
    void Start () {
		rb = GetComponent<Rigidbody> ();
		jump = new Vector3 (0.0f, 2.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

		if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {
			rb.AddForce (jump * jumpForce, ForceMode.Impulse);
			isGrounded = false;
		}

        //transform.Rotate(0, x, 0);
        transform.Translate(x, 0, z);
    }

	void OnCollisionStay(){
		isGrounded = true;
	}
}
