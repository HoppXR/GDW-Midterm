using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameSpace : MonoBehaviour
{
    [SerializeField] private int diseaseCubes;

    [SerializeField] private Sprite dc1, dc2, dc3;

    void Start()
    {

    }

    private void Update()
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
