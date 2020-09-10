using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseAi : MonoBehaviour
{
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
}
