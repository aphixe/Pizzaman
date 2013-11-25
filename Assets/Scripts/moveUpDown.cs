using UnityEngine;
using System.Collections;

public class moveUpDown : MonoBehaviour {
	
	public float speed =1.0f;
	public string axisName = "Vertical";
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
		
		transform.position += transform.up *Input.GetAxis(axisName)* speed * Time.deltaTime;
		
	}
}
