using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class AppleController : MonoBehaviour
{
    public static int number;
    public static int total;
    public TMPro.TextMeshProUGUI eating;
    float interpolation;
    public static apple SelectedApple;
    static AppleController Instance;
    private void Start()
    {
        Instance = this;
    }
    public static void SetSelectedApple(apple apple)
    {
        if (SelectedApple != null)
        {
            SelectedApple.Selected(false);
        }
        SelectedApple = apple;
        SelectedApple.Selected(true);
    }
    public static void EatApple(int eat)
    {
        number += eat;

        if (number > total)
        {
            total = number;
        }
        Debug.Log(number);
        Instance.eating.text = number.ToString();
    }
}
