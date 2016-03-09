using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour {

	public float amountTime;

	void Update () {

		amountTime -= Time.deltaTime;
	
			if(amountTime < 0){
			Destroy(gameObject);
		}

	}
}
