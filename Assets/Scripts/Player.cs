using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Active))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Inventory))]
public abstract class Player : MonoBehaviour {

    protected Inventory inventory;

    protected virtual void Start()
    {
        gameObject.AddComponent<Active>();
        Rigidbody rb = gameObject.AddComponent<Rigidbody>();
        rb.useGravity = false;
        rb.isKinematic = true;

        inventory = gameObject.AddComponent<Inventory>();
    }

    protected virtual void Update()
    {

    }

    public virtual bool Pickup(Item item)
    {
        print("Picked up: " + item.GetType());
        inventory.Add(item); 
        return true;
    }
}
