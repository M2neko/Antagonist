using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiAi : MonoBehaviour
{

    [SerializeField] public GameObject photo;
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
            black.SetActive(true);
            photo.SetActive(true);
            //gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
