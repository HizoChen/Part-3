using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Black : apple
{
    Coroutine exploding;

    public override void Selected(bool value)
    {
        base.Selected(value);
        if (value && exploding==null) 
        { 
            exploding=StartCoroutine(Explode()); 
        }
    }
    IEnumerator Explode()
    {
        float scale = 0.33f;
        while (scale < 0.6)
        {
               scale += Time.deltaTime / 8;
               transform.localScale = new Vector3(scale, scale, scale);
            
            yield return null;
        }
        animator.SetTrigger("Explode");
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);
        AppleSpawner.Count -= 1;
       
    }

}
