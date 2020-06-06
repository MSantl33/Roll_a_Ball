using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Kretanje : MonoBehaviour {

	public Text countText;
	public float speed;
	private int zbroj;
	private Rigidbody rb;

	private int count;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCounterText ();
	}
		
	
	// Update is called once per frame
	void FixedUpdate () {
		float kretanjeHorizontal = Input.GetAxis ("Horizontal");
		float kretanjeVertical = Input.GetAxis ("Vertical");

		Vector3 kretanje=new Vector3 (kretanjeHorizontal , 0.0f ,kretanjeVertical);

		rb.AddForce(kretanje * speed);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);

			count += 1;
			SetCounterText ();
		}
	}

	void SetCounterText ()
	{
		countText.text = "Rezultat: " + count.ToString ();
	}
}
