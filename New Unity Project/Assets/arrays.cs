using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour {

	public int[] MyIntArray = {2,3};

	void Start () {
		MyIntArray [0] = 2;
		MyIntArray [1] = 3;

		for (int i = 0; i < MyIntArray.Length; i++) {
			Debug.Log ("The Name of" +i+ "is" + MyIntArray[i]);
		}
			
	}

	// Update is called once per frame
	void Update () {
	}
}