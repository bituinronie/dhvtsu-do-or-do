using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Map_3 : MonoBehaviour
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

    public GameObject bg1, bg2, bg3;

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
            correctText.text = _concat+"Pray and listen to the priest's sermon.";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Magdasal at makinig sa sermon ng pari";
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
        HideBG();
        bg2.SetActive(true);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Reprimanding after mass to never do it again.";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Pagsabihan pagkatapos ng misa para hindi na ito gawin kailan man.";
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
        HideBG();
        bg2.SetActive(true);

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
        HideBG();
        bg3.SetActive(true);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        correctAnswerPanel.SetActive(true);

    }

    public void question3Choice2(){
        PlayerPrefs.SetString("questionCorrect", "2");
        HideAllScreen();
        wrongSound.Play();
        question4Screen.SetActive(true);
        HideBG();
        bg3.SetActive(true);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Set-aside your agenda and attend the Sunday service.";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Babalewalain ang matanda na nakatayo at uupo nang tuluyan.";
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
            correctText.text = _concat+"Give your seat to the old man.";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Tatayo at pauupuin ang matanda.";
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
            correctText.text = _concat+"Hand over the fare to the driver.";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Aabot ang pamasahe sa driver.";
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
            correctText.text = _concat+"You will give the beggar a food.";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Bibigyan nang pagkain.";
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
            correctText.text = _concat+"Stop walking and help the old man.";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Hihinto sa paglalakad at tutulungin ang matanda.";
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
            correctText.text = _concat+"Cross the right crosswalk.";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Tumawid sa tamang tawiran.";
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
            correctText.text = _concat+"Help it to cross safely.";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Tulungan ito para makatawid ng ligtas.";
        }
        //End Correct and Wrong Panel

    }

    //Question 10
    public void question10Choice1(){
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

    public void question10Choice2(){
        PlayerPrefs.SetString("questionCorrect", "2");
        wrongSound.Play();
        SceneManager.LoadScene(whichMap);

       //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Wake up the passenger so he doesn't get too far from his destination.";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Gisingin ang pasahero para hindi na mapalayo sa kanyang pupuntahan.";
        }
        //End Correct and Wrong Panel

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
            question1Text.text = "You are inside the church, what are you going to do?";
            choice1AText.text = "A. Make noise and chat with friends.";
            choice1BText.text = "B. Pray and listen to the priest's sermon.";

            question2Text.text = "You saw your friends not singing the song offered to God correctly, what will you do?";
            choice2AText.text = "A. Copy it because it looks fun.";
            choice2BText.text = "B. Reprimanding after mass to never do it again.";

            question3Text.text = "You know that every Sunday you and your family go to church, unfortunately you have another agenda on that day. What will you do?";
            choice3AText.text = "A. Set-aside your agenda and attend the Sunday service.";
            choice3BText.text = "B. You will continue to your agenda and will not attend church";            

            question4Text.text = "You are sitting in a waiting shed while waiting for public transport, there is an old man also waiting and standing besides you, what will you going to do?";
            choice4AText.text = "A. Ignore the old man who is standing and just sit down.";
            choice4BText.text = "B. Give your seat to the old man.";           

            question5Text.text = "You are riding in a public transportation on your way home from school while resting, someone is handing out their fare to the driver, what are you going to do?";
            choice5AText.text = "A. Hand over the fare to the driver.";
            choice5BText.text = "B. Pretend you did not to hear anything and lean back.";  

            question6Text.text = "While walking you meet a beggar who wants to ask you for food, what will you do?";
            choice6AText.text = "A. You will give the beggar a food.";
            choice6BText.text = "B. Ignore and just pass by.";    

            question7Text.text = "You are walking down the street with your friends and you see an old man walking and his groceries has spilled, what will you do?";
            choice7AText.text = "A. Ignore what was seen and walk with friends.";
            choice7BText.text = "B. Stop walking and help the old man.";     

            question8Text.text = "You are on your way home from school and you are about to cross the other road but there are many cars passing by, what will you do?";
            choice8AText.text = "A. Cross the right crosswalk.";
            choice8BText.text = "B. Cross casually.";    

            question9Text.text = "You see an old man and a child on the road going to school to drop off the child but the cars don't stop, what can be done?";
            choice9AText.text = "A. Help it to cross safely.";
            choice9BText.text = "B. Let it go because you are in a hurry to go home.";          

            question10Text.text = "You hear a passenger where he needs to come down but he fell asleep and you hear that your public transportation has arrived at his destination, what is the best thing to do?";
            choice10AText.text = "A. Wake up the passenger so he doesn't get too far from his destination.";
            choice10BText.text = "B. Just let the passenger pass to his destination and don't wake him up.";          


        }
        else{
            question1Text.text = "Ikaw ay nasa loob ng simbahan, ano ang iyong gagawin?";
            choice1AText.text = "A. Mag-iingay at makikipagkwentuhan sa katabi.";
            choice1BText.text = "B. Magdasal at makinig sa sermon ng pari.";

            question2Text.text = "Nakikita mo ang iyong mga kaibigan na hindi kinakantang tama ang kantang hinahandog sa Diyos ano ang iyong gagawin?";
            choice2AText.text = "A. Gayahin ito dahil ito ay mukhang masaya";
            choice2BText.text = "B. Pagsabihan pagkatapos ng misa para hindi na ito gawin kailan man";

            question3Text.text = "Araw ng linggo at alam mong kayo ay nagsisimba kasama ng iyong pamilya, ngunit naalala mong may ibang lakad ka pala na pupuntahan, ano ang iyong gagawin?";
            choice3AText.text = "A. Isasantabi muna ang lakad at sasama sa pagsimba";
            choice3BText.text = "B. Pupunta sa lakad at hindi magsisimba";     

            question4Text.text = "Ikaw ay nakaupo sa isang waiting shed at naghihintay ng pampublikong sasakyan, may isang matanda na naghihintay din at nakatayo, ano ang iyong gagawin?";
            choice4AText.text = "A. Babalewalain ang matanda na nakatayo at uupo nang tuluyan.";
            choice4BText.text = "B. Tatayo at pauupuin ang matanda.";     

            question5Text.text = "Ikaw ay nakasakay sa isang pampublikong sasakyan habang ikaw ay nakasandal pagod galing eskwela at may nagpapaabot ng pamasahe sa driver, ano ang iyong gagawin?";
            choice5AText.text = "A. Aabot ang pamasahe sa driver.";
            choice5BText.text = "B. Magpapanggap ng walang narinig at sasandal nalang.";                             

            question6Text.text = "Habang naglalakad mayroon kang nakasalubong na pulubi at gustong humingi sa iyo ng pakain, ano ang iyong gagawin? ?";
            choice6AText.text = "A. Bibigyan nang pagkain.";
            choice6BText.text = "B. Babalewalain at dadaanan lang.";  

            question7Text.text = "Ikaw ay naglalakad sa daan kasama ang iyong mga kaibigan at may nakita kang isang matanda na naglalakad at nahulog ang kanyang mga pinamiling gamit, ano ang iyong gagawin?";
            choice7AText.text = "A. Babalewalain ang nakita at sasabay sa paglalakad ng mga kaibigan.";
            choice7BText.text = "B. Hihinto sa paglalakad at tutulungin ang matanda.";  

            question8Text.text = "Ikaw ay nasa daan pauwi galing paaralan at tatawid sa kabilang daanan ngunit maraming sasakyan ang dumadaan, ano ang iyong gagawin?";
            choice8AText.text = "A. Tumawid sa tamang tawiran.";
            choice8BText.text = "B. Tumawid ng basta-basta.";  

            question9Text.text = "May nakita kang matanda at bata sa kalsada papunta sa skwelahan para ihatid ang bata ngunit walang hinto ang mga sasakyan, ano ang pweding gawin?";
            choice9AText.text = "A. Tulungan ito para makatawid ng ligtas.";
            choice9BText.text = "B. Hayaan nalang ito dahil nagmamadali ka papuntang bahay.";


            question10Text.text = "Narinig mo ang isang pasahero kung saan siya ay baba ngunit siya ay nakatulog at narinig mona na nakarating na ang inyong sasakyan sa kanyang destinasyon ano ang maganda gawin?";
            choice10AText.text = "A. Gisingin ang pasahero para hindi na mapalayo sa kanyang pupuntahan.";
            choice10BText.text = "B. Hayaan nalang na lumagpas ang pasahero at wag nang gisingin.";     

 
        }        
    }


    //hide all bg
    public void HideBG(){
        bg1.SetActive(false);
        bg2.SetActive(false);
        bg3.SetActive(false);
    }

    //Hide Great and Sorry Panel
    public void HideCorrectAndSorryPanel()
    {
        wrongAnswerPanel.SetActive(false);
        correctAnswerPanel.SetActive(false);
    }
}
