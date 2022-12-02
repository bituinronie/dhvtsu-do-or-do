using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PetShop : MonoBehaviour


{
   	public static PetShop instance;
     void Awake() {
        Time.timeScale = 1f;

        if (instance == null) {
            instance = this;
        }
    }

    public void ptShop()
    {
        SceneManager.LoadScene("MainMenu");
    }
 public void PlayGame() {
        SceneManager.LoadScene("PlayMenu");
    }

}
