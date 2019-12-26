using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;


public class SAI : MonoBehaviour
{
    private Animation eleanim;
    public AnimationClip[] eleanimations;
   
    // Start is called before the first frame update


    int animnum = 0;
    void Awake()
    {
        eleanim = gameObject.GetComponent<Animation>();
       


    }


    void Start()
    {
        StartCoroutine(wait());

        if (eleanim)
        {
            eleanim.clip = eleanimations[animnum];
            eleanim.Play();
           
            

        }



    }

    // Update is called once per frame
    void Update()
    {

       
       



    }



   IEnumerator wait()
    {

        yield return new WaitForSeconds(5);
        animnum++;
        clipchange();


    }


    private void clipchange()
   {
       
            eleanim.Stop();
            eleanim.clip = eleanimations[animnum];
            eleanim.Play();

        StartCoroutine(wait());
      
    }







}
