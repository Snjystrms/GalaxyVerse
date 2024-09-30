using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public TMP_Text NotEnoughCoins;
    public Animator _animator;
    private const string CLICK_TRIGGER = "Click";
    public Animator _animator2;
    private const string CLICK_TRIGGER2 = "Click2";

    public void ClickTheButton()
    {
        if (GlobalPoints.PointCount == 0)
        {
            NotEnoughCoins.text = "Not Enough Coins To Spend";
            NotEnoughCoins.GetComponent<Animation>().Play("NotEnoughcoinsAnim");
        }
        else
        {
            _animator.SetTrigger(CLICK_TRIGGER);
            _animator2.SetTrigger(CLICK_TRIGGER2);
            GlobalPoints.PointCount -= 1;
            GlobalCoins.CoinCount += 1;
        }

    }
}
