using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPoints : MonoBehaviour
{
    public static int PointIncrease = 1;
    public bool CreatingPoint = false;
    public int InternalIncrease;

    private void Update()
    {
        InternalIncrease = PointIncrease;
        if (CreatingPoint == false)
        {
            CreatingPoint = true;
            StartCoroutine(AutoIncreasePoint());
        }
    }
    IEnumerator AutoIncreasePoint()
    {
        GlobalPoints.PointCount += InternalIncrease;
        yield return new WaitForSeconds(0.9f);
        CreatingPoint = false;
    }
}
