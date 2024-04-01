using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class apple : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;

    bool clickingOnSelf;
    bool isSelected;
    Vector2 movement;
    Vector2 destination;
    public GameObject highlight;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        destination = transform.position;
        Selected(false);
    }
    public void Selected(bool value)
    {
        isSelected = value;
        highlight.SetActive(isSelected);
    }

    private void FixedUpdate()
    {
        movement = destination - (Vector2)transform.position;

        //stop moving if we're close enough to the target
        if (movement.magnitude < 0.1)
        {
            movement = Vector2.zero;
            speed = 3;
        }

        rb.MovePosition(rb.position + movement.normalized * speed * Time.deltaTime);
    }

    protected virtual void Update()
    {
       
        if (Input.GetMouseButtonDown(0) && isSelected && !clickingOnSelf)
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        animator.SetFloat("Movement", movement.magnitude);
    }

    private void OnMouseDown()
    {
        clickingOnSelf = true;
        AppleController.SetSelectedApple(this);
    }

    private void OnMouseUp()
    {
        clickingOnSelf = false;
    }

}
