using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondCard : MonoBehaviour
{
    private swipeEffect _swipeEffect;
    private GameObject _firstCard;

    public Sprite[] cardSprites; 

    void Start()
    {
        int cardIndex = Random.Range(0, cardSprites.Length);

        Sprite randomCardSprite = cardSprites[cardIndex];

        gameObject.GetComponent<Image>().sprite = randomCardSprite;

        _swipeEffect = FindObjectOfType<swipeEffect>();
        _firstCard = _swipeEffect.gameObject;

        _swipeEffect.cardMoved += CardMovedFront;

        transform.localScale = new Vector3(3f, 3f, 3f);
    }

    void Update()
    {
        float distanceMoved = _firstCard.transform.localPosition.x;
        if (Mathf.Abs(distanceMoved) > 0)
        {
            float step = Mathf.SmoothStep(3f, 3f, Mathf.Abs(distanceMoved) / (Screen.width / 2));
            transform.localScale = new Vector3(step, step, step);
        }
    }

    void CardMovedFront()
    {
        gameObject.AddComponent<swipeEffect>();
        Destroy(this);
    }
}
