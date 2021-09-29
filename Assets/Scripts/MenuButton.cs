using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MenuButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPressed()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void Back()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
