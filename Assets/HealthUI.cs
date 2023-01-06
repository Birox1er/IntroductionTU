using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthUI : MonoBehaviour
{

    [SerializeField] Slider _slider;
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] EntityHealth _playerHealth;

    int CachedMaxHealth { get; set; }
    public void Start()
    {
        _text = GetComponentInChildren<TextMeshProUGUI>();
        _slider = GetComponentInChildren<Slider>();
        _slider.value = 100;
        _slider.maxValue = 100;
        _text.text = "100 / 100";
    }
    public void UpdateSlider(int newHealthValue, int max)
    {
        _slider.value = newHealthValue;
        _slider.maxValue = max;
        _text.text = $"{newHealthValue} /" + max;
        _text.color = Color.green;
    }

}
