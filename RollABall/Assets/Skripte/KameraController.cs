using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 pomak;

	// Use this for initialization
	void Start () {
		pomak = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + pomak;
	}
}
