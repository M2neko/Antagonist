using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThirdSceneSpace : MonoBehaviour
{
    [SerializeField] public bool lock1 = false;
    [SerializeField] public GameObject gameset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -11.36f)
        {
            transform.position = new Vector3(-11.36f, transform.position.y, transform.position.z);
        }

        if (transform.position.x > 11.59f && !lock1)
        {
            transform.position = new Vector3(11.59f, transform.position.y, transform.position.z);
        }

        if (lock1) gameset.SetActive(true);

        if (transform.position.x > 11.59f && lock1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
