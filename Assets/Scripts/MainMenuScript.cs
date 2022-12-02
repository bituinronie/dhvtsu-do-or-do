using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    public GameObject languageSelectionScreen, mainMenuScreen, menuOptionsScreen, quitScreen, playerNameScreen, levelSelectionScreen, proceedText, selectCharacterScreen;
    public Text playerName, homeScreenText, newGameText, loadGameText, quitText, playerNameConfirmText, playerNamePlaceHolderText, selectCharacterText;
    public AudioSource clickSound;

    public string language  = "english";

    public string whichMap = "StoryLine";
    // Start is called before the first frame update
    void Start()
    {
        HideAllScreen();
        languageSelectionScreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        LanguageUpdater();
    }

    //Click Main menu screen
    public void MainMenuScreen(){
        HideAllScreen();
        clickSound.Play();
        menuOptionsScreen.SetActive(true);
    }

    //Click New Game
    public void NewGame(){
        HideAllScreen();
        playerNameScreen.SetActive(true);
        clickSound.Play();
        PlayerPrefs.SetString("questionCorrect", "1");
        PlayerPrefs.SetInt("playerScore", 0);
    }

    //Confirm New Game
    public void ConfirmNewGame(){
        HideAllScreen();
        selectCharacterScreen.SetActive(true);
        clickSound.Play();
        string _playerName = playerName.text;
        PlayerPrefs.SetString("playerName", _playerName);
        Debug.Log(PlayerPrefs.GetString("playerName"));
        // SceneManager.LoadScene("Map1");
    }

    //Select Characters Here
    public void SelectCharacter(){
        clickSound.Play();
        SceneManager.LoadScene("Map1");
    }

    //Character Male
    public void SelectCharacterMale1(){
        PlayerPrefs.SetString("playerCharacter", "maleCharacter1");
        clickSound.Play();
        SceneManager.LoadScene(whichMap);
    }

    public void SelectCharacterMale2(){
        PlayerPrefs.SetString("playerCharacter", "maleCharacter2");
        clickSound.Play();
        SceneManager.LoadScene(whichMap);
    }

    public void SelectCharacterFemale1(){
        PlayerPrefs.SetString("playerCharacter", "femaleCharacter1");
        clickSound.Play();
        SceneManager.LoadScene(whichMap);
    }

    public void SelectCharacterFemale2(){
        PlayerPrefs.SetString("playerCharacter", "femaleCharacter2");
        clickSound.Play();
        SceneManager.LoadScene(whichMap);
    }

    //Load Game
    public void LoadGame(){
        SceneManager.LoadScene("MapSelection");
    }


    //Hide All Screen
    public void HideAllScreen(){
        languageSelectionScreen.SetActive(false);
        mainMenuScreen.SetActive(false);
        menuOptionsScreen.SetActive(false);
        // quitScreen.SetActive(false);
        playerNameScreen.SetActive(false);
        selectCharacterScreen.SetActive(false);
        // levelSelectionScreen.SetActive(false);
        // proceedText.SetActive(false);
    }


    //Choose Language here
    public void chooseEnglish(){
        language = "english";
        PlayerPrefs.SetString("playerLanguage",language);
        HideAllScreen();
        clickSound.Play();        
        mainMenuScreen.SetActive(true);  
    }

    public void chooseFilipino(){
        language = "filipino";
        PlayerPrefs.SetString("playerLanguage",language);
        HideAllScreen();
        clickSound.Play();
        mainMenuScreen.SetActive(true);   
    }

    public void LanguageUpdater(){
        if(language == "english"){
            homeScreenText.text = "Tap anywhere to start";
            newGameText.text = "New Game";
            loadGameText.text = "Load Game";
            quitText.text = "Quit";
            playerNameConfirmText.text = "Confirm";
            playerNamePlaceHolderText.text = "Your Name";
            selectCharacterText.text = "Press the desired character";
        }
        else{
            homeScreenText.text = "Pumindot kahit saan para mag simula";
            newGameText.text = "Panibagong Laro";
            loadGameText.text = "Magpatuloy ng Laro";
            quitText.text = "Isara ang Laro";
            playerNameConfirmText.text = "Ikumpirma";
            playerNamePlaceHolderText.text = "And Iyong Pangalan";
            selectCharacterText.text = "Pindutin ang karakter na natipuhan";
        }
    }
}
