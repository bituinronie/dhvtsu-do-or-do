using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Map_1 : MonoBehaviour
{
    public GameObject question1Screen, question2Screen, question3Screen, question4Screen;
    // For Question 1
    public Text question1Text, choice1AText, choice1BText;

    // For Question 2
    public Text question2Text, choice2AText, choice2BText;

    // For Question 3
    public Text question3Text, choice3AText, choice3BText;

    // For Question 4
    public Text question4Text, choice4AText, choice4BText;

    string language;
    public AudioSource rightSound, wrongSound;
    // Start is called before the first frame update
    void Start()
    {
        HideAllScreen();
        language = PlayerPrefs.GetString("playerLanguage");
        LoadLanguageText();
        question1Screen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        LoadLanguageText();
    }

    //Choices for Question 1
    public void question1Choice1(){
        HideAllScreen();
        rightSound.Play();
        question2Screen.SetActive(true);
        PlayerPrefs.SetString("questionCorrect", "1");
    }

    public void question1Choice2(){
        HideAllScreen();
        wrongSound.Play();
        question2Screen.SetActive(true);
        PlayerPrefs.SetString("questionCorrect", "2");
    }

    //Choices for Question 2
    public void question2Choice1(){
        HideAllScreen();
        rightSound.Play();
        question3Screen.SetActive(true);
        PlayerPrefs.SetString("questionCorrect", "1");
    }

    public void question2Choice2(){
        HideAllScreen();
        wrongSound.Play();
        question3Screen.SetActive(true);
        PlayerPrefs.SetString("questionCorrect", "2");
    }

    //Choices for Question 3
    public void question3Choice1(){
        PlayerPrefs.SetString("questionCorrect", "2");
        HideAllScreen();
        wrongSound.Play();
        question4Screen.SetActive(true);
    }

    public void question3Choice2(){
        PlayerPrefs.SetString("questionCorrect", "1");
        HideAllScreen();
        rightSound.Play();
        question4Screen.SetActive(true);
    }

    //Choices for Question 4
    public void question4Choice1(){
        PlayerPrefs.SetString("questionCorrect", "2");
        // HideAllScreen();
        wrongSound.Play();
        // question4Screen.SetActive(true);
    }

    public void question4Choice2(){
        PlayerPrefs.SetString("questionCorrect", "1");
        // HideAllScreen();
        rightSound.Play();
        // question4Screen.SetActive(true);
    }

    public void HideAllScreen(){
        question1Screen.SetActive(false);
        question2Screen.SetActive(false);
        question3Screen.SetActive(false);
        question4Screen.SetActive(false);
    }

    //Load Language Text
    public void LoadLanguageText(){
        if(language == "english"){
            question1Text.text = "Your mother asked you to sweep the yard, what would you do?";
            choice1AText.text = "A. Do the work wholeheartedly.";
            choice1BText.text = "B. You will grumble and not sweep the yard.";

            question2Text.text = "You saw money inside the pocket of your father's dirty shorts, what would you do?";
            choice2AText.text = "A. Get the money and bring it back to your father.";
            choice2BText.text = "B. Keep the money and buy something you want.";

            question3Text.text = "Your father comes home from work and he asks you to make a coffee for him, what would you do?";
            choice3AText.text = "A. Pretend you didn't hear anything.";
            choice3BText.text = "B. You will make a coffee.";            

            question4Text.text = "Your mother is busy doing the house chores while you are busy playing on your phone, she asked you to buy seasonings. What do you think is the right response?";
            choice4AText.text = "A. You will grumble because you are busy playing on your phone.";
            choice4BText.text = "B. You will leave for a while your game and obey your mother.";            


        }
        else{
            question1Text.text = "Inutusan ka ng iyong Ina na magwalis sa bakuran, ano ang iyong gagawin?";
            choice1AText.text = "A. Susunod ng buong puso";
            choice1BText.text = "B. Magmamaktol at hindi magwawalis";

            question2Text.text = "Nakita mo ang maduming salawal ng iyong Ama na may pera, ano ang iyong gagawin?";
            choice2AText.text = "A. Kukunin ang pera at ibibigay sa Ama";
            choice2BText.text = "B. Itatago ang pera at ipambibili";

            question3Text.text = "Umuwi ang iyong Ama galing trabaho at ikaw ay inutusan na mag timpla ng kape, ano ang iyong gagawin?";
            choice3AText.text = "A. Magpanggap na walang naririnig";
            choice3BText.text = "B. Magtitimpla ng kape";     

            question4Text.text = "Abalang gumagawa ng gawaing bahay ang iyong ina habang ikaw ay naglalaro sa iyong cellphone (PA-ITALIC PO ANG CELLPHONE. Tinawag ka niya upang bumili ng mga sangkap para sa kaniyang lulutuing tanghalian. Ano sa tingin mo ang wastong tugon?";
            choice4AText.text = "A. Magdabog dahil ikaw ay abala sa iyong laro.";
            choice4BText.text = "B. Iwan muna ang laro at sumunod sa utos ng iyong ina.";                 

        }        
    }
}
