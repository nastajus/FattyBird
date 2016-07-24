using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

    private List<Item> items = new List<Item>();

    public void Start()
    {
        items = new List<Item>();
    }

    void Update() { }

    public void Add(Item item)
    {
        items.Add(item);
    }

    public List<Item> Get()
    {
        return items;
    }

    
}
