using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour
{
 	public static PlayMenu instance;
     void Awake() {
        Time.timeScale = 1f;

        if (instance == null) {
            instance = this;
        }
    }
    
    void Update () {
		
	}

    public void PlayGame() {
        SceneManager.LoadScene("Minigame");
    }

        public void ptShop()
    {
        SceneManager.LoadScene("PetShop");
    }
}
