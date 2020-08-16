using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSecretButton : MonoBehaviour
{
    [SerializeField] public GameObject Button2;
    [SerializeField] public GameObject Button5;
    [SerializeField] public GameObject Button7;
    [SerializeField] public GameObject Button8;
    [SerializeField] public GameObject Black;
    [SerializeField] public GameObject girl;
    [SerializeField] public GameObject left;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool but2 = Button2.GetComponent<Buttons>().Down;
        bool but5 = Button5.GetComponent<Buttons>().Down;
        bool but7 = Button7.GetComponent<Buttons>().Down;
        bool but8 = Button8.GetComponent<Buttons>().Down;
        if (but2 && but5 && but7 && but8 && !girl.GetComponent<SecondSceneSpace>().lock1)
        {
            Black.SetActive(false);
            gameObject.SetActive(false);
            girl.GetComponent<SecondSceneSpace>().lock2 = false;
            left.SetActive(true);

        }
        /*
        if ((but1 && but3 && but0 && !but9) || (but1 && but9 && but0 && !but3) || (but3 && but9 && but0 && !but1) || (but1 && but0 && !but3 && !but9))  {
            Button1.GetComponent<Buttons>().Down = false;
            Button3.GetComponent<Buttons>().Down = false;
            Button9.GetComponent<Buttons>().Down = false;
            Button0.GetComponent<Buttons>().Down = false;
        }
        */
        if (Input.GetKeyDown("space"))
        {
            Black.SetActive(false);
            Button2.GetComponent<Buttons>().Down = false;
            Button5.GetComponent<Buttons>().Down = false;
            Button7.GetComponent<Buttons>().Down = false;
            Button8.GetComponent<Buttons>().Down = false;
            gameObject.SetActive(false);
        }


    }
}
