using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoContoller : MonoBehaviour
{
    public int max = 2;
    // Start is called before the first frame update
    private Rigidbody2D rb2d;


    //refrence the Sprite in Game
    SpriteRenderer sprite;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //Debug.Log(Var2 + "World");
        //Var2 = "Goodbye";
        //Debug.Log(Var2 + "World");
        sprite = GetComponent<SpriteRenderer>();


    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        xInput *= max;
        rb2d.velocity = new Vector2(xInput, rb2d.velocity.y);

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Change the 'color' property of the "Sprtie Renderer" to "blue"
            sprite.color = Color.blue;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //Change the 'color' property of the "Sprtie Renderer" to "red"
            sprite.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //Change the 'color' property of the "Sprtie Renderer" to "green"
            sprite.color = Color.green;
        }


    }
    public string nextlevel = "Level 2";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextlevel);
                    break;
                }
        }
    }


}
