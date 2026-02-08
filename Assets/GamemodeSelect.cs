using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamemodeSelect : MonoBehaviour
{
    public GameObject Player1;

    public GameObject Player2;
    public GameObject MainMenu;
    public GameObject GamemodeMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void singlePlayer()
    {
        Player1.GetComponent<PlayerController>().Arrows = true;
        Player2.GetComponent<PlayerController>().Arrows = true;
    }

    public void multiPlayer()
    {
        Player1.GetComponent<PlayerController>().Arrows = true;
        Player2.GetComponent<PlayerController>().Arrows = false;
    }

    public void Back()
    {

        MainMenu.SetActive(true);
        GamemodeMenu.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
