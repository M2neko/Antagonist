using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleWo : MonoBehaviour
{
    [SerializeField] public GameObject item;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (item.GetComponent<GlassMove>().isDark)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
