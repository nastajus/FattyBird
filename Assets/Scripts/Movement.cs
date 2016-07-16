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

            Quaternion pitchDelta = RotatePitch(vert);
            
            Quaternion yawDelta = RotateYaw(horiz);
 

            //roll undefined

            transform.rotation *= pitchDelta * yawDelta;

        }
    }

    Quaternion RotatePitch(float vert){
        //vert --> left/right keys --> pitch
        Vector3 axisRotationPitch = transform.right;
        float turnAngleVertical = vert * turnSpeed;
        Quaternion pitchDelta = Quaternion.AngleAxis(turnAngleVertical, axisRotationPitch);
        return pitchDelta;
    }

    Quaternion RotateYaw(float horiz)
    {
        //horiz --> up/down keys --> yaw
        Vector3 axisRotationYaw = transform.up;
        float turnAngleHorizontal = horiz * turnSpeed;
        Quaternion yawDelta = Quaternion.AngleAxis(turnAngleHorizontal, axisRotationYaw);
        return yawDelta;

    }

    void MoveForward()
    {
        transform.Translate(0, 0, moveSpeed * Time.deltaTime);
    }     
}
