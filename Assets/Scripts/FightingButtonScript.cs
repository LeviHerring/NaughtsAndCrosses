using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightingButtonScript : MonoBehaviour
{

    bool isClicked = false;
    int turn = 1;

    int naughtHealth = 50;
    int crossHealth = 40;

    public GameObject enemyText;
    public GameObject HeroText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickAttack()
    {
        isClicked = true;

        if (turn % 2 == 0)
        {
            enemyText.SetActive(false);
            HeroText.SetActive(true);

        }
        else
        {
            enemyText.SetActive(true);
            HeroText.SetActive(false);
        }
        isClicked = false;
        turn = turn + 1;

    }

    public void OnClickHeal()
    {

    }

    public void OnClickRun()
    {

    }

    public void NaughtHealth()
    {

    }

    public void CrossHealth()
    {

    }

}
