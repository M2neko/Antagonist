using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvelopeClick : MonoBehaviour
{
    [SerializeField] private GameObject letter = null;
    [SerializeField] private GameObject black = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            letter.GetComponent<SpriteRenderer>().enabled = true;
            black.GetComponent<SpriteRenderer>().enabled = true;

        }
    }
}
