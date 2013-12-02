using UnityEngine;
using System.Collections;

public class basicMove : MonoBehaviour {

	public KeyCode moveLeft;
	public KeyCode moveRight;
	public float speed = 10;
	float rigidValue;

	void Start()
	{
		float rigidValue = rigidbody2D.velocity.y;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (moveLeft)) 
		{
			rigidValue = speed;
		}   
		else if (Input.GetKey (moveRight))
		{	
			rigidValue = speed * -1;
		}
	}
}
