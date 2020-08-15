using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSceneSpace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // bottom
        if (gameObject.GetComponent<Rigidbody2D>().position.y < -3.35f)
        {
            gameObject.GetComponent<Rigidbody2D>().position = new Vector2(gameObject.GetComponent<Rigidbody2D>().position.x, -3.35f);
        }


        // cupboard
        if (gameObject.GetComponent<Rigidbody2D>().position.x > -4.5f && gameObject.GetComponent<Rigidbody2D>().position.x < 2.92f)
        {
            if (gameObject.GetComponent<Rigidbody2D>().position.y > -1.45f)
            {
                gameObject.GetComponent<Rigidbody2D>().position = new Vector2(gameObject.GetComponent<Rigidbody2D>().position.x, -1.45f);
            }
        }

        // Left
        if (gameObject.GetComponent<Rigidbody2D>().position.x < -10f)
        {
            gameObject.GetComponent<Rigidbody2D>().position = new Vector2(-9.9f, gameObject.GetComponent<Rigidbody2D>().position.y);
        }


        // desk
        if (gameObject.GetComponent<Rigidbody2D>().position.x > -10.0f && gameObject.GetComponent<Rigidbody2D>().position.x < -7.2f)
        {
            if (gameObject.GetComponent<Rigidbody2D>().position.y > -2.05f)
            {
                gameObject.GetComponent<Rigidbody2D>().position = new Vector2(gameObject.GetComponent<Rigidbody2D>().position.x, -2.05f);
            }
        }

        // chair
        if (gameObject.GetComponent<Rigidbody2D>().position.x > -7.2f && gameObject.GetComponent<Rigidbody2D>().position.x < -4.5f)
        {
            if (gameObject.GetComponent<Rigidbody2D>().position.y > -1.85f)
            {
                gameObject.GetComponent<Rigidbody2D>().position = new Vector2(gameObject.GetComponent<Rigidbody2D>().position.x, -1.85f);
            }
        }

        // bed
        if (gameObject.GetComponent<Rigidbody2D>().position.y > -2.8f && gameObject.GetComponent<Rigidbody2D>().position.x > 2.92f && gameObject.GetComponent<Rigidbody2D>().position.x < 9.3f)
        {

            if (gameObject.GetComponent<Rigidbody2D>().position.x > 2.92f)
            {
                gameObject.GetComponent<Rigidbody2D>().position = new Vector2(gameObject.GetComponent<Rigidbody2D>().position.x, -2.8f);
            }

            if (gameObject.GetComponent<Rigidbody2D>().position.y > -2.8f)
            {
                gameObject.GetComponent<Rigidbody2D>().position = new Vector2(2.92f, gameObject.GetComponent<Rigidbody2D>().position.y);
            }
        }

        // door
        if (gameObject.GetComponent<Rigidbody2D>().position.x > 9.3f)
        {
            if (gameObject.GetComponent<Rigidbody2D>().position.y > -2f)
            {
                gameObject.GetComponent<Rigidbody2D>().position = new Vector2(gameObject.GetComponent<Rigidbody2D>().position.x, -2f);
            }
        }

        // Right
        if (gameObject.GetComponent<Rigidbody2D>().position.x > 10.2f)
        {
            gameObject.GetComponent<Rigidbody2D>().position = new Vector2(10.2f, gameObject.GetComponent<Rigidbody2D>().position.y);
        }

    }
}
