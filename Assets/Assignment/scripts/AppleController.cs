using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleController : MonoBehaviour
{
    float interpolation;
    public apple[] array = new apple[3];
    public static apple SelectedApple;
     public static void SetSelectedApple(apple apple)
    {
        if (SelectedApple != null)
        {
            SelectedApple.Selected(false);
        }
        SelectedApple = apple;
        SelectedApple.Selected(true);
    }
}
