using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Dog : Animal {

	List<Leg> legs;

	protected override void Start () {
		base.Start();
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
		Animate();
	}

	protected override void Turn()
	{
		//relative to player's orientation:
		float horiz = Input.GetAxisRaw("Horizontal");
		float vert = Input.GetAxisRaw("Vertical");

		if (horiz != 0 || vert != 0)
		{
			transform.rotation *= Quaternion.Euler(-0, horiz, -0);
		}

	}

	void Animate(){
		MoveLegs();
	}

	void MoveLegs(){
		
	}

	void GetLegs(){
		Component[] hingeJoints;
		hingeJoints = GetComponentsInChildren<HingeJoint>();
		foreach (HingeJoint joint in hingeJoints) {
			joint.useSpring = false;
		}

	}

}
