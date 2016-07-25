using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Stomach : MonoBehaviour {

    private List<Item> items = new List<Item>();

    public void Start()
    {
        items = new List<Item>();
    }

    public void Update()
    {
        Digest();
    }

    public void Add(Item item)
    {
        print("Stomach added: " + item);
        items.Add(item);
    }

    public List<Item> Get()
    {
        return items;
    }

    private void Digest()
    {
        foreach (Object o in items)
        {
            //works here
        }
    }
}
