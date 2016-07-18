using UnityEngine;
using System.Collections;

public abstract class Animal : MonoBehaviour {

	public float moveSpeed = 3f;
	public float turnSpeed = 0.5f;

	protected abstract void Start();
	
	protected abstract void Update();

	protected abstract void Move();

	protected void Turn()
	{
		//relative to player's orientation:
		float horiz = Input.GetAxisRaw("Horizontal");
		float vert = Input.GetAxisRaw("Vertical");


		if (horiz != 0 || vert != 0)
		{

			//vert --> left/right keys --> pitch
			Quaternion pitchDelta = Quaternion.AngleAxis(vert, transform.right);

			//horiz --> up/down keys --> yaw
			Quaternion yawDelta = Quaternion.AngleAxis(horiz, transform.up);

			//roll undefined
			//transform.rotation = Quaternion.AngleAxis(0, yawDelta * pitchDelta * transform.forward ); 

			transform.rotation *= Quaternion.Euler(-vert, horiz, -0);

		}
		else
		{
			//if (levelOutAllowed && levelSpeedProgress == 0)
			//{
			//    originalRotation = transform.rotation;
			//levelOutAllowed = true;???
			//}
			//LevelOutToPlane(originalRotation);
		}
	}

	protected void MoveForward()
	{
		transform.Translate(0, 0, moveSpeed * Time.deltaTime);
	}
}
