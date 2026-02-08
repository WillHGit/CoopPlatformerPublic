using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndOfLevel : MonoBehaviour
{
    public GameObject currentlevel;
    public GameObject nextlevel;
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
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "Player1" || collision.transform.name == "Player2")
        {
            GameObject Clone = Instantiate<GameObject>(nextlevel);
            Clone.transform.position = VectorX;
            Clone.SetActive(true);
            Player1.transform.position = Player1Spawn.transform.position;
            Player2.transform.position = Player2Spawn.transform.position;
            Destroy(currentlevel);
            if (int.Parse(LivesText.GetComponent<TMP_Text>().text) < 3)
            {
                LivesText.GetComponent<TMP_Text>().text = (int.Parse(LivesText.GetComponent<TMP_Text>().text)).ToString(); 
                LevelText.GetComponent<TMP_Text>().text = nextlevel.name;
            } 
            else
            {
                LivesText.GetComponent<TMP_Text>().text = "3";
                LevelText.GetComponent<TMP_Text>().text = nextlevel.name;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
