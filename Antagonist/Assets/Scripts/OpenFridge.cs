using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFridge : MonoBehaviour
{
	[SerializeField] public GameObject item;
	[SerializeField] public GameObject get;
    [SerializeField] public GameObject girl;
    [SerializeField] public bool Get = false;
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
            if (Get) get.SetActive(true);
			gameObject.SetActive(false);
		}
	}
}
