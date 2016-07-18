using UnityEngine;
using System.Collections;

public class Bird : Animal {

	protected override void Start () {
		base.Start();
	}
	
	protected override void Update () {
		Move();
	}

	protected override void Move() {
		Fly();
	}

	void Fly() {
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
			transform.rotation *= Quaternion.Euler(-vert, horiz, -0);
		}

	}

	//protected override void Animate(){
	//	
	//}

}
