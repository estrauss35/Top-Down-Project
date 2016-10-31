using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float Speed;
	int floorMask;
	Rigidbody2D playerRigidBody;
	float camRayLength = 100f;
	private bool isSprinting = false;

	// Use this for initialization
	void Awake () {
		floorMask = LayerMask.GetMask ("Floor");
		playerRigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		playerRigidBody.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal")* Speed, 0.8f),Mathf.Lerp(0, Input.GetAxis("Vertical")* Speed, 0.8f));
		// Get Angle in Radians
		Turning ();
		Sprinting ();
	}

	void Turning(){
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
	}

	void Sprinting(){
		while (Input.GetKeyDown("left shift")) {
			Speed *= 1.5f;
		}
	}

}