using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Map_2 : MonoBehaviour
{
    public GameObject question1Screen, question2Screen, question3Screen, question4Screen, question5Screen, question6Screen, question7Screen, question8Screen, question9Screen, question10Screen;

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

    // For Question 10
    public Text question10Text, choice10AText, choice10BText;

    string language;
    public AudioSource rightSound, wrongSound;

    public string whichMap;

    int score;

    //Great Job
    public GameObject wrongAnswerPanel, correctAnswerPanel;
    public Text correctText;
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
        wrongSound.Play();
        question2Screen.SetActive(true);
        PlayerPrefs.SetString("questionCorrect", "2");

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Scold the children because it is trespassing";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Suyawin ang mga bata dahil ito ay trespassing";
        }
        //End Correct and Wrong Panel
    }

    public void question1Choice2(){
        HideAllScreen();
        rightSound.Play();
        question2Screen.SetActive(true);
        PlayerPrefs.SetString("questionCorrect", "1");
        score++;
        PlayerPrefs.SetInt("playerScore", score);
        scoreText.text = "Points: "+score;

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        correctAnswerPanel.SetActive(true);

    }

    //Choices for Question 2
    public void question2Choice1(){
        HideAllScreen();
        wrongSound.Play();
        question3Screen.SetActive(true);
        PlayerPrefs.SetString("questionCorrect", "2");

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Feed it so it doesn't starve";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Pakainin para hindi ito magutom";
        }
        //End Correct and Wrong Panel
    }

    public void question2Choice2(){
        HideAllScreen();
        rightSound.Play();
        question3Screen.SetActive(true);
        PlayerPrefs.SetString("questionCorrect", "1");
        score++;
        PlayerPrefs.SetInt("playerScore", score);
        scoreText.text = "Points: "+score;
        
        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        correctAnswerPanel.SetActive(true);

    }

    //Choices for Question 3
    public void question3Choice1(){
        PlayerPrefs.SetString("questionCorrect", "1");
        HideAllScreen();
        rightSound.Play();
        question4Screen.SetActive(true);
        score++;
        PlayerPrefs.SetInt("playerScore", score);
        scoreText.text = "Points: "+score;

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        correctAnswerPanel.SetActive(true);

    }

    public void question3Choice2(){
        PlayerPrefs.SetString("questionCorrect", "2");
        HideAllScreen();
        wrongSound.Play();
        question4Screen.SetActive(true);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Help and give food";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Tulungan at bigyan nang pagkain";
        }
        //End Correct and Wrong Panel        
    }

    //Choices for Question 4
    public void question4Choice1(){
        PlayerPrefs.SetString("questionCorrect", "2");
        HideAllScreen();
        wrongSound.Play();
        question5Screen.SetActive(true);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Ask your friends to leave as entry is forbidden";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Yayain ang iyong tropa na umalis dahil bawal pumasok.";
        }
        //End Correct and Wrong Panel 

    }

    public void question4Choice2(){
        PlayerPrefs.SetString("questionCorrect", "1");
        HideAllScreen();
        rightSound.Play();
        question5Screen.SetActive(true);
        score++;
        PlayerPrefs.SetInt("playerScore", score);
        scoreText.text = "Points: "+score;

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        correctAnswerPanel.SetActive(true);

    }
    
    //Quesetion 5
    public void question5Choice1(){
        PlayerPrefs.SetString("questionCorrect", "1");
        HideAllScreen();
        rightSound.Play();
        score++;
        PlayerPrefs.SetInt("playerScore", score);
        scoreText.text = "Points: "+score;
        question6Screen.SetActive(true);
        
        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        correctAnswerPanel.SetActive(true);
    }

    public void question5Choice2(){
        PlayerPrefs.SetString("questionCorrect", "2");
        HideAllScreen();
        wrongSound.Play();
        question6Screen.SetActive(true);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Scold them and say it's a type of crime";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Bawalan at sabihin na ito ay isang klasi ng krimen.";
        }
        //End Correct and Wrong Panel 

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

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        correctAnswerPanel.SetActive(true);

    }

    public void question6Choice2(){
        PlayerPrefs.SetString("questionCorrect", "2");
        HideAllScreen();
        wrongSound.Play();
        question7Screen.SetActive(true);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Feed them because they will surely die";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Pakainin ang mga ito dahil pusbiling sila aymamatay.";
        }
        //End Correct and Wrong Panel 

    }

    //Question 7
    public void question7Choice1(){
        PlayerPrefs.SetString("questionCorrect", "2");
        HideAllScreen();
        wrongSound.Play();
        question8Screen.SetActive(true);
        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Clean and place in proper trash";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Linisin at ilagay sa tamang basurahan.";
        }
        //End Correct and Wrong Panel 
    }

    public void question7Choice2(){
        PlayerPrefs.SetString("questionCorrect", "1");
        HideAllScreen();
        rightSound.Play();
        score++;
        PlayerPrefs.SetInt("playerScore", score);
        scoreText.text = "Points: "+score;
        question8Screen.SetActive(true);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        correctAnswerPanel.SetActive(true);

    }

    //Question 8
    public void question8Choice1(){
        PlayerPrefs.SetString("questionCorrect", "1");
        HideAllScreen();
        rightSound.Play();
        score++;
        PlayerPrefs.SetInt("playerScore", score);
        scoreText.text = "Points: "+score;
        question9Screen.SetActive(true);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        correctAnswerPanel.SetActive(true);
    }

    public void question8Choice2(){
        PlayerPrefs.SetString("questionCorrect", "2");
        HideAllScreen();
        wrongSound.Play();
        question9Screen.SetActive(true);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Wake him up at the time he said because what he will do is important";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Tumawag sa iyong kapitbahay at sabihin ito.";
        }
        //End Correct and Wrong Panel 
    }

    //Question 9
    public void question9Choice1(){
        PlayerPrefs.SetString("questionCorrect", "1");
        HideAllScreen();
        rightSound.Play();
        score++;
        PlayerPrefs.SetInt("playerScore", score);
        scoreText.text = "Points: "+score;
        question10Screen.SetActive(true);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        correctAnswerPanel.SetActive(true);
    }

    public void question9Choice2(){
        PlayerPrefs.SetString("questionCorrect", "2");
        HideAllScreen();
        wrongSound.Play();
        question10Screen.SetActive(true);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Give him the change before he leaves";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Ibigay sakanya ang sukli habang hindi pa siya nakakaalis.";
        }
        //End Correct and Wrong Panel 

    }

    //Question 10
    public void question10Choice1(){
        PlayerPrefs.SetString("questionCorrect", "2");
        wrongSound.Play();
        SceneManager.LoadScene(whichMap);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Read and review to get high marks";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Magbasa at magrebyu upang makakuha ng mataas ng marka.";
        }
        //End Correct and Wrong Panel 

    }

    public void question10Choice2(){
        PlayerPrefs.SetString("questionCorrect", "1");
        rightSound.Play();
        score++;
        PlayerPrefs.SetInt("playerScore", score);
        scoreText.text = "Points: "+score;
        SceneManager.LoadScene(whichMap);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        correctAnswerPanel.SetActive(true);

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
        question9Screen.SetActive(false);
        question10Screen.SetActive(false);
    }

    //Load Language Text
    public void LoadLanguageText(){
        if(language == "english"){
            question1Text.text = "You saw children’s taking your neighbor's guavas without saying goodbye, what should you do?";
            choice1AText.text = "A. Ask for their extracted guava.";
            choice1BText.text = "B. Scold the children because it is trespassing.";

            question2Text.text = "Your mother ordered you to feed your guard dog immediately because you will be home at night, what will you do?";
            choice2AText.text = "A. Will not do.";
            choice2BText.text = "B. Feed it so it doesn't starve.";

            question3Text.text = "You went to the forest with your family to go camping but you saw an old man who was hungry and needed help what would you do?";
            choice3AText.text = "A. Help and give food.";
            choice3BText.text = "B. Let it be.";            

            question4Text.text = "Your friends invite you to pick fruit from your neighbor's empty lot but there is a warning that you are not allowed to enter what do you do?";
            choice4AText.text = "A. Enter the lot even after seeing the warning.";
            choice4BText.text = "B. Ask your friends to leave as entry is forbidden.";           

            question5Text.text = "You see the children writing on your neighbor's wall what is good to do?";
            choice5AText.text = "A. Scold them and say it's a type of crime.";
            choice5BText.text = "B. Let them go because the house they are writing about is not yours.";  

            question6Text.text = "You notice your pet pigs haven't eaten yet what are you going to do?";
            choice6AText.text = "A. Feed them because they will surely die.";
            choice6BText.text = "B. Leave them alone because it was not ordered to you.";    

            question7Text.text = "You see your yard is dirty and full of trash, what are you going to do?";
            choice7AText.text = "A. Let it get dirty.";
            choice7BText.text = "B. Clean and place in proper trash.";     

            question8Text.text = "Your father told you to wake him up when its already time, what do you do?";
            choice8AText.text = "A. Don't pay attention to what he says and let it go.";
            choice8BText.text = "B. Wake him up at the time he said because what he will do is important.";    

            question9Text.text = "You ordered from food panda but the change given by the delivery boy is too much what are you going to do?";
            choice9AText.text = "A. Give him the change before he leaves.";
            choice9BText.text = "B. Don't say it and let him leave so that the change goes to you.";          

            question10Text.text = "You remember that you have an exam in your school but you are already in bed and ready to sleep what are you going to do?";
            choice10AText.text = "A. Just sleep and hope to copy tomorrow.";
            choice10BText.text = "B. Read and review to get high marks.";          


        }
        else{
            question1Text.text = "May nakita kang mga bata na kumukuha ng bayabas ng inyong kapitbahay na walang paalam, ano ang dapat mong gawin?";
            choice1AText.text = "A. Manghingi ng kanilang nakuhang bayabas.";
            choice1BText.text = "B. Suyawin ang mga bata dahil ito ay trespassing.";

            question2Text.text = "Binilin ng iyong ina na pakainin agad ang inyong bantay na aso dahil ikaw ay gagabihin sa iyong lakad ano ang iyong gagawin?";
            choice2AText.text = "A. Ipag paliban";
            choice2BText.text = "B. Pakainin para hindi ito magutom";

            question3Text.text = "Nag punta kayo sa gubat ng iyong pamilya para mag camping subalit may nakita kayong matanda na nagugutom at nangangailangan nang tulong ano ang iyong gagawin?";
            choice3AText.text = "A. Tulungan at bigyan nang pagkain";
            choice3BText.text = "B. Hayaan nalang";     

            question4Text.text = "Niyayaya ka ng iyong tropa na kumuha ng prutas sa bakanting lote ng inyong kapit bahay ngunit may nakalagay na babala na bawal pumasok ano ang iyong gagawin?";
            choice4AText.text = "A. Pumasok parin sa lote kahit nakita na ang babala.";
            choice4BText.text = "B. Yayain ang iyong tropa na umalis dahil bawal pumasok.";     

            question5Text.text = "Nakita mo ang mga bata na nagsusulat sa pader ng iyong kapitbahay ano ang magadang gawin?";
            choice5AText.text = "A. Bawalan at sabihin na ito ay isang klasi ng krimen.";
            choice5BText.text = "B. Hayaan sila dahil hindi naman sainyo ang bahay na sinusulatan.";                             

            question6Text.text = "Napansin mo ang inyong mga alagang baboy na hindi pa kumakain ano ang iyong gagawin?";
            choice6AText.text = "A. Pakainin ang mga ito dahil pusbiling sila aymamatay.";
            choice6BText.text = "B. Pabayaan sila dahil hindi naman ito inutos sayo.";  

            question7Text.text = "Nakita mo ang inyong bakuran na marumi at maraming basura, ano ang iyong gagawin?";
            choice7AText.text = "A. Hayaan nalang na marumi ito.";
            choice7BText.text = "B. Linisin at ilagay sa tamang basurahan.";  

            question8Text.text = "Napansin mo na ang faucet ng inyong kapit bahay sa labas ay bukas ano ang nararapat mong gawin?";
            choice8AText.text = "A. Tumawag sa iyong kapitbahay at sabihin ito .";
            choice8BText.text = "B. Huwag itong sabihin at hayaang umapaw ang tubig sa kanilang harapan.";  

            question9Text.text = "Umalis ang iyong ina para mamili ng makakain at ikaw ay pinagbilinan na maglinis ng bahay ngunit ikaw ay nakatulog at hindi nagawa ang pinagagawa ng iyong ina. Pagkauwi ng iyong ina ay hindi pa rin malinis ang bahay , ano ang iyong sasabihin??";
            choice9AText.text = "A. Ibigay sakanya ang sukli habang hindi pa siya nakakaalis.";
            choice9BText.text = "B. Huwag itong sabihin at hayaan nalang umalis upang sayo nalang mapunta ang sukli.";


            question10Text.text = "Naalala mong magkakaroon pala kayo ng pagsusulit sa inyong paaralan ngunit ikaw ay nakahiga na at handa ng matulog ano ang iyong gagawin?";
            choice10AText.text = "A. Matulog nalang at umasang makakopya bukas.";
            choice10BText.text = "B. Magbasa at magrebyu upang makakuha ng mataas ng marka.";     

 
        }        
    }

    //Hide Great and Sorry Panel
    public void HideCorrectAndSorryPanel()
    {
        wrongAnswerPanel.SetActive(false);
        correctAnswerPanel.SetActive(false);
    }
}
