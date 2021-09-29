using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    bool isClicked = false;
    int turn = 1;

    public GameObject cross;

    public GameObject naught; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Debug.Log("Button Pressed");
        isClicked = true; 

        if(turn%2 == 0)
        {
            Instantiate(cross);
            cross.SetActive(true);
        }
        else
        {
           
            Instantiate(naught);
            naught.SetActive(true);
        }
        isClicked = false;
        turn = turn + 1; 
        
    }

}
