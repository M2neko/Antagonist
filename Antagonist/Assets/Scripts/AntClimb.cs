using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntClimb : MonoBehaviour
{
    [SerializeField] public GameObject hon;
    [SerializeField] public GameObject cube;

    Vector2 _target;
    Vector2 _from;
    float _moveTime = 5;
    float _timeCount = 0;
    private bool isMo = false;

    void Start()
    {
        _from = transform.position;
        _target = hon.transform.position;
    }
    void Update()
    {
        if (isMo)
        {
            _timeCount += Time.deltaTime;
            this.transform.position = Vector2.Lerp(_from, _target, _timeCount / _moveTime);
        }
    }

    public void Move()
    {
        isMo = true;
        hon.SetActive(true);
        StartCoroutine("Mo");
    }

    IEnumerator Mo()
    {
        yield return new WaitForSeconds(5f);
        hon.SetActive(false);
        cube.SetActive(true);
    }
}
