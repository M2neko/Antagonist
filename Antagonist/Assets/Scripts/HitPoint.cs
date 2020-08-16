using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPoint : MonoBehaviour
{
    [SerializeField] public GameObject b1;
    [SerializeField] public GameObject b2;
    [SerializeField] public GameObject b3;
    [SerializeField] public GameObject b4;
    [SerializeField] public GameObject b5;
    [SerializeField] public GameObject b6;
    [SerializeField] public GameObject girl;

    private bool ok1 = true;
    private bool ok2 = true;
    private bool ok3 = true;
    private bool ok4 = true;
    private bool ok5 = true;
    private bool ok6 = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (b1.GetComponent<Buttons>().Down && ok1)
        {
            ok1 = false;
            // play music
        }

        else if (b2.GetComponent<Buttons>().Down && b1.GetComponent<Buttons>().Down && !ok1 && ok2)
        {
            ok2 = false;
        }

        else if (b3.GetComponent<Buttons>().Down && b2.GetComponent<Buttons>().Down && b3.GetComponent<Buttons>().Down && !ok1 && !ok2 && ok3)
        {
            ok3 = false;
        }

        else if (b4.GetComponent<Buttons>().Down && b3.GetComponent<Buttons>().Down && b2.GetComponent<Buttons>().Down && b3.GetComponent<Buttons>().Down && !ok1 && !ok2 && !ok3 && ok4)
        {
            ok4 = false;
        }

        else if (b5.GetComponent<Buttons>().Down && b4.GetComponent<Buttons>().Down && b3.GetComponent<Buttons>().Down && b2.GetComponent<Buttons>().Down && b3.GetComponent<Buttons>().Down && !ok1 && !ok2 && !ok3 && !ok4 && ok5)
        {
            ok5 = false;
        }

        else if (b6.GetComponent<Buttons>().Down && b5.GetComponent<Buttons>().Down && b4.GetComponent<Buttons>().Down && b3.GetComponent<Buttons>().Down && b2.GetComponent<Buttons>().Down && b3.GetComponent<Buttons>().Down && !ok1 && !ok2 && !ok3 && !ok4 && !ok5 && ok6)
        {

            girl.GetComponent<SecondSceneSpace>().lock3 = false;
            gameObject.SetActive(false);
        }
    }
}
