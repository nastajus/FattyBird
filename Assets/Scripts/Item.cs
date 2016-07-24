using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

    Powerup powerup;

	protected virtual void Start () {
        powerup = gameObject.AddComponent<Powerup>();
	}

    protected virtual void Update () {
        powerup.Update();
	}


}
