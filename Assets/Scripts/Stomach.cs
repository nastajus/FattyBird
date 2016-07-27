using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Stomach : MonoBehaviour {

    private List<Digestable> items = new List<Digestable>();
    private float fuel;
    private GameObject organ;

    public void Start()
    {
        items = new List<Digestable>();
        fuel = 0;
        MakeGameObject();
    }

    public void Update()
    {
        Digest();
    }

    private void MakeGameObject()
    {
        organ = new GameObject("Stomach");
        organ.transform.parent = transform;
    }

    public void Add(Digestable item)
    {
        print("Stomach added: " + item);
        items.Add(item);
        Swallow(item);
    }

    private void Swallow(Digestable item)
    {
        item.transform.parent = organ.transform;
        item.gameObject.SetActive(false);
    }

    public List<Digestable> Get()
    {
        return items;
    }

    private void Digest()
    {
        foreach (Digestable o in items.ToList()) //added ToList because: http://stackoverflow.com/a/604843
        {
            AbsorbEnergy(o.BeDigested());
            EliminateWaste(o);
        }
    }

    private void AbsorbEnergy(float energyAmount)
    {
        fuel += energyAmount;
    }

    private void EliminateWaste(Digestable item)
    {
        if (item.CaloriesRemaining <= 0)
        {
            print("Completed digestion of : " + item.name + " with " + item.Calories + " Cal");
            items.Remove(item);
            Destroy(item.gameObject);
        }
    }
}
