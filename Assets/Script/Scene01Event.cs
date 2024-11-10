using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01Event : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject charTresna;
    public GameObject charLaksmi;
    public GameObject textBox;

    [SerializeField] AudioSource girlSigh;
    [SerializeField] AudioSource girlGasp;
    [SerializeField] AudioSource girlWhat;


    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLenght;
    [SerializeField] int textLenght;
    [SerializeField] GameObject mainTextObject;
    [SerializeField] GameObject nextButton;
    [SerializeField] int eventPos = 0;
    [SerializeField] GameObject charName;
    [SerializeField] GameObject fadeOut;


    void Update()
    {
        textLenght = TextCreator.charCount;
    }

    void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
        charTresna.SetActive(true);
        yield return new WaitForSeconds(2);
        // this is where our text function will go in future tutorial
        mainTextObject.SetActive(true);
        textToSpeak = "This is no good too...";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        girlGasp.Play();
        nextButton.SetActive(true);
        eventPos = 1;
        
    }

    IEnumerator EventOne()
    {
        //one
        nextButton.SetActive(false);
        charTresna.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Tresna";
        textToSpeak = "(She grabbed the paper and dropit gently to the side) (as the paper drops slowly) (It was then swayed by the wind as she leans on her chair looking upset.)";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        girlGasp.Play();
        nextButton.SetActive(true);
        eventPos = 2;
    }

    IEnumerator EventTwo()
    {
        //two
        nextButton.SetActive(false);
        charTresna.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Tresna";
        textToSpeak = "(In a brief moment a foot step is approaching, as it begins to get close it stopped.)";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        girlGasp.Play();
        nextButton.SetActive(true);
        eventPos = 3;
    }

    IEnumerator EventThree()
    {
        //two
        nextButton.SetActive(false);
        charLaksmi.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Laksmi";
        textToSpeak = "(Sigh as she looks at the messy sight around the pavilion) haven't find your enlightenment, Guru?.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        girlSigh.Play();
        nextButton.SetActive(true);
        eventPos = 4;
    }

    IEnumerator EventFour()
    {
        //three
        nextButton.SetActive(false);
        charLaksmi.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Tresna";
        textToSpeak = "It Will come around when the time is right. (as she smile glancing her eyes with a gentle look towards Laksmi.)";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        girlGasp.Play();
        nextButton.SetActive(true);
        eventPos = 5;
    }

    IEnumerator EventFive()
    {
        //three
        nextButton.SetActive(false);
        charLaksmi.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Laksmi";
        textToSpeak = "(looking at the pile of papers all around the floor and the table) You’ve been here a while Guru, perhaps you should put thep end own for today.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        girlSigh.Play();
        nextButton.SetActive(true);
        eventPos = 6;
    }

    IEnumerator EventSix()
    {
        //three
        nextButton.SetActive(false);
        charLaksmi.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Tresna";
        textToSpeak = "Patient Laksmi, the tree may be tall but the fruit shall be sweet.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        girlGasp.Play();
        nextButton.SetActive(true);
        eventPos = 7;
    }

    IEnumerator EventSeven()
    {
        //three
        nextButton.SetActive(false);
        charLaksmi.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Tresna";
        textToSpeak = "Tresna take the cup on the table that is half filled with tea and sips it slowly.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        girlGasp.Play();
        nextButton.SetActive(true);
        eventPos = 8;
    }

    IEnumerator EventEight()
    {
        //three
        nextButton.SetActive(false);
        charLaksmi.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Laksmi";
        textToSpeak = "It’s not like you’ll ever climb a tree to get a fruit, Guru.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        girlSigh.Play();
        nextButton.SetActive(true);
        eventPos = 9;
    }

    IEnumerator EventNine()
    {
        //three
        nextButton.SetActive(false);
        charLaksmi.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Laksmi";
        textToSpeak = "(While Laksmi see Tresna taking a tea break she feels like tidying up the place).";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        girlSigh.Play();
        nextButton.SetActive(true);
        eventPos = 10;
    }

    IEnumerator EventTen()
    {
        //three
        nextButton.SetActive(false);
        charLaksmi.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Laksmi";
        textToSpeak = "(She begin to take the paper that was on the floor and was about to crumpled to it)(but to her surprise Tresna’s left hand was already on Laksmi’s wrist.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        girlSigh.Play();
        nextButton.SetActive(true);
        eventPos = 11;
    }

    IEnumerator EventEleven()
    {
        //three
        nextButton.SetActive(false);
        charLaksmi.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Laksmi";
        textToSpeak = "what’s the matter?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        girlWhat.Play();
        nextButton.SetActive(true);
        eventPos = 12;
    }

    IEnumerator EventTweleve()
    {
        //three
        nextButton.SetActive(false);
        charLaksmi.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Tresna";
        textToSpeak = "It may be thrown but it is not a trash to me” “as there may be mistakes on it yet I like to keep them for reminder” “that’s why I never crumpled them.”";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        girlGasp.Play();
        nextButton.SetActive(true);
        eventPos = 13;
    }

    IEnumerator EventThreetin()
    {
        //three
        nextButton.SetActive(false);
        charLaksmi.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Laksmi";
        textToSpeak = "Why? Aren’t you just going to throw them eventually";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        girlSigh.Play();
        nextButton.SetActive(true);
        eventPos = 14;
    }

    IEnumerator EventFourtin()
    {
        //three
        nextButton.SetActive(false);
        charLaksmi.SetActive(true);
        textBox.SetActive(true);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        eventPos = 15;
    }



    public void NextButton()
    {
        if (eventPos == 1)
        {
            StartCoroutine(EventOne());
        }
        if (eventPos == 2)
        {
            StartCoroutine(EventTwo());
        }
        if (eventPos == 3)
        {
            StartCoroutine(EventThree());
        }
        if (eventPos == 4)
        {
            StartCoroutine(EventFour());
        }
        if (eventPos == 5)
        {
            StartCoroutine(EventFive());
        }
        if (eventPos == 6)
        {
            StartCoroutine(EventSix());
        }
        if (eventPos == 7)
        {
            StartCoroutine(EventSeven());
        }
        if (eventPos == 8)
        {
            StartCoroutine(EventEight());
        }
        if (eventPos == 9)
        {
            StartCoroutine(EventNine());
        }
        if (eventPos == 10)
        {
            StartCoroutine(EventTen());
        }
        if (eventPos == 11)
        {
            StartCoroutine(EventEleven());
        }
        if (eventPos == 12)
        {
            StartCoroutine(EventTweleve());
        }
        if (eventPos == 13)
        {
            StartCoroutine(EventThreetin());
        }
        if (eventPos == 14)
        {
            StartCoroutine(EventFourtin());
        }



    }
}


