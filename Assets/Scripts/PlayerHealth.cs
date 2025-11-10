using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static int xp = 10;

    void Update()
    {
        if (xp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
