using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoneyGive : MonoBehaviour
{
    [SerializeField] public GameObject face;
    [SerializeField] public GameObject slot;
    [SerializeField] public GameObject hon;
    [SerializeField] public GameObject ants;
    [SerializeField] public GameObject se;
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
        if (face.GetComponent<BoxCollider2D>().OverlapPoint(transform.position) && !se.activeInHierarchy)
        {
            lift();
        }
        else gameObject.transform.position = slot.transform.position;
    }

    private void lift()
    {
        gameObject.transform.position = slot.transform.position;
        StartCoroutine(GiveFace());
    }

    IEnumerator GiveFace()
    {
        hon.SetActive(true);
        yield return new WaitForSeconds(1f);

        ants.SetActive(true);
        gameObject.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1f);

        hon.SetActive(false);
        ants.SetActive(false);
        yield return new WaitForSeconds(0.2f);

        se.SetActive(true);
    }
}
