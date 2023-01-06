using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;

public class GoldUI : MonoBehaviour
{
    
    private TextMeshProUGUI text;

    private void Start()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
        text.text = "Gold : ";
        UpdateGold(0);
    }
    public void UpdateGold(int amount)
    {
        text.text = "Gold : " + amount.ToString();
    }
}
