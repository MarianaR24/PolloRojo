using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtaMov : MonoBehaviour
{
    private BoxCollider2D bodyBox;
    private RaycastHit2D hit;
    private Vector3 moveProta;

    public float speed;

    public Animator animator;

    private void Start()
    {
        bodyBox = GetComponent<BoxCollider2D>();
    }

     void FixedUpdate()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        moveProta = new Vector3(hor * speed, ver * speed, 0);

        animator.SetFloat("Horizontal", hor);
        animator.SetFloat("Vertical", ver);

        transform.Translate(moveProta.x, moveProta.y, 0);
    }
}
