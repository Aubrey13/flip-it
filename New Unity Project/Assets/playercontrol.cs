/*using UnityEngine;
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
/*
using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	/*
    * Additional Variables:
    * A public GameObject that will hold the reference to the bullet prefab
    */
	
	/*
     * Additional Lines in the Update Function:
     *      If (the space bar is pressed down *see below for instructions*)
     *          Instantiate using the bullet prefab, this object's transform, and this object's rotation
     */
	
	/* **************Explanation and Hints************ 
     * Prefab - They are GameObjects that are stored outside of the scene. We use them to instantiate      
     *          GameObjects. 
     *
     * Instantiate - This will create a new GameObject or prefab of our choosing. In this script we want to
     *               create bullets. We will create the bullets at the players position and we will
     *               have the bullet match the rotation of the player. To do so we will type:
     *             
     *               Instantiate(*nameOfBulletVariable*, transform.position, transform.rotation);
     *
     * Pressing Space Bar - When shooting we want to use a different key press then the others. For this we
     *                      will be using Input.GetKeyDown. The reason why is because GetKeyDown only activates
     *                      once while GetKey activates multiple times. GetKeyDown is typed like this:
     *              
     *                      if(Input.GetKeyDown(KeyCode.Space))
     *                      {
     *                          //Instantiate bullet here
     *                      }
     */
/*}
/*
using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	/* 
     * Variables:
     * A public float for rotation speed
     * A public float for movement speed
     * A private Rigidbody to hold the reference to the Rigidbody component
     */
	
	/*
     * The Start function, void return type, no parameters
     *      Use GetComponent to get the rigidbody reference
     */
	
	/*
     * The Update function, void return type, no parameters
     *       If ( leftArrow is pressed )
     *           then rotate the player to the left
     *       Else if ( right arrow is pressed ) 
     *           then rotate the player to the right
     *       Else if ( upArrow is pressed )
     *           then use AddRelativeForce to move forward
     */
	
	/* **************Explanation and Hints************
     * Rigidbody - When attached to a GameObject it adds things like gravity as well as other physics properties to the GameObject.
     *             For the player we want to attach the Rigidbody component to it so that we can add a forward force to it when pressing the up arrow key
     *           - To use the Rigidbody we need a variable. The type of this variable is "Rigidbody" instead of "int" and often this variable
     *             is named "rigidbody". For this we will type:

     *             private Rigidbody *nameOfRigidbodyVariable*;

     *           - Now we need to get the reference to the Rigidbody. If we don't then it won't work. In order to get the reference we need to
     *             type the following in the Start function:
     *
     *             *nameOfRigidbodyVariable* = GetComponent<Rigidbody>(); 
     *
     *             Replace *nameOfRigidbodyVariable* with whatever name you gave the rigidbody variable.
     *             
     * Key inputs - In order to detect key presses Unity has a special Object called Input. We will have to put this Input object as a conditional
     *              of an if statement. We do this so that when a key is pressed it will only run the code in the if statement. Input also has to
     *              be in the Update function. So if we wanted to detect the left arrow key we would type the following in the Update function:

     *              if(Input.GetKey(KeyCode.LeftArrow))
     *              {
     *                  //Put here what you want the left arrow to do
     *              }
     *              
     * Rotation - To rotate the player we need to use a function in the Transform object. Transform contains all of the variables and functions
     *            relating to a GameObject's position and rotation. So if we want the player to turn left or right we would type the following
     *            in the "press left/right arrow if statement".
     *            
     *            transform.Rotate(new Vector3(0, *rotationSpeedVariable*, 0); 
     *
     *            Replace *rotationSpeedVariable* with whatever variable you are using for the rotation speed. Also, to make it turn left add
     *            "-", or in other words the minus sign, to the rotation speed variable name to make it turn left.
     *            
     * Forward movement - There are many ways to move a GameObject but in this instance we will use the AddRelativeForce function. That function
     *                    is a part of the Rigidbody component. AddRelativeForce adds a force in a direction relative to the rotation of the
     *                    GameObject. Also, make sure that the Rigidbody variable has a reference or else Unity will throw an error. So to add
     *                    forward movement to the player we need to type the following in the "press up arrow if statement":
     *
     *                    *nameOfRigidbodyVariable*.AddRelativeForce(0, 0, *movementSpeedVariable*); 
     *
     *                    Replace *nameOfRigidbodyVariable* with the name of the Rigidbody variable and replace *movementSpeedVariable* with 
     *                    the name of the movement speed variable.
     *
}
*/