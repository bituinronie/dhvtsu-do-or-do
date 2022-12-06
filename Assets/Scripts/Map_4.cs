using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Map_4 : MonoBehaviour
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
            correctText.text = _concat+"Change will be returned to the seller";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Isauli ang sukli sa nagtitinda";
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
            correctText.text = _concat+"Take it and tell the owner";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Kunin at sabihin sa may ari";
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
            correctText.text = _concat+"Be careful";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Magbabantay ng paninda";
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
            correctText.text = _concat+"Forbid and tell ale";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Pagbawalan at sabihin kay Ale.";
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
            correctText.text = _concat+"Say it so you can be treated and cleaned properly";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Sabihin ito para magamot ka at malinis ito ng tama.";
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
            correctText.text = _concat+"Forbid and told to pay correctly";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Pagbawalan at sabihan na magbayad ng tama.";
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
            correctText.text = _concat+"Say it early so you can be injected with anti-rabies and get better";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Sabihin ito ng maaga para ikaw ay maturukan ng anti rabies at gumaling .";
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
            correctText.text = _concat+"Buy again to exchange for a new one";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Bumili ulit para palitan ng bago.";
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
            correctText.text = _concat+"Keep it private because it is a sensitive matter";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Hayaan itong pribado dahil ito ay maselan na bagay.";
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
            correctText.text = _concat+"Make your way and talk to the park management that you have found the cat they are looking for";
        }
        else{
            string _concat = "Ang tamang sagot ay ";
            correctText.text = _concat+"Gumawa ng paraan at kausapin ang mga namamahala sa park na nakita mo ang pusang hinahanap.";
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
            question1Text.text = "You ate at a restaurant, and the seller gave you too much change. What will you do?";
            choice1AText.text = "A. Will leave and keep the extra change.";
            choice1BText.text = "B. Change will be returned to the seller.";

            question2Text.text = "Your mom takes you shopping, and when you bump into someone, you see their money fall. What will you do?";
            choice2AText.text = "A. Leave it alone.";
            choice2BText.text = "B. Take it and tell the owner.";

            question3Text.text = "Your mother asked you to look after the goods because she is going to the market. What will you do??";
            choice3AText.text = "A. Be careful.";
            choice3BText.text = "B. Cut and leave.";            

            question4Text.text = "You saw someone stealing fruit from Ale's store.";
            choice4AText.text = "A. Leave and take as well.";
            choice4BText.text = "B. Forbid and tell ale.";           

            question5Text.text = "You are instructed to buy cooking oil, and you are running to get back quickly. But you didn't see the stone, and you trip. What will you do or say to your parents";
            choice5AText.text = "A. Say it so you can be treated and cleaned properly.";
            choice5BText.text = "B. Don't tell and hide it.";  

            question6Text.text = "You are eating with your friend, and you know that he has eaten a lot, but the payment he gave to the vendor does not match the price of what he eats. What is the right thing to do?";
            choice6AText.text = "A. Forbid and told to pay correctly.";
            choice6BText.text = "B. Leave and imitate what he is doing.";    

            question7Text.text = "You go to the store to buy something, but an aspin chases you and bites you. What should you do?";
            choice7AText.text = "A. Don't say anything because you are afraid.";
            choice7BText.text = "B. Say it early so you can be injected with anti-rabies and get better.";

            question8Text.text = "Your mother ordered you to buy an egg, but it fell and broke. What will you do?";
            choice8AText.text = "A. Buy again to exchange for a new one.";
            choice8BText.text = "B. Lie to the parent and say someone else broke the eggs.";    

            question9Text.text = "Hayaan itong pribado dahil ito ay maselan na bagay?";
            choice9AText.text = "A. Keep it private because it is a sensitive matter.";
            choice9BText.text = "B. Shout it out and make fun of it.";          

            question10Text.text = "You are walking in the park and you notice that the cat you see is the wanted cat attached to the posters. What will you do?";
            choice10AText.text = "A. Just walk past the cat and ignore it.";
            choice10BText.text = "B. Make your way and talk to the park management that you have found the cat they are looking for.";          


        }
        else{
            question1Text.text = "Ikaw ay kumain sa isang karinderya at sobra ang binigay na sukli sayo ng nagtitinda, ano ang iyong gagawin??";
            choice1AText.text = "A. Aalis at itatago na lang ang sobrang sukli.";
            choice1BText.text = "B. Isauli ang sukli sa nagtitinda.";

            question2Text.text = "Sinama ka ng mama mo na mamalengke ngunit may nakasalubong kang tao at nakita mo nahulog ang kanyang pera, ano ang iyong gagawin?";
            choice2AText.text = "A. Pabayaan na lang";
            choice2BText.text = "B. Kunin at sabihin sa may ari";

            question3Text.text = "Nag habilin sayo ang iyong ina na bantayan ang paninda dahil siya ay mamamalengke, ano ang iyong gagawin?";
            choice3AText.text = "A. Magbabantay ng paninda";
            choice3BText.text = "B. Mangungupit at pabayaan ang paninda";     

            question4Text.text = "Meron kang nakitang kumukuha nang prutas sa paninda ni Ale, ano ang iyong gagawin?";
            choice4AText.text = "A. Pabayaan at kumuha rin.";
            choice4BText.text = "B. Pagbawalan at sabihin kay Ale.";     

            question5Text.text = "Ikaw ay inutusan para bumili ng mantika ngunit tumatakbo ka para mabilis kang makabalik at hindi mo nakita ang bato at ika'y nadapa, ano ang gagawin mo o sasabihin sa iyong magulang?";
            choice5AText.text = "A. Sabihin ito para magamot ka at malinis ito ng tama.";
            choice5BText.text = "B. Wag sabihin at itago ito.";                             

            question6Text.text = "Kumakain kayo ng iyong kaibigan at alam mong marami na siyang nakain subalit hindi akma ang kanyang binigay na bayad sa nagtitinda, ano ang tamang gagawin?";
            choice6AText.text = "A. Pagbawalan at sabihan na magbayad ng tama.";
            choice6BText.text = "B. Pabayaan at tularan sa kanyang ginagawa.";  

            question7Text.text = "Papunta ka sa tindahan para bumili ngunit nahabol ka ng aspin at nakagat ka, ano ang nararapat mong gawin?";
            choice7AText.text = "A. Wag sabihin sa ina dahil ikaw ay natatakot.";
            choice7BText.text = "B. Sabihin ito ng maaga para ikaw ay maturukan ng anti rabies at gumaling .";    

            question8Text.text = "Inutusan ka ng iyong nanay para bumili ng itlog ngunit ito ay nahulog at nabasag, ano ang iyong gagawin?";
            choice8AText.text = "A. Bumili ulit para palitan ng bago.";
            choice8BText.text = "B. Magsinungaling sa magulang at sabihing iba ang nakabasag sa mga itlog.";  

            question9Text.text = "Nalaman mo na ang iyong kaibigan ay may tinatagong karamdaman, ano ang nararapat mong gawin?";
            choice9AText.text = "A. Hayaan itong pribado dahil ito ay maselan na bagay.";
            choice9BText.text = "B. Ipagsigawan ito at gawing katatawanan.";


            question10Text.text = "Ikaw ay naglalakad sa park at napansin mo na ang nakita mong pusa ay ang pusang hinahanap na nakakabit sa mga poster, ano ang iyong gagawin?";
            choice10AText.text = "A. Daanan lamang ang pusa at huwag itong pansinin.";
            choice10BText.text = "B. Gumawa ng paraan at kausapin ang mga namamahala sa park na nakita mo ang pusang hinahanap."; 
        }        
    }

    //Hide Great and Sorry Panel
    public void HideCorrectAndSorryPanel()
    {
        wrongAnswerPanel.SetActive(false);
        correctAnswerPanel.SetActive(false);
    }
}
