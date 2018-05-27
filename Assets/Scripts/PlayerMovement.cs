using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	private Rigidbody rb; 
	public int speed = 10;
	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is ca	lled once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("CubeObjects"))
		{
			other.gameObject.SetActive(false);
		}
	}


}
