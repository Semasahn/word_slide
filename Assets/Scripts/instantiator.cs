using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiator : MonoBehaviour
{
    public GameObject cardPrefab;
    public GameObject instantiatedCardPrefab;
    public RandomWord randomWord;
    public bool canIncreasePoint;

    private void Start()
    {
        canIncreasePoint = false;
    }

    void InstantiateCard()
    {
        instantiatedCardPrefab = Instantiate(cardPrefab, transform, false);
        instantiatedCardPrefab.transform.SetAsFirstSibling();
        randomWord.CreateWord();
        canIncreasePoint = true;
    }
    void Update()
    {
        if (transform.childCount < 2)
        {
            InstantiateCard();
        }
    }
}

