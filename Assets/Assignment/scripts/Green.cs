using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : apple
{
    Coroutine coroutine;
    protected override void Start()
    {
        base.Start();
        speed = 6;
        
    }
    public override void Selected(bool value)
    {
        base.Selected(value);
        if (value && coroutine==null)
        {
            coroutine=StartCoroutine(Slowdown());
        }
    }
    IEnumerator Slowdown()
    {
        Coroutine countdown=StartCoroutine(Countdown());
        while (speed <= 6 && speed > 0.5f)
        {
            speed -= Time.deltaTime / 0.8f;
             yield return null;
        }
        yield return countdown;
        Destroy(gameObject);
        AppleSpawner.Count -= 1;
    }
    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(8);
    }
}
