using UnityEngine;
using System.Collections;

public class playercontrol : MonoBehaviour {

	public float rotateSpeed;
	public float movementSpeed;
	private Rigidbody rigidBody;
	// Use this for initialization
	void Start () {

			rigidBody = GetComponent<Rigidbody>();
		}
			                 
				
			  
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(new Vector3(0, -rotateSpeed, 0));
		}
		if(Input.GetKey (KeyCode.RightArrow))
		{
			transform.Rotate(new Vector3(0, rotateSpeed, 0));
		}
		if(Input.GetKey (KeyCode.UpArrow))
		{
			rigidBody.AddRelativeForce(0, 0, movementSpeed);
		}				                
		if (Input.GetKey (KeyCode.DownArrow)) {
			rigidBody.AddRelativeForce (0, 0, -movementSpeed);
		}
	}
}
