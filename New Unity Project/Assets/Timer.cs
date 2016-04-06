using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public float amountTime;

	void Update () {

		amountTime -= Time.deltaTime;
	
			if(amountTime < 0){
			Destroy(gameObject);
		}

	}
}