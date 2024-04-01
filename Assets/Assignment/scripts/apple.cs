using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.Impl;
using UnityEditor.Experimental.GraphView;
using static UnityEngine.RuleTile.TilingRuleOutput;
public class apple : MonoBehaviour
{
    Rigidbody2D rb;
    protected Animator animator;
    bool clickingOnSelf;
    bool isSelected;
    Vector2 movement;
    Vector2 destination;
    public GameObject highlight;
     public float speed;

    protected virtual void Start()
    {
        speed = 4;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        transform.position = new Vector3(Random.Range(-8f, 8f), Random.Range(-2.5f, 3.5f), 0);
        destination = transform.position;
        Selected(false);
    }
    public virtual void Selected(bool value)
    {
        isSelected = value;
        highlight.SetActive(isSelected);
    }

    private void FixedUpdate()
    {
        movement = destination - (Vector2)transform.position;
        if (movement.magnitude < 0.1)
        {
            movement = Vector2.zero;
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
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Face"))
        { 
            AppleController.EatApple(1);
            Destroy(gameObject);
            AppleSpawner.Count -= 1;
            Debug.Log("eatapple");
        }
       
    }
    
    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {

    }


    }
