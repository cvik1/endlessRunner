using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour {

	// get the location of the player
	public Transform player; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// move the camera forward with the player as it moves
		transform.position = new Vector3(player.position.x + 6, 0, -10);
	}
}
