using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForgroundManager : MonoBehaviour
{
    public int d20;

    public bool gameStart;

    //public Animator animator;
    
    public GameObject juniperJazz;
    public GameObject reya;
    public GameObject pirate;
    public GameObject sam;
    public GameObject bMan;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RollDice());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(d20);


        if (gameStart) {

            Debug.Log("here we go!");

            if (d20 == 1)
            {
                //Juniper
                //Debug.Log("Juniper Jazz is on the case!");
                juniperJazz.SetActive(true);
                d20 = 0;


            }

            if (d20 == 2)
            {
                //Reya
                reya.SetActive(true);
                d20 = 0;



            }

            if (d20 == 3)
            {
                //pirate
                pirate.SetActive(true);
                d20 = 0;

            }

            if (d20 == 4)
            {
                //Sam
                sam.SetActive(true);
                d20 = 0;

            }

            if (d20 == 5)
            {
                //bMan
                bMan.SetActive(true);
                d20 = 0;

            }

        }
    }

    IEnumerator RollDice()
    {
        //Debug.Log("called");
       
        yield return new WaitForSeconds(8);
        d20 = Random.Range(1, 7);
        yield return new WaitForSeconds(8);
        StartCoroutine(RollDice());
    }

    
}
