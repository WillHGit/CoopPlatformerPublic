using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PortalEnd;

    void Start()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "Player1" || collision.transform.name == "Player2")
        {
            collision.transform.position = PortalEnd.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
