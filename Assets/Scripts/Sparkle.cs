using UnityEngine;
using System.Collections;

public class Sparkle : MonoBehaviour {

    float XrotationDegrees;
    float YrotationDegrees;
    float ZrotationDegrees;

    void Start () {
        XrotationDegrees = Random.Range(0, 100);
        YrotationDegrees = Random.Range(0, 100);
        ZrotationDegrees = Random.Range(0, 100);
    }

    public void Update () {
        transform.Rotate(new Vector3(XrotationDegrees, YrotationDegrees, ZrotationDegrees) * Time.deltaTime);
	}
}
