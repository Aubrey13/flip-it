using UnityEngine;
using System.Collections;

public class something : MonoBehaviour {
	public float ballBounce = 40.0f;
	public float ballLimit = 50.0f;
	public float ballsecondary =5.0f;

	// Use this for initialization
	void Start () {
		if (ballBounce < ballsecondary){
			Debug.Log("ball pops");
	}
		else if (ballBounce > ballsecondary && ballBounce <ballLimit){
			Debug.Log("ball will bounce");
		}
		else {
			Debug.Log ("ball will fly");
	

		}
	}
}
