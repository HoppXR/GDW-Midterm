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
        canMove = false;
        transform.position = waypoints[waypointNum].transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            canMove = true;
        }
        
        if (canMove)
        {
            move();
        }
    }

    void move()
    {
        if (waypointNum <= waypoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointNum].transform.position, moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointNum].transform.position)
            {
                waypointNum += 1;
                canMove = false;
            }
        }
    }
}
