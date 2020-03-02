using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{

	private Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
		anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void animWalk()
	{
		anim.Play("walk", -1, 0f);
        
    }

    public void animHit1()
	{
		anim.Play("hit01", -1, 0f);
	}

	public void animHit2()
	{
		anim.Play("hit02", -1, 0f);
	}

	public void animJump()
	{
		anim.Play("jump", -1, 0f);
	}

}
