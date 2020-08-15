using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerectButtons : MonoBehaviour
{
    [SerializeField] public GameObject Button1;
    [SerializeField] public GameObject Button3;
    [SerializeField] public GameObject Button9;
    [SerializeField] public GameObject Button0;
    [SerializeField] public GameObject Sis;
    [SerializeField] public GameObject Black;
    [SerializeField] public GameObject Box;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool but1 = Button1.GetComponent<Buttons>().Down;
        bool but3 = Button3.GetComponent<Buttons>().Down;
        bool but9 = Button9.GetComponent<Buttons>().Down;
        bool but0 = Button0.GetComponent<Buttons>().Down;
        if (but1 && but3 && but9 && but0)
        {
            Black.GetComponent<SpriteRenderer>().enabled = false;
            Sis.SetActive(true);
            Box.SetActive(false);
            gameObject.SetActive(false);

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
            Black.GetComponent<SpriteRenderer>().enabled = false;
            Button1.GetComponent<Buttons>().Down = false;
            Button3.GetComponent<Buttons>().Down = false;
            Button9.GetComponent<Buttons>().Down = false;
            Button0.GetComponent<Buttons>().Down = false;
            gameObject.SetActive(false);
        }

        
    }
}
