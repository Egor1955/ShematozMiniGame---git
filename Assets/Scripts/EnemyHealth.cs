using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int xpEN = 3;
    public GameObject panelWin;

    void Start()
    {
        xpEN = 3;
        panelWin.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Unit"))
        {
            xpEN -= 1;
            Destroy(other.gameObject);
            if (xpEN <= 0)
            {
                panelWin.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
}
