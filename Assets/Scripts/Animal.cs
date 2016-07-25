using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Active))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Stomach))]
public abstract class Animal : Player
{

    public float moveSpeed = 3f;
    public float turnSpeed = 0.5f;
    Stomach stomach;

    protected override void Start()
    {
        base.Start();
        stomach = gameObject.AddComponent<Stomach>();
    }

    protected override void Update()
    {
        base.Update();
        stomach.Update();
    }

    protected abstract void Move();

    protected abstract void Turn();

    protected void MoveForward()
    {
        transform.Translate(0, 0, moveSpeed * Time.deltaTime);
    }
    
    //protected abstract void Animate();

    public override bool Pickup(Item item)
    {
        bool eaten = Eat(item);
        if (!eaten)
        {
            bool picked = base.Pickup(item);
            return picked;
        }
        return eaten;
    }

    protected bool Eat(Item item)
    {
        if (item.IsEdible())
        {
            stomach.Add(item);
            return true;
        }
        return false;
    }
}
