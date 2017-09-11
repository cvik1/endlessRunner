using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawn : MonoBehaviour {

	// floor object we will be instantiating 
	public GameObject obj;
	// variable to keep track of how far we've moved
	private float x;
	public float delta_x;

	// Use this for initialization
	void Start () {
		x = transform.position.x;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		delta_x = transform.position.x - x;
		// because floor objects are 4 units wide, every 3 units change in x, spawn another
		// this is so that we don't have gaps
		if (delta_x > 3) {
			Spawn ();
			x = transform.position.x;
		}
	}

	void Spawn () {
		Vector3 floorPos = new Vector3 (transform.position.x, transform.position.y - 5, 0);
		Vector3 cielingPos = new Vector3 (transform.position.x, transform.position.y + 5, 0);
		Instantiate (obj, floorPos, Quaternion.identity);
		Instantiate (obj, cielingPos, Quaternion.identity);


	}
}
