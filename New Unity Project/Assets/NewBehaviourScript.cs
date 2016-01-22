using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	int MyInt = 20;

	void Start () {
		MyInt = MultiplyByTwo (MyInt);
		Debug.Log (MyInt);
	}

	int MultiplyByTwo(int number){
		int kitty;

		kitty = 2 * number;

		return kitty;
	}

}