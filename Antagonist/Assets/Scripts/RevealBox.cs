using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealBox : MonoBehaviour
{
    [SerializeField] public GameObject box1;
    [SerializeField] public GameObject box2;
    [SerializeField] public GameObject girl;
    [SerializeField] public GameObject suns;
    private int count = 0;
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
            if (count == 0)
            {
                box1.SetActive(true);
                count++;
            }
            else if (count == 1)
            {
                box2.SetActive(true);
                count++;
            }
            else if (count == 2)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
