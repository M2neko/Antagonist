using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeStory : MonoBehaviour
{

    [SerializeField] public Sprite p1;
    [SerializeField] public Sprite p2;
    [SerializeField] public Sprite p3;
    [SerializeField] public Sprite p4;
    [SerializeField] public Sprite p5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Change());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Change()
    {
        yield return new WaitForSeconds(3f);
        gameObject.GetComponent<SpriteRenderer>().sprite = p2;
        yield return new WaitForSeconds(3f);
        gameObject.GetComponent<SpriteRenderer>().sprite = p3;
        yield return new WaitForSeconds(3f);
        gameObject.GetComponent<SpriteRenderer>().sprite = p4;
        yield return new WaitForSeconds(3f);
        gameObject.GetComponent<SpriteRenderer>().sprite = p5;
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
