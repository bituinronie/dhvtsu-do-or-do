using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Map_5 : MonoBehaviour
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

    public void question1Choice2(){
        HideAllScreen();
        wrongSound.Play();
        question2Screen.SetActive(true);
        PlayerPrefs.SetString("questionCorrect", "2");

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Tell him to hide the cheat code or he will be caught";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Pagsabihan ito na itago ang kodigo kung hindi siya ay mahuhuli.";
        }
        //End Correct and Wrong Panel
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
            correctText.text = _concat+"Form your own group and tell your classmates that their point of view is incorrect";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Gumawa ng sarili niyong grupo at pagsabihan ang mga kaklase mo na hindi tama ang kanilang pananaw";
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
        PlayerPrefs.SetString("questionCorrect", "2");
        HideAllScreen();
        wrongSound.Play();
        question4Screen.SetActive(true);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Help and accompany your friend to the bathroom so that it is not embarrassing";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Tulungan at samahan ang iyong kaibigan sa banyo upang ito ay hindi mapahiya";
        }
        //End Correct and Wrong Panel     
    }

    public void question3Choice2(){
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
            correctText.text = _concat+"Say it your parents so it can fix it right away";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Sabihan ang magulang para maayos agad.";
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
            correctText.text = _concat+"Scold and tell the teacher.";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Bawalan at sabihin sa guro.";
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
            correctText.text = _concat+"Forbid them and tell them to silence";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Bawalan at patahimikin.";
        }
        //End Correct and Wrong Panel 

    }

    //Question 7
    public void question7Choice1(){
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

    public void question7Choice2(){
        PlayerPrefs.SetString("questionCorrect", "2");
        HideAllScreen();
        wrongSound.Play();
        question8Screen.SetActive(true);
        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Take it and give it to the owner.";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Kunin at ibigay sa may ari.";
        }
        //End Correct and Wrong Panel 
    }

    //Question 8
    public void question8Choice1(){
        PlayerPrefs.SetString("questionCorrect", "2");
        HideAllScreen();
        wrongSound.Play();
        question9Screen.SetActive(true);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Be honest and don't imitate";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Maging tapat at wag gumaya.";
        }
        //End Correct and Wrong Panel         
    }

    public void question8Choice2(){
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
            correctText.text = _concat+"Forbid him and tell him to put it back";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Bawalan ang kaklase at ipabalik ang kinuha.";
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
        // here is the code
        PlayerPrefs.SetString("questionCorrect", "2");
        wrongSound.Play();
        SceneManager.LoadScene(whichMap);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Knock before entering";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Kumatok bago pumasok.";
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
            question1Text.text = "You caught your classmate having a cheat code while you were having an exam. What would you do?";
            choice1AText.text = "A. Tell him to hide the cheat code or he will be caught.";
            choice1BText.text = "B. Let your classmate and copy him.";

            question2Text.text = "One of your classmates was not included in your group because he or she has brown skin. What should you do?";
            choice2AText.text = "A. Ignore what happened so you don't get kicked out of the group.";
            choice2BText.text = "B. Form your own group and tell your classmates that their point of view is incorrect.";

            question3Text.text = "Your friend pooped in class; how would you react?";
            choice3AText.text = "A. Laugh out loud because of what happened.";
            choice3BText.text = "B. Help and accompany your friend to the bathroom so that it is not embarrassing.";            

            question4Text.text = "The teacher summons your parents because you have committed a sin at school. What will you do?";
            choice4AText.text = "A. Don't tell the parents.";
            choice4BText.text = "B. Say it your parents so it can fix it right away.";           

            question5Text.text = "On the day of your exam, you notice your classmate copying others' answers; what will you do?";
            choice5AText.text = "A. Scold and tell the teacher.";
            choice5BText.text = "B. Leave it alone and imitate it.";  

            question6Text.text = "You are in the classroom, and you hear your classmate making noise. What are you going to do?";
            choice6AText.text = "A. Forbid them and tell them to silence.";
            choice6BText.text = "B. Let them and imitate.";    

            question7Text.text = "You are walking to school and you see a fallen purse. What will you do?";
            choice7AText.text = "A. Take it and give it to the owner.";
            choice7BText.text = "B. Pick it up and continue walking.";

            question8Text.text = "Your teacher has given an exam, and you are not prepared and did not study. What will you do?";
            choice8AText.text = "A. Copy carelessly.";
            choice8BText.text = "B. Be honest and don't imitate.";    

            question9Text.text = "You were in the computer lab when you saw your classmate hiding the mouse. What would you do?";
            choice9AText.text = "A. Forbid him and tell him to put it back.";
            choice9BText.text = "B. Let it go and imitate it.";          

            question10Text.text = "Your teacher told you to take his stuff from the teacher's room. What will you do?";
            choice10AText.text = "A. Knock before entering.";
            choice10BText.text = "B. Enter without knocking.";          


        }
        else{
            question1Text.text = "Nahuli mo ang iyong kaklase na may hawak na kodigo habang kayo ay nagsusulit, ano ang iyong gagawin?";
            choice1AText.text = "A. Pagsabihan ito na itago ang kodigo kung hindi siya ay mahuhuli.";
            choice1BText.text = "B. Hayaan ang iyong kaklase at kumopya sa kanya.";

            question2Text.text = "Hindi sinali sa inyong grupo ang isa mong kaklase dahil ito ay maitim, ano ang nararapat mong gawin?";
            choice2AText.text = "A. Ipagwalang bahala ang nangyari upang hindi ka matanggal sa grupo SIS.";
            choice2BText.text = "B. Gumawa ng sarili niyong grupo at pagsabihan ang mga kaklase mo na hindi tama ang kanilang pananaw.";

            question3Text.text = "Natae sa klase ang iyong kaibigan, ano ang magiging reaksyon mo?";
            choice3AText.text = "A. Tatawa ng malakas dahil sa nangyari.";
            choice3BText.text = "B. Tulungan at samahan ang iyong kaibigan sa banyo upang ito ay hindi mapahiya.";     

            question4Text.text = "Pinatatawag ng guro ang iyong magulang dahil ikaw ay gumawa ng kasalanan sa skwelahan, ano ang gagawin mo?";
            choice4AText.text = "A. Huwag sabihin sa magulang.";
            choice4BText.text = "B. Sabihan ang magulang para maayos agad.";     

            question5Text.text = "Araw nang inyong pagsusulit at napansin mo ang iyong kaklase na nangongopya, ano ang iyong gagawin?";
            choice5AText.text = "A. Bawalan at sabihin sa guro.";
            choice5BText.text = "B. Pabayaan na lang at gayahin.";                             

            question6Text.text = "Nasa silid kayo nang paaralan at naririnig mo ang iyong kaklase na maingay, ano ang iyong gagawin?";
            choice6AText.text = "A. Bawalan at patahimikin.";
            choice6BText.text = "B. Hayaan at gayahin.";  

            question7Text.text = "Naglalakad ka sa skwela at may nakita kang nahulog na pitaka, ano ang iyong gagawin?";
            choice7AText.text = "A. Kunin at ibigay sa may ari.";
            choice7BText.text = "B. Kunin at tumuloy sa lakad.";    

            question8Text.text = "Nagbigay nang pagsusulit ang inyong guro at ikaw ay hindi handa at hind nakapagaral, ano ang iyong gagawin?";
            choice8AText.text = "A. Kumopya nang walang bahala.";
            choice8BText.text = "B. Maging tapat at wag gumaya.";  

            question9Text.text = "Nasa computer lab kayo nang kaklase mo at nakita mo siya na tinatago ang mouse, ano ang iyong gagawin?";
            choice9AText.text = "A. Bawalan ang kaklase at ipabalik ang kinuha.";
            choice9BText.text = "B. Hayaan at gayahin na lang.";


            question10Text.text = "Inutusan ka ng iyong guro na kunin ang kanyang gamit sa silid ng mga guro, ano ang iyong gagawin?";
            choice10AText.text = "A. Kumatok bago pumasok.";
            choice10BText.text = "B. Pumasok ng basta basta."; 
        }        
    }

    //Hide Great and Sorry Panel
    public void HideCorrectAndSorryPanel()
    {
        wrongAnswerPanel.SetActive(false);
        correctAnswerPanel.SetActive(false);
    }
}
