using UnityEngine;
using System.Collections;


public class FloorTrigger : MonoBehaviour {
	public bool CanJump = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider other){
		CanJump = true;
	}
}
