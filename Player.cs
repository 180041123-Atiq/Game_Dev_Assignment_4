using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float MoveSpeed,JumpForce;

    public Rigidbody2D RG2D;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector2(1f,2f);

        RG2D = GetComponent<Rigidbody2D>();

        MoveSpeed = 5f;
        JumpForce = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Jump();
        } else if (Input.GetKeyDown(KeyCode.DownArrow)){
            Crouch();
        } else if (Input.GetKeyDown(KeyCode.RightArrow)){
            GonigRight();
        } else if (Input.GetKeyDown(KeyCode.LeftArrow)){
            GoingLeft();
        }
    }

    void Jump() {
        GettingNormal();
        //Debug.Log("Jumping");
        RG2D.AddForce(new Vector2(JumpForce,JumpForce), ForceMode2D.Impulse);
    }
    void Crouch() {
        Debug.Log("Crouching");
        transform.localScale = new Vector2(2f,1f);
    } 
    void GoingLeft() {
        GettingNormal();
        //Debug.Log("Going Left");
        RG2D.velocity = new Vector2(MoveSpeed*(-1),RG2D.velocity.y);
    } 
    void GonigRight() {
        //Debug.Log("Going Right");
        GettingNormal();
        RG2D.velocity = new Vector2(MoveSpeed*(1),RG2D.velocity.y);
    }
    void GettingNormal() {
        transform.localScale = new Vector2(1f,2f);
    }

}
