using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Game : MonoBehaviour
{
    public GameObject buttonGroup;
    private Transform positionTransform;

    public Enemy enemy;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        positionTransform = GameObject.Find("ButtonGroup_PlayerMove").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleMovePrompt()
    {
        // This method is called to toggle the player's move prompt, e.g show the attack or item buttons.
        buttonGroup.SetActive(!buttonGroup.activeSelf);
    }
}
