using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    float speed = 0.5f;

	void Start () {
        Vector2 simpleTriangle = new Vector2(1, Mathf.Sqrt(3));
        float angle = GetAngleFromVect2D(simpleTriangle);
        print(angle);

        print(RotateVector2D(simpleTriangle, 10));


        //print(GetAngleFromVect(transform.forward));
	}
	
	void Update () {
        MoveForward();

    }

    void MoveForward()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    float GetAngleFromVect2D(Vector2 vector)
    {
        float y = vector.y;
        float x = vector.x;
        float angleRadians = Mathf.Atan2(y, x);
        float angleDegrees = angleRadians * Mathf.Rad2Deg;
        return angleDegrees;
    }

    Vector2 RotateVector2D(Vector2 vector, float angleAdd)
    {
        float angleCurrent = GetAngleFromVect2D(vector);
        float angleNext = angleCurrent + angleAdd;
        Vector2 vectorNext = GetVectFromAngle2D(angleNext);
        return vectorNext;
    }

    Vector2 GetVectFromAngle2D(float angle)
    {
        float fraction = Mathf.Tan(angle);
        float x = fraction;
        float y = 1;
		Vector2 vector = (new Vector2(x, y)).normalized;
        return vector;
    }


    //float GetAngleFromVect(Vector3 vector)
    //{
        
    //}

    //Vector3 GetVectFromAngle(float angle)
    //{

    //}

    //Vector3 RotateVector(Vector3 vector, float angle)
    //{

    //}
     
}
