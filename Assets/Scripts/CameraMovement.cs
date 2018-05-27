using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	public GameObject ball;

	private Vector3 offset;
	// Use this for initialization
	void Start () {

		offset = transform.position - ball.transform.position; 
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = offset + ball.transform.position;
	}
}
