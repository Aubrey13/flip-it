using UnityEngine.UI;
using UnityEngine;

using System.Collections;

public class playerhealth : MonoBehaviour {
	public Text healthText;
	private int health;
	private int damageAmount;



	void Start () {
		healthText.text = "20";
		int health = 20;
		int damageAmount = 2;
	}
	
	void Update ()
			{
			/*	int collideEnemy;

				void OnCollisionEnter(collideEnemy)
					if(collideEnemy.transform.tag == "Enemy";
					   { 
						health --1; healthText print;
					else if(collisonEnemy.transform.tag == "killZone" 
						{ */
							//Application.LoadLevel(*indexOfScene*) when scene is added to build list.
			}

			
		void  OnCollisionEnter(Collision collideEnemy){
			if(collideEnemy.transform.tag == "Enemy");
			{
			print("crash Enemy");
			}
	}
}
