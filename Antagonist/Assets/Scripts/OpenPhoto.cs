using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPhoto : MonoBehaviour
{
    [SerializeField] public GameObject item;
    [SerializeField] public GameObject black;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            black.SetActive(false);
            gameObject.SetActive(false);
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && !item.activeInHierarchy)
        {
            item.SetActive(true);
            black.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
