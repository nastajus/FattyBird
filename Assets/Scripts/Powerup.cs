using UnityEngine;
using System.Collections;

/**
 * A power up is collectible by a player
 */
[RequireComponent(typeof(SphereCollider))]
public class Powerup : MonoBehaviour {

    Sound sound;
    Sparkle sparkle;

    protected virtual void Start () {
        SphereCollider sc = gameObject.AddComponent<SphereCollider>();
        sc.isTrigger = true;
        sparkle = gameObject.AddComponent<Sparkle>();
    }

    public virtual void Update () {
        sparkle.Update();
	}

    protected virtual void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (player != null)
        {
            Item item = this.GetComponent<Item>(); 
            bool pickedUp = player.Pickup(item);
            if (pickedUp)
            {
                UtilPlaySound(this.sound);
                UtilDelete(this.gameObject);
            }
        }
    }

    void UtilDelete(GameObject gameObject)
    {
        Destroy(gameObject.transform.root.gameObject);
    }

    void UtilPlaySound(Sound sound)
    {

    }
}
