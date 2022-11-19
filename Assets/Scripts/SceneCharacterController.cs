using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneCharacterController : MonoBehaviour
{
    public string playerCharacter, questionCorrect;
    public GameObject characterMale1Happy, characterMale1Sad, characterMale2Happy, characterMale2Sad;
    public GameObject characterFemale1Happy, characterFemale1Sad, characterFemale2Happy, characterFemale2Sad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HideAllCharacters();
        playerCharacter = PlayerPrefs.GetString("playerCharacter");
        questionCorrect = PlayerPrefs.GetString("questionCorrect");

        //Character Male 1
        if(playerCharacter == "maleCharacter1" && questionCorrect == "1")
        {
            characterMale1Happy.SetActive(true);
        }
        if(playerCharacter == "maleCharacter1" && questionCorrect == "2")
        {
            characterMale1Sad.SetActive(true);
        }


        //Character Male 2
        if(playerCharacter == "maleCharacter2" && questionCorrect == "1")
        {
            characterMale2Happy.SetActive(true);
        }
        if(playerCharacter == "maleCharacter2" && questionCorrect == "2")
        {
            characterMale2Sad.SetActive(true);
        }

        //Character Female 1
        if(playerCharacter == "femaleCharacter1" && questionCorrect == "1")
        {
            characterFemale1Happy.SetActive(true);
        }
        if(playerCharacter == "femaleCharacter1" && questionCorrect == "2")
        {
            characterFemale1Sad.SetActive(true);
        }

        //Character Female 2
        if(playerCharacter == "femaleCharacter2" && questionCorrect == "1")
        {
            characterFemale2Happy.SetActive(true);
        }
        if(playerCharacter == "femaleCharacter2" && questionCorrect == "2")
        {
            characterFemale2Sad.SetActive(true);
        }

    }

    public void HideAllCharacters()
    {
        characterMale1Happy.SetActive(false);
        characterMale1Sad.SetActive(false);
        characterMale2Happy.SetActive(false);
        characterMale2Sad.SetActive(false);
        characterFemale1Happy.SetActive(false);
        characterFemale1Sad.SetActive(false);
        characterFemale2Happy.SetActive(false);
        characterFemale2Sad.SetActive(false);
    }
}
