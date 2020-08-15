using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suns : MonoBehaviour
{
    bool stopAdd = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        float x = gameObject.GetComponent<SpriteRenderer>().color.r * 255;
        if (!stopAdd)
        {
            x += 0.5f;
            if (x > 110) stopAdd = true;
        }
        if (stopAdd)
        {
            x -= 0.5f;
            if (x < 67) stopAdd = false;
        }
        gameObject.GetComponent<SpriteRenderer>().color = new Color(x / 255f,0f,18f / 255f);
    }
}
