using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSecret : MonoBehaviour
{
    [SerializeField] public GameObject Buttons;
    [SerializeField] public GameObject black;
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
        if (Input.GetMouseButtonDown(0))
        {
            Buttons.SetActive(true);
            black.SetActive(true);
        }
    }
}
