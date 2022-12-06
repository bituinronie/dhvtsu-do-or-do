using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MapSelectionScript : MonoBehaviour
{

    public Button buttonmap1, buttonmap2, buttonmap3, buttonmap4, buttonmap5, buttonmap6;
    int playerPoint;
    // Start is called before the first frame update
    void Start()
    {
        // buttonmap1.interactable = false;
        buttonmap2.interactable = false;
        buttonmap3.interactable = false;
        buttonmap4.interactable = false;
        buttonmap5.interactable = false;
        buttonmap6.interactable = false;

        playerPoint = PlayerPrefs.GetInt("playerScore");
    }

    // Update is called once per frame
    void Update()
    {
        if(playerPoint >= 10)
        {
        buttonmap1.interactable = true;
        }

        if(playerPoint >= 10)
        {
        buttonmap2.interactable = true;
        }

        if(playerPoint >= 20)
        {
        buttonmap3.interactable = true;
        }

        if(playerPoint >= 30)
        {
        buttonmap4.interactable = true;
        }

        if(playerPoint >= 40)
        {
        buttonmap5.interactable = true;
        }

        if(playerPoint >= 50)
        {
        buttonmap6.interactable = true;
        }



    }

    public void map1(){
        SceneManager.LoadScene("Map1");
    }

    public void map2(){
        SceneManager.LoadScene("Map2");
    }

    public void map3(){
        SceneManager.LoadScene("Map3");
    }

    public void map4(){
        SceneManager.LoadScene("Map4");
    }

    public void map5(){
        SceneManager.LoadScene("Map5");
    }

    public void map6(){
        SceneManager.LoadScene("Map6");
    }


    public void petShopScene(){
        SceneManager.LoadScene("PetShop");
    }


}
