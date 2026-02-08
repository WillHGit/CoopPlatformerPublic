using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelController : MonoBehaviour
{
    public GameObject currentlevel;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player1Spawn;
    public GameObject Player2Spawn;
    public GameObject LivesText;
    public GameObject LevelText;
    private Vector3 VectorX;

    public GameObject Menu;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Clicked(string ButtonName)
    {
        currentlevel = GameObject.Find(ButtonName);
        VectorX.x = 2.0909f;
        VectorX.y = 5.653898f;
        GameObject Clone = Instantiate<GameObject>(currentlevel);
        Clone.transform.position = VectorX;
        Clone.SetActive(true);
        LivesText.GetComponent<TMP_Text>().text = "3";
        LevelText.GetComponent<TMP_Text>().text = currentlevel.name;
        Player1 = GameObject.Find("Player1");
        Player2 = GameObject.Find("Player2");
        Player1Spawn = GameObject.Find("Player1Spawn");
        Player2Spawn = GameObject.Find("Player2Spawn");
        Player1.transform.position = Player1Spawn.transform.position;
        Player2.transform.position = Player2Spawn.transform.position;
        Menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
