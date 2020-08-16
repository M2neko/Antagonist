using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTect : MonoBehaviour
{
    [SerializeField] public GameObject slot;
    [SerializeField] public GameObject col;

    Vector3 cubeScreenPos;
    Vector3 offset;
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(OnMouseDown());
        }
    }


    IEnumerator OnMouseDown()
    {
        cubeScreenPos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cubeScreenPos.z);
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        offset = transform.position - mousePos;

        while (Input.GetMouseButton(0))
        {
            Vector3 curMousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cubeScreenPos.z);
            curMousePos = Camera.main.ScreenToWorldPoint(curMousePos);

            transform.position = curMousePos + offset;
            yield return new WaitForFixedUpdate();
        }
        if (col.GetComponent<BoxCollider2D>().OverlapPoint(transform.position))
        {
            lift();
        }
        else gameObject.transform.position = slot.transform.position;
    }

    private void lift()
    {
        col.GetComponent<GetChair>().locks++;
        gameObject.SetActive(false);
    }
}
