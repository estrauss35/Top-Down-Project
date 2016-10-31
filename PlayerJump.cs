using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour {

	public bool CanJump = true;
	public float MaxJumpTime = 2f;
	private float JumpTime = 0f;
	// Use this for initialization
	void Start () {
		JumpTime = MaxJumpTime;
	}
	
	// Update is called once per frame
	void Update () {
		if (!CanJump) {
			JumpTime -= Time.deltaTime;
			if(JumpTime <= 0 && GetComponent<Rigidbody2D>().velocity.y == 0){
				CanJump = true;
				JumpTime = MaxJumpTime;
			}
		}

	}

	void FixedUpdate(){
		Jump ();
	}

	void Jump(){
		if (Input.GetKeyDown ("space") && CanJump) {
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0,6), ForceMode2D.Impulse);
			CanJump = false;

		}
	}


}
