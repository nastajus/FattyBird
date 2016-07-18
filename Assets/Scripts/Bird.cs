using UnityEngine;
using System.Collections;

public class Bird : Animal {

	protected override void Start () {
	
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

}
