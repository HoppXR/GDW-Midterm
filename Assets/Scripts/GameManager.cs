using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerMove[] players;
    private int currentPlayerIndex = 0;

    void Start()
    {
        StartTurn();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            EndTurn();
        }    
    }

    void StartTurn()
    {
        players[currentPlayerIndex].MoveEnabled();
    }

    void EndTurn()
    {
        players[currentPlayerIndex].MoveDisabled();

        currentPlayerIndex = (currentPlayerIndex + 1) % players.Length;

        StartTurn();
    }
}
