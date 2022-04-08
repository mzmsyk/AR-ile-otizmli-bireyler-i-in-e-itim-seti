using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Animator[] anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playAnim()
    {
       // anim[0].speed = 1;
       // anim[1].speed = 1;
       for(int i = 0; i <= 100; i++)
        {
            anim[i].speed = 1;
        }
    }
    public void stopAnim()
    {
        //anim[0].speed = 0;
        // anim[1].speed = 0;
        for (int i = 0; i <= 100; i++)
        {
            anim[i].speed = 0;
        }
    }
}
