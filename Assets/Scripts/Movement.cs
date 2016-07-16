using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float moveSpeed = 3f;
    public float turnSpeed = 0.5f;

	void Start () {

 	}
	
	void Update () {
        Turn();
        MoveForward();
        Camera.main.transform.LookAt(transform);
    }

    void Turn()
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

            transform.rotation *= pitchDelta * yawDelta;

        }
    }

    void MoveForward()
    {
        transform.Translate(0, 0, moveSpeed * Time.deltaTime);
    }     
}
