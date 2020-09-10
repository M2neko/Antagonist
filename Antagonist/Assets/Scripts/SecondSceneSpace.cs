using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondSceneSpace : MonoBehaviour
{
    [SerializeField] public bool lock1 = true;
    [SerializeField] public bool lock2 = true;
    [SerializeField] public bool lock3 = true;
    [SerializeField] public GameObject floor1;
    [SerializeField] public GameObject floor2;
    [SerializeField] public GameObject floor3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -10.67f)
        {
            transform.position = new Vector3(-10.67f, transform.position.y, transform.position.z);
        }

        if (transform.position.x > -10.67f && transform.position.x < -9.25f)
        {
            if (transform.position.y < 3.12f)
            {
                transform.position = new Vector3(-9.25f, transform.position.y, transform.position.z);
            }
            else transform.position = new Vector3(transform.position.x, 4.45f, transform.position.z);
        }

        if (transform.position.x > -9.25f && transform.position.x < -8.13f)
        {
            if (transform.position.y < 1.97f)
            {
                transform.position = new Vector3(-8.13f, transform.position.y, transform.position.z);
            }
            else transform.position = new Vector3(transform.position.x, 3.11f, transform.position.z);
        }

        if (transform.position.x > -8.13f && transform.position.x < -7.37f)
        {
            if (transform.position.y < 0.79f)
            {
                transform.position = new Vector3(-7.37f, transform.position.y, transform.position.z);
            }
            else transform.position = new Vector3(transform.position.x, 1.96f, transform.position.z);
        }

        if (transform.position.x > -7.37f && transform.position.x < -6.23f)
        {
            if (transform.position.y < -0.24f)
            {
                transform.position = new Vector3(-6.23f, transform.position.y, transform.position.z);
            }
            else transform.position = new Vector3(transform.position.x, 0.78f, transform.position.z);
        }

        if (transform.position.x > -7.37f && transform.position.x < -6.65f)
        {
            if (transform.position.y < -0.24f)
            {
                transform.position = new Vector3(-6.65f, transform.position.y, transform.position.z);
            }
            else transform.position = new Vector3(transform.position.x, 0.6f, transform.position.z);
        }



        if (lock1)
        {
            if (transform.position.x > -6.65f)
            {
                transform.position = new Vector3(-6.65f, transform.position.y, transform.position.z);
            }
        }

        else if (lock2)
        {
            floor1.SetActive(true);
            if (transform.position.x > -1.77f)
            {
                transform.position = new Vector3(-1.77f, transform.position.y, transform.position.z);
            }
        }

        else if (lock3)
        {
            floor2.SetActive(true);
            if (transform.position.x > 3.04f)
            {
                transform.position = new Vector3(3.04f, transform.position.y, transform.position.z);
            }
        }

        else
        {
            floor3.SetActive(true);
            if (transform.position.x > -6.65f && transform.position.x < 3.78f)
            {
                if (transform.position.y < -0.04f)
                {
                    transform.position = new Vector3(3.79f, transform.position.y, transform.position.z);
                }
                else transform.position = new Vector3(transform.position.x, 0.6f, transform.position.z);
            }

            if (transform.position.x > 3.78f)
            {
                transform.position = new Vector3(transform.position.x, -0.05f, transform.position.z);
            }

            if (transform.position.x > 12.21f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }







    }
}
