using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour {

	public class PaintBrush {

		public int color;
		int paint;
		int bristle;

		public PaintBrush (int co, int pai, int bri) 
		{
			color = co;
			paint = pai;
			bristle = bri;
		}
		public PaintBrush () {
			color = 4;
			paint = 5;
			bristle = 3;
		}

	}
	public PaintBrush Mybrush = new PaintBrush (4,3,2);
	
		public PaintBrush Onebrush = new PaintBrush ();
	
	int i = 5;

	
	// Use this for initialization
	void Start () {

		int i = 5;
		int j = i;
		i = 3;

		Mybrush = Onebrush;
		Mybrush.color = 5;

	myArray [0] = 23;
	myArray [1] = 24;
	myArray [2] = 25;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
*/