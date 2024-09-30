using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GlobalCoins : MonoBehaviour
{
    public static int CoinCount = 0;
    public int InternalCoin = 0;
    public TMP_Text CoinDisplayText;

    void Update()
    {
        InternalCoin = CoinCount;
        CoinDisplayText.text = " " + InternalCoin;

    }
}
