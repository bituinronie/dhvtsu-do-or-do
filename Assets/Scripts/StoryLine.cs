using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryLine : MonoBehaviour
{
    public string whichMap;
    public string textOfStoryLine = "This is me. Lucky me. Let me tell you about a man named Atayde. At first, he is a bad guy who doesn't know how to be polite. He doesn't even say \"po\" and \"opo.\" He also doesn't obey his parents. He doesn't even follow rules; one day he regulates the traffic rules and gets hit by a truck! He was hospitalized after the accident and he has been in a coma ever since. While he was in a coma, a white light suddenly appeared in his dream and that light talked to him, saying, \"I will give you a chance to wake up and live a normal life again, but before that, I will let you live in your dream first and correct all the things that you have done, and after that, you will wake up in your real world.\"";
    public Text storyLineText;
    // Start is called before the first frame update
    void Start()
    {
        string name = PlayerPrefs.GetString("playerName");
        string message = "Hi "+ name + "! ";
        message = message + textOfStoryLine;
        storyLineText.text = message;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToMap1()
    {
        SceneManager.LoadScene(whichMap);
    }
}
