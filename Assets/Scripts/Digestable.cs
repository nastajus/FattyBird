using UnityEngine;
using System.Collections;

public abstract class Digestable : Item {

    protected float calories_;
    public abstract float Calories { get; }
    public float CaloriesRemaining { get; protected set; }

    protected override void Start() {
        base.Start();
        CaloriesRemaining = Calories;
	}
	
	protected override void Update () {
        base.Update();
    }

    public float BeDigested()
    {
        return (CaloriesRemaining -= 1) >= 0 ? 1 : 0;
    }
}
