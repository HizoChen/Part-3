using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Xml.Linq;

public class CharacterControl : MonoBehaviour
{
    float interpolation;
    public Villager[] array = new Villager[3];
    public TMP_Dropdown dropdown;
    public TMPro.TextMeshProUGUI currentSelection;
    public static CharacterControl Instance;
    private void Start()
    {
        Instance = this;
    }
    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        Instance.currentSelection.text = villager.ToString();
    }
    public void SliderHasChangedValue(Single value)
    {
        
        SelectedVillager.transform.localScale = Vector3.one*value;
    }
   
    public void DropdownHasChangedValue(int value)

    {
        SetSelectedVillager(array[value]);
    }
    //private void Update()
    //{
    //    if(SelectedVillager != null)
    //    {
    //        currentSelection.text = SelectedVillager.GetType().ToString();
    //    }
    //}
}
