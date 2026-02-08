using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResetLevel : MonoBehaviour
{
    public GameObject TxtHolder;
    public string CurrentLevelName;
    public GameObject CurrentLevel;
    public GameObject CurrentLevelNew;
    private Vector3 VectorX;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player1Spawn;
    public GameObject Player2Spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Click()
    {
            VectorX.x = 2.0909f;
        VectorX.y = 5.653898f;
        Player1.transform.position = Player1Spawn.transform.position;
        Player2.transform.position = Player2Spawn.transform.position;
        CurrentLevel = GameObject.Find(CurrentLevelName+"(Clone)");
        Destroy(CurrentLevel);
        CurrentLevelNew = GameObject.Find(CurrentLevelName);
        GameObject Clone = Instantiate<GameObject>(CurrentLevelNew);
         Clone.transform.position = VectorX;
        Clone.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        CurrentLevelName = TxtHolder.GetComponent<TMP_Text>().text;
    }
}