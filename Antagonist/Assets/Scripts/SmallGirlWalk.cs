using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallGirlWalk : MonoBehaviour
{
    [SerializeField] public GameObject girl;
    [SerializeField] public GameObject key;
    [SerializeField] public GameObject doorkey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.y - -1.47f) > 0.01f)
        {
            transform.position = new Vector3(transform.position.x, -1.47f, transform.position.z);
        }

        if (transform.position.x > 1.451f)
        {
            transform.position = new Vector3(1.451f, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -0.057f)
        {
            girl.SetActive(true);
            girl.GetComponent<Move>().SendMessage("Bigger");
            key.SetActive(false);
            doorkey.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
