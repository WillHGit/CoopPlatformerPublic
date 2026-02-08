using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public GameObject GamemodeButtons;
    public GameObject PlayButtons;
    public GameObject StartButtons;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlayButtonClick()
    {
        StartButtons.SetActive(false);
        PlayButtons.SetActive(true);
    }

    public void GamemodeButtonClick()
    {
        StartButtons.SetActive(false);
        GamemodeButtons.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
