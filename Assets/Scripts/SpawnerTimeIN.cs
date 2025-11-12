using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTimeIN : MonoBehaviour
{
    public GameObject Unit;
    public Transform point;

    public void Spawn()
    {
        if (AttackCount.AttackCoin >= 6)
        {
            AttackCount.AttackCoin -= 6;
            Instantiate(Unit, point.position, point.rotation);
        }
    }
}
