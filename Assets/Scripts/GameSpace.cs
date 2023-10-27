using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameSpace : MonoBehaviour
{
    [SerializeField] private int diseaseCubes;
    [SerializeField] Sprite[] diseaseLevel;
    bool canTreat;

    void Start()
    {
        canTreat = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            treatDisease();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canTreat = true;
        }
    }

    void treatDisease()
    {
        if (canTreat == true)
        {
            canTreat = false;

            if (diseaseCubes == 1)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = diseaseLevel[1];
            }
            else if (diseaseCubes == 2)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = diseaseLevel[2];
            }
            else if (diseaseCubes == 3)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = diseaseLevel[3];
            }
        }
    }
}
