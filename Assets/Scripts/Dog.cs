using UnityEngine;
using System.Collections;

public class Dog : Animal {

	protected override void Start () {
	
	}

	protected override void Update () {
		Move();
	}

	protected override void Move() {
		Walk();
	}

	protected void Walk() {
		MoveForward();
		Turn();
	}

	protected override void Turn()
	{
		//relative to player's orientation:
		float horiz = Input.GetAxisRaw("Horizontal");
		float vert = Input.GetAxisRaw("Vertical");

		if (horiz != 0 || vert != 0)
		{
			transform.rotation *= Quaternion.Euler(-vert, 0, -0);
		}

	}


}
