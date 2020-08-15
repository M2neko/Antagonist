using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slots : MonoBehaviour
{
    GameObject[] children;

    // Start is called before the first frame update
    void Start()
    {
        children = GameObject.FindGameObjectsWithTag("slot");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddSlot(GameObject newOb)
    {
        foreach (GameObject i in children)
        {
            if (!i.GetComponent<SlotProp>().hasProp)
            {
                i.SendMessage("GetItem", newOb);
                break;
            }
        }
    }
}

