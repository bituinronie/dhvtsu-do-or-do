using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PowsMenu : MonoBehaviour
{
        [SerializeField] GameObject powsMenu;
         public void Pause()
      {
        powsMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resumee()
    {
        powsMenu.SetActive (false);
        Time.timeScale = 1f;
    }

    public void Homee (int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("PlayMenu");
    }
}