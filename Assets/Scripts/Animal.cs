using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Active))]
public abstract class Animal : MonoBehaviour {

	public float moveSpeed = 3f;
	public float turnSpeed = 0.5f;

	protected virtual void Start() {
		gameObject.AddComponent<Active>();
	}
	
	protected abstract void Update();

	protected abstract void Move();

	protected abstract void Turn();

	protected void MoveForward()
	{
		transform.Translate(0, 0, moveSpeed * Time.deltaTime);
	}

	//protected abstract void Animate();
}
