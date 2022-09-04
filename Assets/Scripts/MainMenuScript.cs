using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    public GameObject languageSelectionScreen, mainMenuScreen, menuOptionsScreen, quitScreen, playerNameScreen, levelSelectionScreen, proceedText;
    public Text playerName, homeScreenText, newGameText, loadGameText, quitText, playerNameConfirmText, playerNamePlaceHolderText;
    public AudioSource clickSound;

    public string language  = "english";

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
    }

    //Confirm New Game
    public void ConfirmNewGame(){
        clickSound.Play();
        SceneManager.LoadScene("Map1");
    }

    //Hide All Screen
    public void HideAllScreen(){
        languageSelectionScreen.SetActive(false);
        mainMenuScreen.SetActive(false);
        menuOptionsScreen.SetActive(false);
        // quitScreen.SetActive(false);
        playerNameScreen.SetActive(false);
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
            }
        else{
            homeScreenText.text = "Pumindot kahit saan para mag simula";
            newGameText.text = "Panibagong Laro";
            loadGameText.text = "Magpatuloy ng Laro";
            quitText.text = "Isara ang Laro";
            playerNameConfirmText.text = "Ikumpirma";
            playerNamePlaceHolderText.text = "And Iyong Pangalan";

        }
    }
}
