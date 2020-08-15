using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvelopeClick : MonoBehaviour
{
    [SerializeField] private GameObject letter = null;
    [SerializeField] private GameObject black = null;
    [SerializeField] private GameObject girl = null;
    [SerializeField] private GameObject suns = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && (girl.transform.position - gameObject.transform.position).magnitude <= 2.5f && suns == null)
        {
            letter.GetComponent<SpriteRenderer>().enabled = true;
            black.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
