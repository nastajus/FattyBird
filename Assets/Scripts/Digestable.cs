using UnityEngine;
using System.Collections;

public class Digestable : Item {

    protected override void Start() {
        base.Start();
	}
	
	protected override void Update () {
        base.Update();
        ApplyDecay();
    }

    void ApplyDecay()
    {

    }
}
