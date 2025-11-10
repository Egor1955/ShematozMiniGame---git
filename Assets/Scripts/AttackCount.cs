using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AttackCount : MonoBehaviour
{
    public static float AttackCoin = 0;
    public TextMeshProUGUI CoinText;
    public int AttackMax = 35;

    void Start()
    {
        AttackCoin = 0;
    }

    void Update()
    {
        CoinText.text = "Power: " + ((int)AttackCoin).ToString();

        if (AttackCoin < AttackMax)
        {
            AttackCoin += Time.deltaTime * 2;
        }
    }
}
