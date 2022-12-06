using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Map_6 : MonoBehaviour
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
            correctText.text = _concat+"Step in and settle the fight.";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Umawat at ayusin.";
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
            correctText.text = _concat+"Defend it and scold them";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Ipagtanggol ito at bawalan sila";
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
            correctText.text = _concat+"Scold them and report to the teacher";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Bawalan at isumbong sa guro";
        }
        //End Correct and Wrong Panel             
    }

    //Choices for Question 4
    public void question4Choice1(){
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

    public void question4Choice2(){
        PlayerPrefs.SetString("questionCorrect", "2");
        HideAllScreen();
        wrongSound.Play();
        question5Screen.SetActive(true);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Report it to the teachers";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Isumbong ito sa mga guro.";
        }
        //End Correct and Wrong Panel 
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
            correctText.text = _concat+"Report it to your teacher so it can be resolved.";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Isumbong mo ito sa iyong guro upang masolusyunan.";
        }
        //End Correct and Wrong Panel 

    }

    //Question 6
    public void question6Choice1(){
        PlayerPrefs.SetString("questionCorrect", "2");
        HideAllScreen();
        wrongSound.Play();
        question7Screen.SetActive(true);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Tell your friend not to eat it because it has already been shaken and tell the person who gave it not to do it again";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Sabihan mo ang iyong kaibigan na wag itong kainin dahil nahulog na at sabihan ang nagbigay na wag niya ng ulitin.";
        }
        //End Correct and Wrong Panel 
    }

    public void question6Choice2(){
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
            correctText.text = _concat+"Report to the principal because what they are doing is wrong.";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Sumbong sa principal dahil mali ang kanilang ginagawa .";
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
        PlayerPrefs.SetString("questionCorrect", "2");
        HideAllScreen();
        wrongSound.Play();
        question9Screen.SetActive(true);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Just study hard and remember cheating is wrong";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Mag-aral na lamang ng mabuti.";
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
            correctText.text = _concat+"Tell the truth and admit you were wrong";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Sabihin ang totoo at aminin na mali mo ito.";
        }
        //End Correct and Wrong Panel 

    }

    //Question 10
    public void question10Choice1(){
        // here is the code
        PlayerPrefs.SetString("questionCorrect", "2");
        wrongSound.Play();
        SceneManager.LoadScene(whichMap);

        //Hide Correct and Wrong Panel
        HideCorrectAndSorryPanel();
        wrongAnswerPanel.SetActive(true);
        
        if(language == "english"){
            string _concat = "The correct answer is ";
            correctText.text = _concat+"Ask whose it is because it might be the owner last ballpen that has been misplaced";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Magtanong kung kanino ito dahil baka yun ang huling ballpen ng nahulugan.";
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
            question1Text.text = "You are at school with your friends when someone suddenly gets into a fight. What are you going to do?";
            choice1AText.text = "A. Get into trouble also.";
            choice1BText.text = "B. Step in and settle the fight.";

            question2Text.text = "You see your classmate being teased and hurting him, what should you do?";
            choice2AText.text = "A. Get involved in teasing classmates and embarrass him.";
            choice2BText.text = "B. Defend it and scold them.";

            question3Text.text = "You are inside the school room, and a classmate is throwing paper. What should be done?";
            choice3AText.text = "A. Let go and throw paper too.";
            choice3BText.text = "B. Scold them and report to the teacher.";            

            question4Text.text = "You see a student asking his classmates for money, and he hurts them if they don't give it to him. What will you do?";
            choice4AText.text = "A. Report it to the teachers.";
            choice4BText.text = "B. Just let it go and be passive.";           

            question5Text.text = "You see your classmates bullying your colleague. What should you do?";
            choice5AText.text = "A. Report it to your teacher so it can be resolved.";
            choice5BText.text = "B. Make a revenge on your classmates.";  

            question6Text.text = "Your classmate gives something to your friend, but he doesn't know that it has fallen on the ground. What is your solution so that he doesn't end up eating it?";
            choice6AText.text = "A. Let him eat it because it's funny.";
            choice6BText.text = "B. Tell your friend not to eat it because it has already been shaken and tell the person who gave it not to do it again.";    

            question7Text.text = "You notice that your classmates are booing in the girls' restroom. What should you do?";
            choice7AText.text = "A. Imitate and accompany them peep.";
            choice7BText.text = "B. Report to the principal because what they are doing is wrong.";

            question8Text.text = "You found out that your classmates got a cheat code on your math test; what will you do?";
            choice8AText.text = "A. Get the code to get high score.";
            choice8BText.text = "B. Just study hard and remember cheating is wrong.";    

            question9Text.text = "You were caught in traffic on the highway, and you arrived late to your classroom. When the teacher asked you what caused you to be late, what would you say?";
            choice9AText.text = "A. You make excuses so that you will not mark late.";
            choice9BText.text = "B. Tell the truth and admit you were wrong.";          

            question10Text.text = "You found a ballpoint pen under your desk chair; what will you do?";
            choice10AText.text = "A. Ask whose it is because it might be the owner last ballpen that has been misplaced.";
            choice10BText.text = "B. Hide it because it's a waste.";          


        }
        else{
            question1Text.text = "Ikaw ay nasa eskwela kasama mo ang iyong mga tropa nang biglang may nag away, ano ang iyong gagawin?";
            choice1AText.text = "A. Sumali sa gulo .";
            choice1BText.text = "B. Umawat at ayusin .";

            question2Text.text = "Nakita mo ang kaklase mo na inaasar o inaaway siya at sinasaktan, ano ang dapat mong gawin?";
            choice2AText.text = "A. Sumali sa pang-aasar sa kaklase at ipahiya.";
            choice2BText.text = "B. Ipagtanggol ito at bawalan sila.";

            question3Text.text = "Nasa loob kayo ng silid paaralan at may isa kang kaklase na nambabato ng papel, ano ang dapat gawin?";
            choice3AText.text = "A. Pabayaan at mambato rin ng papel.";
            choice3BText.text = "B. Bawalan at isumbong sa guro.";     

            question4Text.text = "May nakita kang estudyante na humihingi ng pera sa mga kaklase niya at sinasaktan niya ang mga ito pag hindi binibigyan, ano ang iyong gagawin?";
            choice4AText.text = "A. Isumbong ito sa mga guro.";
            choice4BText.text = "B. Pabayaan na lang at mag walang kibo.";     

            question5Text.text = "Nakita mo ang iyong mga kaklase na binubully ang iyong kasamahan, ano ang marapt mong gawin?";
            choice5AText.text = "A. Isumbong mo ito sa iyong guro upang masolusyunan.";
            choice5BText.text = "B. Gantihan ang iyong mga kaklase .";                             

            question6Text.text = "May binigay ang kaklase mo sa kaibigan mo ngunit hindi niya alam na nahulog na ito sa lupa, ano ang iyong solusyon para hindi niya ito tuluyang kainin?";
            choice6AText.text = "A. Hayaan mong kainin niya ito dahil nakakatawa.";
            choice6BText.text = "B. Sabihan mo ang iyong kaibigan na wag itong kainin dahil nahulog na at sabihan ang nagbigay na wag niya ng ulitin.";  

            question7Text.text = "Napansin mo na ang iyong mga kaklase ay namboboso sa palikuran ng mga babae, ano ang nararapat na gawin?";
            choice7AText.text = "A. Tularan at samahan silang mamboso.";
            choice7BText.text = "B. Sumbong sa principal dahil mali ang kanilang ginagawa.";    

            question8Text.text = "Nalaman mong may nakuhang kodigo ang iyong mga kaklase sa pagsusulit niyo sa matematika, ano ang gagawin mo?";
            choice8AText.text = "A. Kunin ang kodigo upang makakuha ng mataas na marka.";
            choice8BText.text = "B. Mag-aral na lamang ng mabuti.";  

            question9Text.text = "Ikaw ay na traffic sa highway at ikaw ay dumating nang late sa inyong classroom at tinanong ka ng guro kung ano ang sanhi ng iyong pagkahuli, ano ang sasabihin mo?";
            choice9AText.text = "A. Ikaw ay mag palusot para hindi mahuli sa schedule.";
            choice9BText.text = "B. Sabihin ang totoo at aminin na mali mo ito.";


            question10Text.text = "Ikaw ay nakapulot ng ballpen sa ilalim ng iyong desk chair, ano ang iyong gagawin?";
            choice10AText.text = "A. Magtanong kung kanino ito dahil baka yun ang huling ballpen ng nahulugan.";
            choice10BText.text = "B. Itago ito dahil ito ay sayang ."; 
        }        
    }

    //Hide Great and Sorry Panel
    public void HideCorrectAndSorryPanel()
    {
        wrongAnswerPanel.SetActive(false);
        correctAnswerPanel.SetActive(false);
    }
}
