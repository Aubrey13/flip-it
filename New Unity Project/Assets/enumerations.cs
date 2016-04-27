using UnityEngine;
using System.Collections;

public class enumerations : MonoBehaviour {

	enum Direction {North, South, East, West};


	// Use this for initialization
	void Start () {
		Direction MyDirection;

		MyDirection = Direction.North;
	
		ReverseDirection (MyDirection);

	}

	void ReverseDirection(Direction dir)
	{
		if (dir == Direction.North)
			dir = Direction.South;

	}

	// Update is called once per frame
	void Update () {
	
	}
}
