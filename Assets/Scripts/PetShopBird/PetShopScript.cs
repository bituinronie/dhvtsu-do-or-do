using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PetShopScript : MonoBehaviour
{
    	public static PetShopScript instance;
     void Awake() {
        Time.timeScale = 1f;

        if (instance == null) {
            instance = this;
        }
    }
    int points;
    public GameObject birdPlayButton, birdPanel, puppyPlayButton, puppyPanel;
    public Text pointText;
    // Start is called before the first frame update
    void Start()
    {
        points = PlayerPrefs.GetInt("playerScore");
        birdPlayButton.SetActive(false);
        birdPanel.SetActive(false);
        puppyPlayButton.SetActive(false);
        puppyPanel.SetActive(false);

        pointText.text = "Current Points: "+points.ToString();
    }

    // Update is called once per frame
    void Update()
    {   
        // if score below than 20 then dont shot play button
        if(points < 20)
        {
            birdPanel.SetActive(true);
        }
        else
        {
            birdPlayButton.SetActive(true);
        }

        // if score below than 50 then dont shot play button
        if(points < 50)
        {
            puppyPanel.SetActive(true);
        }
        else
        {
            puppyPlayButton.SetActive(true);
        }

    }

    public void PlayAsTappyBird()
    {
        SceneManager.LoadScene("MiniGameBird");
    }

    public void GoToMenuSelection()
    {
        SceneManager.LoadScene("MapSelection");
    }
}
