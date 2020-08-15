using System.Collections;
using UnityEngine;

public class SunsClick : MonoBehaviour
{

    Vector3 cubeScreenPos;
    Vector3 offset;
    [SerializeField] private GameObject sun = null;
    [SerializeField] private GameObject black = null;
    [SerializeField] private GameObject girl = null;
    [SerializeField] private GameObject back = null;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && (girl.transform.position - gameObject.transform.position).magnitude < 2.6f)
        {
            Vector3 v3 = Camera.main.WorldToScreenPoint(transform.position);
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = v3.z;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            //Debug.Log(mousePos);
            if (mousePos.x > -2.4f && mousePos.x < -1.3f && mousePos.y < 1.1f && mousePos.y > 0.7f)
            {
                StartCoroutine(OnMouseDown());
            }
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
        lift();
    }

    private void lift()
    {
        sun.transform.position = gameObject.transform.position;

        sun.GetComponent<SpriteRenderer>().enabled = true;
        
        black.GetComponent<SpriteRenderer>().enabled = false;

        back.GetComponent<BackGroundShake>().isEnable = true;

        Destroy(gameObject);
    }
}