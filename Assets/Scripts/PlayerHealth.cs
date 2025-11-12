using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public GameObject player;
    public int xp = 3;
    public GameObject goose;
    public Image hp_img;

    void Start()
    {
        xp = 4;
        goose.SetActive(false);
    }
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {

            xp -= 1;
            Destroy(other.gameObject);
            if (xp <= 0)
            {
                goose.SetActive(true);
                Destroy(player);
            }
            hp_img.fillAmount = xp / 4f;
        }
    }
}