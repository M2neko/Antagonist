using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTest : MonoBehaviour
{

    [SerializeField] public GameObject girl;
    [SerializeField] public GameObject item;
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
        if (Input.GetMouseButtonDown(0) && !item.activeInHierarchy && Mathf.Abs(girl.transform.position.x - gameObject.transform.position.x) < 1.0f)
        {
            item.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
