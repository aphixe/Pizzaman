using UnityEngine;
using System.Collections;

public class moveLeftRight : MonoBehaviour {
	
	public float speed =1.0f;
	public string axisName = "Horizontal";
	public Animator anim;
	
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis(axisName)));
		if (Input.GetAxis (axisName) < 0)
		{
			Vector3 newScale = transform.localScale;
			newScale.x = -1.0f;
			transform.localScale = newScale;
		} 
		else if (Input.GetAxis (axisName) > 0)
		{
			Vector3 newScale =transform.localScale;
			newScale.x = 1.0f;
			transform.localScale = newScale;		
		}
		if(Input.GetKeyDown(KeyCode.Space)) {
			transform.position -= transform.right *Input.GetAxis(axisName)* speed * Time.deltaTime;	
		}
		transform.position += transform.right *Input.GetAxis(axisName)* speed * Time.deltaTime;
		
	}
}
