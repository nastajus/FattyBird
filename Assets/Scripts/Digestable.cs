using UnityEngine;
using System.Collections;

public abstract class Digestable : Item {

    protected float calories_;
    protected abstract float Calories { get; }

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
