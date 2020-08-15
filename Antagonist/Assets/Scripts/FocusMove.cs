using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusMove : MonoBehaviour
{
    [SerializeField] public GameObject mountain;
	[SerializeField] public GameObject slot;
    [SerializeField] public GameObject girl;
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
		if (mountain.GetComponent<BoxCollider2D>().OverlapPoint(transform.position))
		{
			lift();
		}
		else gameObject.transform.position = slot.transform.position;
	}

	private void lift()
	{
		gameObject.transform.position = slot.transform.position;
        girl.GetComponent<Move>().SendMessage("Smaller");
	}

}
