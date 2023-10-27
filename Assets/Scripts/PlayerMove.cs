using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Transform[] waypoints;
    [SerializeField] float moveSpeed;
    int waypointNum = 0;
    bool canMove;

    void Start()
    {
        MoveDisabled();
        transform.position = waypoints[waypointNum].transform.position;
    }

    void Update()
    {  
        if (canMove)
        {
            move();
        }
    }

    public void MoveEnabled()
    {
        canMove = true;
    }

    public void MoveDisabled()
    {
        canMove = false;
    }

    void move()
    {
        if (waypointNum <= waypoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointNum].transform.position, moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointNum].transform.position)
            {
                MoveDisabled();
                waypointNum += 1;
            }
        }
    }
}
