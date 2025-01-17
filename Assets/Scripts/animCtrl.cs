using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animCtrl : MonoBehaviour{

    private Animator animator;
    bool left=true;
    bool right=false;
    bool up=false;
    bool down=false;
    // Start is called before the first frame update
    void Start(){
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){
        float moveY=Input.GetAxisRaw("Vertical");
        float moveX=Input.GetAxisRaw("Horizontal");

        if(moveY<0){
            animator.Play("WalkDown");
            down=true;
            up=false;
            right=false;
            left=false;
        }
        else if(moveY>0){
            animator.Play("WalkUp");
            down=false;
            up=true;
            right=false;
            left=false;
        } 
        else if(moveX<0){
            animator.Play("WalkLeft");
            down=false;
            up=false;
            right=false;
            left=true;
        }
        else if(moveX>0){
            animator.Play("WalkRight");
            down=false;
            up=false;
            right=true;
            left=false;
        }
        else if(moveY==0&&moveX==0&&down==true){ 
            animator.Play("IdleDown");
        }
        else if(moveY==0&&moveX==0&&up==true){ 
            animator.Play("IdleUp");
        }
        else if(moveY==0&&moveX==0&&left==true){
            animator.Play("IdleLeft");
        }
        else if(moveY==0&&moveX==0&&right==true){ 
            animator.Play("IdleRight");
        }
    }
}
