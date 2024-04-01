using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Total : MonoBehaviour
{
    public TMPro.TextMeshProUGUI totalnumber;
    // Start is called before the first frame update
    private void Start()
    {
      totalnumber.text = AppleController.total.ToString();
    }

}
