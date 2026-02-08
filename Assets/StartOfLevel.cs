using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartOfLevel : MonoBehaviour
{
    public GameObject currentlevel;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player1Spawn;
    public GameObject Player2Spawn;
    public GameObject LivesText;
    public GameObject LevelText;
    private Vector3 VectorX;
    // Start is called before the first frame update
    void Start()
    {
        VectorX.x = 2.0909f;
        VectorX.y = 5.653898f;
        Player1.transform.position = Player1Spawn.transform.position;
        Player2.transform.position = Player2Spawn.transform.position;
        GameObject Clone = Instantiate<GameObject>(currentlevel);
         Clone.transform.position = VectorX;
        Clone.SetActive(true);
        LivesText.GetComponent<TMP_Text>().text = "3";
        LevelText.GetComponent<TMP_Text>().text = currentlevel.name;
    }
    public void GameBegin()
    {
        VectorX.x = 2.0909f;
        VectorX.y = 5.653898f;
        Player1.transform.position = Player1Spawn.transform.position;
        Player2.transform.position = Player2Spawn.transform.position;
        GameObject Clone = Instantiate<GameObject>(currentlevel);
         Clone.transform.position = VectorX;
        Clone.SetActive(true);
        LivesText.GetComponent<TMP_Text>().text = "3";
        LevelText.GetComponent<TMP_Text>().text = currentlevel.name;
    }
    void LastLevel(GameObject lastlevel)
    {
        Player1.transform.position = Player1Spawn.transform.position;
        Player2.transform.position = Player2Spawn.transform.position;
        GameObject Clone = Instantiate<GameObject>(lastlevel);
        Clone.SetActive(true);
        LevelText.GetComponent<TMP_Text>().text = lastlevel.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
