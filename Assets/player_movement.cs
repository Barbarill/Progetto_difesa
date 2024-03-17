using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    private Rigidbody2D zelena;
    private float dirX = 0f;
    private SpriteRenderer sprite;
    private Animator anim;

    private void Start()
    {
        zelena = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        dirX = Input.GetAxisRaw("HorizontalZ");
        zelena.velocity = new Vector2(dirX * 3.5f, zelena.velocity.y);

        UpdateAnimation();
    }

    private void UpdateAnimation()
    {
        if (dirX > 0f)
        {
            anim.SetBool("run_Z", true);
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            anim.SetBool("run_Z", true);
            sprite.flipX = true;
        }
        else
        {
            anim.SetBool("run_Z", false);
        }
    }
}
