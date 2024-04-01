using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Red : apple
{
    Coroutine coroutine;
    protected override void Start()
    {
        base.Start();
    }

    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Red") && coroutine==null)
        {
            coroutine=StartCoroutine(Countdown());
        }

    }
    IEnumerator Countdown()
    {
        animator.SetTrigger("Crash");
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
        AppleSpawner.Count -= 1;
    }
    
}
