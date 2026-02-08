using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReversePressurePlate : MonoBehaviour
{
    public float startPos;
    bool movingBack = false;
    bool atLimit = false;
    public GameObject door;
    public GameObject Stone1;
    public GameObject Stone2;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.y;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.transform.name == "Box" && transform.position.y > (startPos - transform.localScale.y/12.4))
        {
            transform.Translate(0, -0.001f, 0);
            movingBack = false;
            atLimit = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "Box" )
        {
            collision.transform.parent = transform;
            GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.name == "Box" )
        {
            movingBack = true;

            collision.transform.parent = transform.parent;
            GetComponent<SpriteRenderer>().color = Color.white;
            atLimit = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (movingBack == true)
        {
            if (transform.position.y < startPos)
            {
                transform.Translate(0,0.001f,0);
            }
            else
            {
                movingBack = false;
            }
        }
        if (atLimit == true )
        {
            door.GetComponent<BoxCollider2D>().enabled = true;
            Stone1.GetComponent<SpriteRenderer>().color = Color.white;
            Stone2.GetComponent<SpriteRenderer>().color = Color.white;
        }
        else
        {
            door.GetComponent<BoxCollider2D>().enabled = false;
            Stone1.GetComponent<SpriteRenderer>().color = Color.grey;
            Stone2.GetComponent<SpriteRenderer>().color = Color.grey;
        }
    }
}
