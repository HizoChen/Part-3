using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIdemo : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public SpriteRenderer sr;
    public Color start;
    public Color end;
    float interpolation;
 public void SliderHasChangedValue(Single value)
    {
        interpolation=value;
    }
    private void Update()
    {
        sr.color = Color.Lerp(start, end, (interpolation/60));
    }
    public void DropdownHasChangedValue(int value)

    {
        Debug.Log(dropdown.options[value].text);
    }
}

