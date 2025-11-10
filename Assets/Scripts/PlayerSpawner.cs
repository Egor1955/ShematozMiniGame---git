using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject unit;
    public Transform point;

    public void Press()
    {
        if (AttackCount.AttackCoin >= 6)
        {
            AttackCount.AttackCoin -= 6;
            Instantiate(unit, point.position, point.rotation);
        }
    }
}
