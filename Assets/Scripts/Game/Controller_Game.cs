using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Game : MonoBehaviour
{
    public GameObject buttonGroupPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PromptPlayerMove()
    {
        // This method is called to prompt the player to move, e.g attack or use an item.

        GameObject buttonGroup = GameObject.Find("ButtonGroup_PlayerMove");

        if(buttonGroup == null)
        {
            buttonGroup = (GameObject) Instantiate(buttonGroupPrefab);
            buttonGroup.SetActive(true);
        } else
        {
            if (buttonGroup.activeSelf)
            {
                buttonGroup.SetActive(false);
            }
        }
    }

    public void EnemyMove()
    {
        // This method is called once the enemy attacks or heals itself.
    }
}
