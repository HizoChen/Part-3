using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class building : MonoBehaviour
{
    public Transform[] Building;
    float interpolation;
    public AnimationCurve curve;
    float timer;
    void Start()
    {
        timer = 0;
        for (int i = 0; i < Building.Length; i++) Building[i].localScale = Vector3.zero;
        StartCoroutine(Buildin());
    }
    private void Update()
    {
        timer += Time.deltaTime;
    }
    IEnumerator Buildin()
    {
        for (int i = 0; i < Building.Length; i++)
        {
            Transform element = Building[i];
            while (element.localScale.x < 1)
            {
                interpolation=curve.Evaluate(timer);
                element.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, interpolation);
                yield return null;                            
            }  
            timer = 0;
        }
      
    }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
}
