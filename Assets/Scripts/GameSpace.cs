using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameSpace : MonoBehaviour
{
    [SerializeField] private int diseaseCubes;
    [SerializeField] Sprite[] diseaseLevel;
    bool canTreat;
    bool canTreatAll;

    bool canAddDisease;

    void Start()
    {
        canTreat = false;
        canTreatAll = false;
    }

    private void Update()
    {
        updateSprite();

        if (Input.GetMouseButtonDown(0))
        {
            treatDisease();
        }

        if (Input.GetMouseButtonDown(1))
        {
            addDisease();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canTreat = true;
            canAddDisease = true;
        }
        else if (other.gameObject.CompareTag("Medic"))
        {
            canTreatAll = true;
        }
    }

    void treatDisease()
    {
        if (canTreat == true)
        {
            Debug.Log("TREATDISEASE");
            canTreat = false;
            diseaseCubes--;
        }
        else if (canTreatAll == true) 
        {
            Debug.Log("MEDICTREAT");
            canTreatAll = false;
            diseaseCubes = 0;
        }
    }

    void addDisease()
    {
        if (canAddDisease == true)
        {
            Debug.Log("DISEASE");
            canAddDisease = false;
            diseaseCubes++;
        }
    }

    void updateSprite()
    {
        if (diseaseCubes == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = diseaseLevel[0];
        }
        else if (diseaseCubes == 1)
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
