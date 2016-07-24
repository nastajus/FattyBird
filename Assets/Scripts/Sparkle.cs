using UnityEngine;
using System.Collections;

public class Sparkle : Powerup {

    float XrotationDegrees;
    float YrotationDegrees;
    float ZrotationDegrees;

    protected override void Start () {
        base.Start();
        XrotationDegrees = Random.Range(0, 100);
        YrotationDegrees = Random.Range(0, 100);
        ZrotationDegrees = Random.Range(0, 100);
    }

    protected override void Update () {
        base.Update();
        transform.Rotate(new Vector3(XrotationDegrees, YrotationDegrees, ZrotationDegrees) * Time.deltaTime);
	}
}
