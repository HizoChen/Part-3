using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterControl : MonoBehaviour
{
    public static Villager SelectedVillager { get; private set; }
    public TextMeshProUGUI currentlytype;
    void Start()
    {
        currentlytype.text = "Type of villager";
    }

    private void Update()
    {
        if (SelectedVillager != null)
        {
            currentlytype.text = SelectedVillager.GetType().ToString();
        }

    }

    public static void SetSelectedVillager(Villager villager)
    {
        if (SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
    }

}