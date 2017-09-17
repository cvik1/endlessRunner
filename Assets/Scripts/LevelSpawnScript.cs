using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawnScript : MonoBehaviour {
	public int size;
	public GameObject[] obj;

	private Vector3 pos;
	private float angle;
	private Quaternion rotation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawn () {
		int i = Random.Range(0,size-1);
		pos = transform.position;

		pos.y = Random.Range (-12f, 12f);
		angle = Random.Range (0f, 180f);

		rotation = Quaternion.identity;
		rotation.ToAngleAxis (out angle, out Vector3.forward);

		Instantiate (obj [i], pos, rotation);
		//obj[i].transform.rotation
	}
}
