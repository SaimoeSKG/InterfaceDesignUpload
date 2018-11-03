using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToPlayer : MonoBehaviour {
	public GameObject player;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		offset = transform.position - player.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position + offset;
		Vector3 camera = new Vector3 (0, player.transform.rotation.y, 0);
	}
}
