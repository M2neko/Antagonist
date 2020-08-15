using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotProp : MonoBehaviour
{
    [SerializeField] public bool hasProp = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetItem(GameObject newOb)
    {
        newOb.SetActive(true);
        newOb.transform.position = gameObject.transform.position;
        hasProp = true;
    }
}
