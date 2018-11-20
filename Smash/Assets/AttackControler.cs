using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackControler : MonoBehaviour {

    public Animator animator;
    //private bool attackHandLight=false;
    //private bool attackHandHeavy=false;

	
	void Start () {
		
	}
	
	
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("attackLightHand", true);
            //animator.SetBool("attackLightHand", false);
        }


        if (Input.GetButtonDown("Fire2"))
        {
            animator.SetBool("attackHeavyHand", true);
            //animator.SetBool("attackHeavyHand", false);
        }

        if (Input.GetButtonDown("Fire3"))
        {
            animator.SetBool("attackHeavyLeg", true);
            //animator.SetBool("attackHeavyHand", false);
        }

        if (Input.GetButtonDown("Submit"))
        {
            animator.SetBool("attackLightLeg", true);
            //animator.SetBool("attackHeavyHand", false);
        }

    }

    public void endLightattackHand()
    {
        animator.SetBool("attackLightHand", false);
    }

    public void endHeavyAttackHand()
    {
        animator.SetBool("attackHeavyHand", false);
    }

    public void endLightAttackLeg()
    {
        animator.SetBool("attackLightLeg", false);
    }

    public void endHeavyAttackLeg()
    {
        animator.SetBool("attackHeavyLeg", false);
    }


}
