using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SisMove : MonoBehaviour
{
    [SerializeField] public Sprite empty;
    [SerializeField] public GameObject box1;
    [SerializeField] public GameObject box2;
    [SerializeField] public GameObject slot;
    [SerializeField] public GameObject focus;
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
        if (box1.GetComponent<BoxCollider2D>().OverlapPoint(transform.position))
        {
            lift(box1);
        }
        else if (box2.GetComponent<BoxCollider2D>().OverlapPoint(transform.position))
        {
            lift(box2);
            focus.SetActive(true);
        }
        else gameObject.transform.position = slot.transform.position;
    }
    
    private void lift(GameObject obj)
    {
        gameObject.transform.position = slot.transform.position;
        obj.GetComponent<SpriteRenderer>().sprite = empty;
        obj.GetComponent<BoxCollider2D>().enabled = false;
    }
    
}
