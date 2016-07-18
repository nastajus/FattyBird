using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float moveSpeed = 3f;
    public float turnSpeed = 0.5f;

    private float levelSpeedProgress = 0f;
    private const float levelSpeedStep = 0.001f;
    bool levelOutAllowed;
    Quaternion originalRotation;

	void Start () {
        originalRotation = transform.rotation;
        levelOutAllowed = true;
    }
	
	void Update () {
        Turn();
        MoveForward();
        //Camera.main.transform.LookAt(transform);
        //LevelOutToPlane(originalRotation);
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

    void MoveForward()
    {
        transform.Translate(0, 0, moveSpeed * Time.deltaTime);
    }


    void LevelOutToPlane(Quaternion objectStartRotation)
    {
        if (levelSpeedProgress > 1)
        {
            levelOutAllowed = false;
        }
        else
        {
            levelSpeedProgress += levelSpeedStep;
            Quaternion endRot = Quaternion.Euler(0, 0, 0);
            Quaternion newRot = Quaternion.Slerp(objectStartRotation, endRot, levelSpeedProgress);
            //print(levelSpeedProgress + ", " + newRot);


            transform.rotation = newRot;

        }


    }
}
