using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AttackCount : MonoBehaviour
{
    public static float AttackCoin = 0;
    public TextMeshProUGUI CoinText;
    public int AttackMax = 35;
    public Image pwr_img;

    void Start()
    {
        AttackCoin = 0;
    }

    void Update()
    {
        CoinText.text = "Power\n" + ((int)AttackCoin).ToString() + " / " + ((int)AttackMax).ToString();

        if (AttackCoin < AttackMax)
        {
            AttackCoin += Time.deltaTime * 2;
        }

        pwr_img.fillAmount = AttackCoin / AttackMax;
    }
}
