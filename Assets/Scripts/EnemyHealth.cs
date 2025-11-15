using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int xpEN = 3;
    public GameObject panelWin;
    public GameObject panelFail;
    public Image hp_imgEN;

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
                if (!panelFail.activeSelf) panelWin.SetActive(true);
                Destroy(gameObject);
            }
            hp_imgEN.fillAmount = xpEN/ 3f;
        }
    }
}
