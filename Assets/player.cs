using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class player : MonoBehaviour
{
    public float moveSpeed;
    public LayerMask terreno1Layer;

    private bool isMoving;
    private Vector2 input;


    private void Update()
    {
        if (!isMoving)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

            //remove diagonal movement
            if (input.x != 0) input.y = 0;

            if (input != Vector2.zero)
            {
                var targetPos = transform.position;
                targetPos.x += input.x;
                targetPos.y += input.y;

                if (IsWalkble(targetPos))
                    StartCoroutine(Move(targetPos));
            }
        }

        //animator.SetBool("isMoving", isMoving);
    }

    IEnumerator Move(Vector3 targetPos)
    {
        isMoving = true;

        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPos;

        isMoving = false;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }

    //collissioni
    private bool IsWalkble(Vector3 targetPos)
    {
        if (Physics2D.OverlapCircle(targetPos, 0.3f, terreno1Layer) != null)
        {
            return false;
        }

        return true;
    }
}