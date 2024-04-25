using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using TMPro;
using Unity.Burst.Intrinsics;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class RandomWord : MonoBehaviour
{
    private TextMeshProUGUI cardText;

    public Transform cardParent;

    public instantiator instantiator;

    List<string> words = new List<string>()
    {
        "Time\n(Zaman)",
        "Year\n(Y�l)",
        "People\n(�nsanlar)",
        "Way\n(Yol)",
        "Day\n(G�n)",
        "Man\n(Adam)",
        "Thing\n(�ey)",
        "Woman\n(Kad�n)",
        "Life\n(Hayat)",
        "Child\n(�ocuk)",
        "World\n(D�nya)",
        "School\n(Okul)",
        "State\n(Eyalet)",
        "Family\n(Aile)",
        "Student\n(��renci)",
        "Group\n(Grup)",
        "Country\n(�lke)",
        "Problem\n(Sorun)",
        "Hand\n(El)",
        "Part\n(Par�a)",
        "Place\n(Yer)",
        "Case\n(Olay)",
        "Week\n(Hafta)",
        "Company\n(�irket)",
        "System\n(Sistem)",
        "Program\n(Program)",
        "Question\n(Soru)",
        "Work\n(��)",
        "Government\n(H�k�met)",
        "Number\n(Say�)",
        "Night\n(Gece)",
        "Point\n(Nokta)",
        "Home\n(Ev)",
        "Water\n(Su)",
        "Room\n(Oda)",
        "Mother\n(Anne)",
        "Area\n(Alan)",
        "Money\n(Para)",
        "Story\n(Hik�ye)",
        "Fact\n(Ger�ek)",
        "Month\n(Ay)",
        "Lot\n(�ok)",
        "Right\n(Do�ru)",
        "Study\n(�al��ma)",
        "Book\n(Kitap)",
        "Eye\n(G�z)",
        "Job\n(Meslek)",
        "Word\n(Kelime)",
        "Business\n(��)",
        "Issue\n(Sorun)",
        "Side\n(Yan)",
        "Kind\n(�e�it)",
        "Head\n(Ba�)",
        "House\n(Ev)",
        "Service\n(Hizmet)",
        "Friend\n(Arkada�)",
        "Father\n(Baba)",
        "Power\n(G��)",
        "Hour\n(Saat)",
        "Game\n(Oyun)",
        "Line\n(Hat)",
        "End\n(Son)",
        "Member\n(�ye)",
        "Law\n(Kanun)",
        "Car\n(Araba)",
        "City\n(�ehir)",
        "Community\n(Topluluk)",
        "Name\n(�sim)",
        "President\n(Ba�kan)",
        "Team\n(Tak�m)",
        "Minute\n(Dakika)",
        "Idea\n(Fikir)",
        "Kid\n(�ocuk)",
        "Body\n(V�cut)",
        "Information\n(Bilgi)",
        "Back\n(Geri)",
        "Parent\n(Ebeveyn)",
        "Face\n(Y�z)",
        "Others\n(Di�erleri)",
        "Level\n(Seviye)",
        "Office\n(Ofis)",
        "Door\n(Kap�)",
        "Health\n(Sa�l�k)",
        "Person\n(Ki�i)",
        "Art\n(Sanat)",
        "War\n(Sava�)",
        "History\n(Tarih)",
        "Party\n(Parti)",
        "Result\n(Sonu�)",
        "Change\n(De�i�iklilik)",
        "Morning\n(Sabah)",
        "Reason\n(Neden)",
        "Research\n(Ara�t�rma)",
        "Girl\n(K�z)",
        "Love\n(A�k)",
        "Moment\n(An)",
        "Air\n(Hava)",
        "Teacher\n(��retmen)",
        "Building\n(Bina)",
        "Education\n(E�itim)"
    };

    void Start()
    {
        Debug.Log(instantiator.instantiatedCardPrefab.transform.GetChild(0).gameObject.name);
        cardText = instantiator.instantiatedCardPrefab.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        CreateWord();
    }

    public void CreateWord()
    {
        int wordIndex = Random.Range(0, words.Count);

        cardText = instantiator.instantiatedCardPrefab.transform.GetChild(0).GetComponent<TextMeshProUGUI>();

        cardText.text = words[wordIndex];

        words.RemoveAt(wordIndex);
    }

}
