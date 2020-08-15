using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterChange : MonoBehaviour
{
    public Sprite le1;
    public Sprite le2;
    private bool played1 = false;
    private bool played2 = false;
    [SerializeField] private GameObject black = null;
    [SerializeField] private GameObject slots = null;
    [SerializeField] private GameObject glass = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<SpriteRenderer>().enabled)
        {
            if (!played1)
            {
                played1 = true;
                gameObject.GetComponents<AudioSource>()[0].Play();
                slots.SendMessage("AddSlot", glass);
                
            }

            if (Input.GetKeyDown("space"))
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                black.GetComponent<SpriteRenderer>().enabled = false;
            }

            // Change Later
            if (glass.GetComponent<GlassMove>().isDark)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = le2;

                if (!played2)
                {
                    played2 = true;
                    gameObject.GetComponents<AudioSource>()[1].Play();
                }
            }

            // Change Later
            if (!glass.GetComponent<GlassMove>().isDark)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = le1;
            }
        }
    }
}
