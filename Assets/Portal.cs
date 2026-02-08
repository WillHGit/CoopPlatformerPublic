using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PortalEnd;

    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "Box" )
        {
            collision.transform.position = PortalEnd.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
