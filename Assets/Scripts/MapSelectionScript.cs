using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSelectionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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


    public void petShopScene(){
        SceneManager.LoadScene("PetShop");
    }

}
