using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBox : MonoBehaviour
{

    [SerializeField] public GameObject Button;
    [SerializeField] public GameObject girl;
    [SerializeField] public GameObject black;
    [SerializeField] private GameObject suns = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && (girl.transform.position - gameObject.transform.position).magnitude <= 2.2f && suns == null)
        {
            black.GetComponent<SpriteRenderer>().enabled = true;
            Button.SetActive(true);
        }
    }
}
