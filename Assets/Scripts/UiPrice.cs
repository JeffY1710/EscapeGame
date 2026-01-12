using System.Security.Cryptography;
using TMPro;
using UnityEngine;

public class UiPrice : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    public PriceScript priceScript;
    public void updateDisplay()
    {
        float total = priceScript.getTotal();
        text.text = total.ToString();
    }
}
