using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyOpen : MonoBehaviour
{
    [SerializeField] public GameObject girl;
    [SerializeField] public GameObject slot;
    [SerializeField] public GameObject box;
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
        if (box.GetComponent<BoxCollider2D>().OverlapPoint(transform.position))
        {
            lift();
        }
        else gameObject.transform.position = slot.transform.position;
    }

    private void lift()
    {
        girl.GetComponent<ThirdSceneSpace>().lock1 = true;
        girl.GetComponents<AudioSource>()[1].Play();
        box.SetActive(false);
        gameObject.SetActive(false);
    }
}
