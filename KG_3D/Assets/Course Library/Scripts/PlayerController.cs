using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;  //跳躍力道
    public float gravityModifier; //系統物理重力
    
    public bool isOnground = true; //是否站在地板上

    public bool gameOver = false;

    private Animator playerAnim;

    public ParticleSystem ps_explosion;
    public ParticleSystem ps_dirty;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier; // 等同 Physics.gravity * Physics.gravity = gravityModifier
        playerAnim = GetComponent<Animator>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnground){
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnground = false;
            playerAnim.SetTrigger("Jump_trig");
            ps_dirty.Stop();
        }
    }

    //若與地板有接觸(Enter)，則設為 true
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Ground")){
            isOnground = true; //表示在地板上(避免二段跳)
            ps_dirty.Play();
        } else if (other.gameObject.CompareTag("OOO")){
            gameOver = true; //因為碰撞到障礙物，表示遊戲結束
            print("遊戲結束！");  //在 #Console 視窗顯示 "遊戲結束"
        }

        playerAnim.SetBool("Death_b", true);
        playerAnim.SetInteger("DeathType_int", 1);
        ps_explosion.Play();
        ps_dirty.Stop();



    }
}
