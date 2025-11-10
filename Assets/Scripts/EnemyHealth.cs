using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public static int xpEN = 10;

    void Update()
    {
        if (xpEN <= 0)
        {
            Destroy(gameObject);
        }
    }
}
