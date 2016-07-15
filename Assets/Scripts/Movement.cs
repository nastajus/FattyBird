using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float moveSpeed = 3f;
    public float turnSpeed = 0.02f;

	void Start () {
        Vector2 simpleTriangle = new Vector2(1, Mathf.Sqrt(3));
        float angle = GetAngleFromVect2D(simpleTriangle);
        print(angle);

        print(RotateVector2D(simpleTriangle, 10));


        //print(GetAngleFromVect(transform.forward));
	}
	
	void Update () {
        Turn();
        MoveForward();
        Camera.main.transform.LookAt(transform);
    }

    void Turn()
    {
        float horiz = Input.GetAxisRaw("Horizontal");
        float vert = Input.GetAxisRaw("Vertical");
        //print(horiz + " : " + vert);
        if (horiz != 0 || vert != 0)
        {
            //set forward vect directly for now, lerp later
            //transform.forward = RotateVector(transform.forward, horiz * turnSpeed, vert * turnSpeed);

            //test
            //Vector2 f = transform.forward;
            //f = RotateVector2D(f, horiz * 0.1f);
            //transform.forward = new Vector3(transform.forward.x + f.x, transform.forward.y + f.y, transform.forward.z);

            //UNITY
            Vector3 rot = transform.eulerAngles;
            //need to use 'floored modulus' here (google it)
            rot.x = (rot.x - vert) % 360f;
            rot.y = (rot.y + horiz) % 360f;
            transform.eulerAngles = rot;
        }
    }

    void MoveForward()
    {
        transform.Translate(0, 0, moveSpeed * Time.deltaTime);
    }

    public static float GetAngleFromVect2D(Vector2 vector)
    {
        float x = vector.x;
        float y = vector.y;
        float angleRadians = GetAngleFromComponents2D(x, y);
        return angleRadians;
    }
    public static float GetAngleFromComponents2D(float x, float y)
    {
        float angleRadians = Mathf.Atan2(y, x);
        return angleRadians;
    }

    public static Vector2 RotateVector2D(Vector2 vector, float angleAdd)
    {
        float angleCurrent = GetAngleFromVect2D(vector);
        float angleNext = angleCurrent + angleAdd;
        Vector2 vectorNext = GetVectFromAngle2D(angleNext);
        return vectorNext;
    }

    public static Vector2 GetVectFromAngle2D(float angle, float length = 1f)
    {
        float opposite = length * Mathf.Sin(angle);
        float adjacent = length * Mathf.Cos(angle);
        Vector2 vector = new Vector2(adjacent, opposite);
        return vector;
    }
    public static Vector3 RotateVector(Vector3 vector, float angleHoriz, float angleVert, float? length = null)
    {
        float angleCurrentHoriz = GetAngleFromComponents2D(vector.x, vector.y);
        float angleCurrentVert = GetAngleFromComponents2D(vector.z, vector.y);
        float len = length.HasValue ? length.Value : vector.magnitude;
        Vector3 vectorNext = GetVectFromAngles(angleCurrentHoriz, angleCurrentVert).normalized * len;
        return vectorNext;
    }
    public static Vector3 GetVectFromAngles(float angleHoriz, float angleVert, float length = 1f)
    {
        Vector2 horizVect = GetVectFromAngle2D(angleHoriz);
        Vector2 vertVect = GetVectFromAngle2D(angleVert);
        Vector3 result = horizVect;
        result.y += vertVect.x;
        result.z += vertVect.y;
        result = result.normalized * length;
        return result;
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
