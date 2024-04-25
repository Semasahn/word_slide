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
        "Year\n(Yýl)",
        "People\n(Ýnsanlar)",
        "Way\n(Yol)",
        "Day\n(Gün)",
        "Man\n(Adam)",
        "Thing\n(Þey)",
        "Woman\n(Kadýn)",
        "Life\n(Hayat)",
        "Child\n(Çocuk)",
        "World\n(Dünya)",
        "School\n(Okul)",
        "State\n(Eyalet)",
        "Family\n(Aile)",
        "Student\n(Öðrenci)",
        "Group\n(Grup)",
        "Country\n(Ülke)",
        "Problem\n(Sorun)",
        "Hand\n(El)",
        "Part\n(Parça)",
        "Place\n(Yer)",
        "Case\n(Olay)",
        "Week\n(Hafta)",
        "Company\n(Þirket)",
        "System\n(Sistem)",
        "Program\n(Program)",
        "Question\n(Soru)",
        "Work\n(Ýþ)",
        "Government\n(Hükümet)",
        "Number\n(Sayý)",
        "Night\n(Gece)",
        "Point\n(Nokta)",
        "Home\n(Ev)",
        "Water\n(Su)",
        "Room\n(Oda)",
        "Mother\n(Anne)",
        "Area\n(Alan)",
        "Money\n(Para)",
        "Story\n(Hikâye)",
        "Fact\n(Gerçek)",
        "Month\n(Ay)",
        "Lot\n(Çok)",
        "Right\n(Doðru)",
        "Study\n(Çalýþma)",
        "Book\n(Kitap)",
        "Eye\n(Göz)",
        "Job\n(Meslek)",
        "Word\n(Kelime)",
        "Business\n(Ýþ)",
        "Issue\n(Sorun)",
        "Side\n(Yan)",
        "Kind\n(Çeþit)",
        "Head\n(Baþ)",
        "House\n(Ev)",
        "Service\n(Hizmet)",
        "Friend\n(Arkadaþ)",
        "Father\n(Baba)",
        "Power\n(Güç)",
        "Hour\n(Saat)",
        "Game\n(Oyun)",
        "Line\n(Hat)",
        "End\n(Son)",
        "Member\n(Üye)",
        "Law\n(Kanun)",
        "Car\n(Araba)",
        "City\n(Þehir)",
        "Community\n(Topluluk)",
        "Name\n(Ýsim)",
        "President\n(Baþkan)",
        "Team\n(Takým)",
        "Minute\n(Dakika)",
        "Idea\n(Fikir)",
        "Kid\n(Çocuk)",
        "Body\n(Vücut)",
        "Information\n(Bilgi)",
        "Back\n(Geri)",
        "Parent\n(Ebeveyn)",
        "Face\n(Yüz)",
        "Others\n(Diðerleri)",
        "Level\n(Seviye)",
        "Office\n(Ofis)",
        "Door\n(Kapý)",
        "Health\n(Saðlýk)",
        "Person\n(Kiþi)",
        "Art\n(Sanat)",
        "War\n(Savaþ)",
        "History\n(Tarih)",
        "Party\n(Parti)",
        "Result\n(Sonuç)",
        "Change\n(Deðiþiklilik)",
        "Morning\n(Sabah)",
        "Reason\n(Neden)",
        "Research\n(Araþtýrma)",
        "Girl\n(Kýz)",
        "Love\n(Aþk)",
        "Moment\n(An)",
        "Air\n(Hava)",
        "Teacher\n(Öðretmen)",
        "Building\n(Bina)",
        "Education\n(Eðitim)"
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
