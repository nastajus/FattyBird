using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SphereCollider))]
public class Powerup : MonoBehaviour {

    Sound sound;

    protected virtual void Start () {
        SphereCollider sc = gameObject.AddComponent<SphereCollider>();
        sc.isTrigger = true;
    }

    protected virtual void Update () {
	
	}

    protected virtual void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (player != null)
        {
            bool pickedUp = player.Pickup(this);
            if (pickedUp)
            {
                UtilPlaySound(this.sound);
                UtilDelete(this.gameObject);
            }
        }
    }

    void UtilDelete(GameObject gameObject)
    {
        Destroy(gameObject);
    }

    void UtilPlaySound(Sound sound)
    {

    }
}
