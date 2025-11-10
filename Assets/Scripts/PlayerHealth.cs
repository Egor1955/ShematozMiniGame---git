using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject player;
    public int xp = 3;
    public GameObject goose;
    

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
        }
    }
}