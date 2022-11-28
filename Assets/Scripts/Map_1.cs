using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Map_1 : MonoBehaviour
{
    public GameObject question1Screen, question2Screen, question3Screen, question4Screen, question5Screen, question6Screen, question7Screen, question8Screen, question9Screen;

    public Text scoreText;

    // For Question 1
    public Text question1Text, choice1AText, choice1BText;

    // For Question 2
    public Text question2Text, choice2AText, choice2BText;

    // For Question 3
    public Text question3Text, choice3AText, choice3BText;

    // For Question 4
    public Text question4Text, choice4AText, choice4BText;

    // For Question 5
    public Text question5Text, choice5AText, choice5BText;

    // For Question 6
    public Text question6Text, choice6AText, choice6BText;

    // For Question 7
    public Text question7Text, choice7AText, choice7BText;

    // For Question 8
    public Text question8Text, choice8AText, choice8BText;

    // For Question 9
    public Text question9Text, choice9AText, choice9BText;

    string language;
    public AudioSource rightSound, wrongSound;

    int score;
    // Start is called before the first frame update
    void Start()
    {
        HideAllScreen();
        language = PlayerPrefs.GetString("playerLanguage");
        LoadLanguageText();
        question1Screen.SetActive(true);

        score = PlayerPrefs.GetInt("playerScore");
        scoreText.text = "Points: "+score;
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
        score++;
        PlayerPrefs.SetInt("playerScore", score);
        scoreText.text = "Points: "+score;
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
        score++;
        PlayerPrefs.SetInt("playerScore", score);
        scoreText.text = "Points: "+score;
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
        score++;
        PlayerPrefs.SetInt("playerScore", score);
        scoreText.text = "Points: "+score;
    }

    //Choices for Question 4
    public void question4Choice1(){
        PlayerPrefs.SetString("questionCorrect", "2");
        HideAllScreen();
        wrongSound.Play();
        question5Screen.SetActive(true);
    }

    public void question4Choice2(){
        PlayerPrefs.SetString("questionCorrect", "1");
        HideAllScreen();
        rightSound.Play();
        question5Screen.SetActive(true);
        score++;
        PlayerPrefs.SetInt("playerScore", score);
        scoreText.text = "Points: "+score;
    }
    
    //Quesetion 5
    public void question5Choice1(){
        PlayerPrefs.SetString("questionCorrect", "2");
        HideAllScreen();
        wrongSound.Play();
        question6Screen.SetActive(true);
    }

    public void question5Choice2(){
        PlayerPrefs.SetString("questionCorrect", "1");
        HideAllScreen();
        rightSound.Play();
        score++;
        PlayerPrefs.SetInt("playerScore", score);
        scoreText.text = "Points: "+score;
        question6Screen.SetActive(true);
    }

    //Question 6
    public void question6Choice1(){
        PlayerPrefs.SetString("questionCorrect", "1");
        HideAllScreen();
        rightSound.Play();
        score++;
        PlayerPrefs.SetInt("playerScore", score);
        scoreText.text = "Points: "+score;
        question7Screen.SetActive(true);

    }

    public void question6Choice2(){
        PlayerPrefs.SetString("questionCorrect", "2");
        HideAllScreen();
        wrongSound.Play();
        question7Screen.SetActive(true);
    }

    //Question 7
    public void question7Choice1(){
        PlayerPrefs.SetString("questionCorrect", "2");
        HideAllScreen();
        wrongSound.Play();
        question8Screen.SetActive(true);
    }

    public void question7Choice2(){
        PlayerPrefs.SetString("questionCorrect", "1");
        HideAllScreen();
        rightSound.Play();
        score++;
        PlayerPrefs.SetInt("playerScore", score);
        scoreText.text = "Points: "+score;
        question8Screen.SetActive(true);
    }

    //Question 8
    public void question8Choice1(){
        PlayerPrefs.SetString("questionCorrect", "2");
        HideAllScreen();
        wrongSound.Play();
        question9Screen.SetActive(true);
    }

    public void question8Choice2(){
        PlayerPrefs.SetString("questionCorrect", "1");
        HideAllScreen();
        rightSound.Play();
        score++;
        PlayerPrefs.SetInt("playerScore", score);
        scoreText.text = "Points: "+score;
        question9Screen.SetActive(true);
    }

    //Question 9
    public void question9Choice1(){
        PlayerPrefs.SetString("questionCorrect", "1");
        // HideAllScreen();
        rightSound.Play();
        score++;
        PlayerPrefs.SetInt("playerScore", score);
        scoreText.text = "Points: "+score;
        // question9Screen.SetActive(true);
    }

    public void question9Choice2(){
        PlayerPrefs.SetString("questionCorrect", "2");
        // HideAllScreen();
        wrongSound.Play();
        // question9Screen.SetActive(true);
    }



    public void HideAllScreen(){
        question1Screen.SetActive(false);
        question2Screen.SetActive(false);
        question3Screen.SetActive(false);
        question4Screen.SetActive(false);
        question5Screen.SetActive(false);
        question6Screen.SetActive(false);
        question7Screen.SetActive(false);
        question8Screen.SetActive(false);
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

            question5Text.text = "You found your father's wallet in his laundry, what will you do?";
            choice5AText.text = "A. Take it and keep it.";
            choice5BText.text = "B. Give it to father.";  

            question6Text.text = "You dropped your mother's expensive plates what are you going to do?";
            choice6AText.text = "A. Admit it and say it wasn't intentional.";
            choice6BText.text = "B. Don't admit it and blame it on other housemates.";    

            question7Text.text = "You are the one assigned to clean your classroom with your classmates but one of your classmates suddenly asked you to go home, what do you do?";
            choice7AText.text = "A. You just go with him so you don't get tired.";
            choice7BText.text = "B. Do it wholeheartedly to be fair to your other classmates.";     

            question8Text.text = "Your father told you to wake him up when its already time, what do you do?";
            choice8AText.text = "A. Don't pay attention to what he says and let it go.";
            choice8BText.text = "B. Wake him up at the time he said because what he will do is important.";    

            question9Text.text = "Your mother asks you to water the plants but you are busy watching TV, what would you do?";
            choice9AText.text = "A. Obey your mother instantly.";
            choice9BText.text = "B. Pretend that you didn't hear anything and continue watching.";                         

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

            question5Text.text = "Nakita mo ang wallet nang ama mo sa knayang labahan na damit, ano ang iyong gagawin?";
            choice5AText.text = "A. Kunin ito at itago nalang.";
            choice5BText.text = "B. Ibigay ito sa ama.";                             

            question6Text.text = "Nahulog mo ang mga mamahaling plato na iyong nanay ano ang iyong gagawin?";
            choice6AText.text = "A. Umamin at sabihing hindi naman ito sinadya.";
            choice6BText.text = "B. Huwag umamin at ibintang ito sa mga ibang kasama mo sa bahay.";  

            question7Text.text = "Ikaw ang inatasan ng maglinis ng inyong silid aralan kasama ang iyong mga kaklasi ngunit, isa sa mga kaklasi mo ay biglang nagyayang umuwi nalang ako ang iyong gagawin?";
            choice7AText.text = "A. Ikaw ay sumama nalang sakanya para hindi mapagod.";
            choice7BText.text = "B. Gawin ito ng buong puso upang maging patas sa iba mong kaklase.";  

            question8Text.text = "Sinabi ng iyong tatay na gisingin siya sa oras na sinabi niya sayo ano ang iyong gagawin?";
            choice8AText.text = "A. Huwag bigyan ng pansin ang kanyang sabihin at hayaan.";
            choice8BText.text = "B. Gisingin siya sa oras na sinabi niya dahil importante ang kanyang gagawin .";  

            question9Text.text = "Inutusan ka ng iyong ina na magdilig ng halaman ngunit ikaw ay nanonood ng telebisyon, ano ang iyong gagawin?";
            choice9AText.text = "A. Gawin agad ang utos.";
            choice9BText.text = "B. Magpanggap na walang narinig at magpatuloy sa panonood.";     

        }        
    }
}
