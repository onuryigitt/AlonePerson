
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KarakterHareket : MonoBehaviour
{
    public int hiz;
    private float hareketYonu;
    private Rigidbody2D rb;
    private Animator anim;
    private bool karaktersagYuz = true;

    public Text text;
    public int deger;

    private Vector3 previousPosition;

    public float jumpForce = 40.0f;

    int jump_count = 0;
    bool jump_active = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        previousPosition = transform.position;
    }

    private void FixedUpdate()
    {

        rb.velocity = new Vector2(hareketYonu * hiz, rb.velocity.y);

        if (karaktersagYuz == false && hareketYonu > 0)
        {
            Flip();
        }
        else if (karaktersagYuz == true && hareketYonu < 0)
        {
            Flip();
        }
    }

    private void Flip()
    {
        karaktersagYuz = !karaktersagYuz;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    void Update()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal, 0);

        if (previousPosition != transform.position)
        {
            anim.SetBool("Kosarken", true);
        }
        else
        {
            anim.SetBool("Kosarken", false);
        }

        previousPosition = transform.position;
    }

    public void sol()
    {
        hareketYonu = -1;
    }

    public void sag()
    {
        hareketYonu = 1;
    }

    public void Dur()
    {
        hareketYonu = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            ActivateJump();
        }
        if (collision.gameObject.tag == "Yuva")
        {

            SceneManager.LoadScene("LevelGec");
        }
        if (collision.gameObject.tag == "Lav")
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

   public void Jump()
    {
        if (jump_active)
        {
            if (jump_count < 2)
            {
                rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                jump_count++;
            }
            else
            {
                jump_count = 0;
                DeactivateJump();
            }
        }
    }

    void DeactivateJump()
    {
        jump_active = false;
    }

    void ActivateJump()
    {
        jump_active = true;
        jump_count = 0;
    }

    private void OnTriggerEnter2D(Collider2D Karakter)
    {
        if(Karakter.gameObject.tag =="Mektup")
        {
            Destroy(Karakter.gameObject);
        }
        if (Karakter.gameObject.tag == "Mektup")
        {
            deger--;
            text.text = deger.ToString();
        }
    }

}  




