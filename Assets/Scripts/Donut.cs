using UnityEngine;
using System.Collections;
using System;

public class Donut : Digestable {

    protected override float Calories
    {
        get { return 100; }
    }

    protected override void Start () {
        base.Start();
    }

    protected override void Update () {
        base.Update();
	}
}
