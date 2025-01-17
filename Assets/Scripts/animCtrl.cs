using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animCtrl : MonoBehaviour{

    private Animator animator;
    // Start is called before the first frame update
    void Start(){
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){
        float moveY=Input.GetAxisRaw("Vertical");
        float moveX=Input.GetAxisRaw("Horizontal");

        if(moveY<0)animator.Play("WalkDown");
        else if(moveY>0) animator.Play("WalkUp");
        else if(moveY==0&&moveX==0) animator.Play("Idle");
        else if(moveX<0)animator.Play("WalkLeft");
        else if(moveX>0)animator.Play("WalkRight");
    }
}
