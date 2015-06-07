using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {

    Animator anim;
    public GameObject thePlayer;

	void Start () {
        anim = gameObject.GetComponent<Animator>();
	}
	
	void Update () {
        Bounce bounceScript = thePlayer.GetComponent<Bounce>();
	    if (bounceScript.justJump)
	    {
	        anim.SetBool("Jump", true);
	    }
	    else
	    {
	        anim.SetBool("Jump",false);
	    }

	}
}
