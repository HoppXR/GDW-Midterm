using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpace : MonoBehaviour
{
    public GameObject DiseaseCube;

    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
