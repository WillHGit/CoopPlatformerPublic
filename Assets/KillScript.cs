using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KillScript : MonoBehaviour
{
    public GameObject currentlevel;
    public GameObject lastlevel;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player1Spawn;
    public GameObject Player2Spawn;
    public GameObject LivesText;
    public GameObject LevelText;
    public GameObject firstLevel;
    private Vector3 VectorX;
    // Start is called before the first frame update
    void Start()
    {
        VectorX.x = 2.0909f;
        VectorX.y = 5.653898f;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "Player1" || collision.transform.name == "Player2")
        {
            if (int.Parse(LivesText.GetComponent<TMP_Text>().text) > 1)
            {
                LivesText.GetComponent<TMP_Text>().text = (int.Parse(LivesText.GetComponent<TMP_Text>().text)-1).ToString(); 
                LevelText.GetComponent<TMP_Text>().text = lastlevel.name;
                GameObject Clone = Instantiate<GameObject>(lastlevel);
         Clone.transform.position = VectorX;
                Clone.SetActive(true);
                Player1.transform.position = Player1Spawn.transform.position;
                Player2.transform.position = Player2Spawn.transform.position;
                Destroy(currentlevel);
            } 
            else
            {
                LivesText.GetComponent<TMP_Text>().text = "3";
                LevelText.GetComponent<TMP_Text>().text = "Level 1";
                GameObject Clone = Instantiate<GameObject>(firstLevel);
         Clone.transform.position = VectorX;
                Clone.SetActive(true);
                Player1.transform.position = Player1Spawn.transform.position;
                Player2.transform.position = Player2Spawn.transform.position;
                Destroy(currentlevel);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
