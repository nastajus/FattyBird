using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Active))]
[RequireComponent(typeof(Rigidbody))]
public abstract class Player : MonoBehaviour {

    protected virtual void Start()
    {
        gameObject.AddComponent<Active>();
        Rigidbody rb = gameObject.AddComponent<Rigidbody>();
        rb.useGravity = false;
        rb.isKinematic = true;
    }

    protected virtual void Update()
    {

    }

    public bool Pickup(Object o)
    {
        print(o.GetType());
        return true;
    }
}
