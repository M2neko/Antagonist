using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChair : MonoBehaviour
{
    [SerializeField] public int locks = 0;
    [SerializeField] public GameObject jm;
    [SerializeField] public GameObject girl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (locks == 3)
        {
            jm.SetActive(true);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            girl.GetComponent<ThirdSceneSpace>().lock1 = true;
        }
    }
}
