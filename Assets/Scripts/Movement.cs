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
        Turn();
        MoveForward();

    }

    void Turn()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        print(horiz + " : " + vert);
        //set forward vect directly for now, lerp later
        transform.forward = GetVectFromAngles(horiz, vert);
    }

    void MoveForward()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    public static float GetAngleFromVect2D(Vector2 vector)
    {
        float x = vector.x;
        float y = vector.y;
        float angleDegrees = GetAngleFromComponents2D(x, y);
        return angleDegrees;
    }
    public static float GetAngleFromComponents2D(float x, float y)
    {
        float angleRadians = Mathf.Atan2(y, x);
        float angleDegrees = angleRadians * Mathf.Rad2Deg;
        return angleDegrees;
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
