using UnityEngine;

public class UnitPlacer : MonoBehaviour
{
    public GameObject unitPrefab;
    public LayerMask placementLayer;
    public GameObject spawnZone;
    public float price = 6f;
    private bool isPlacing = false;
    private GameObject currentUnit;
    

    void Update()
    {
        if (isPlacing && Input.GetMouseButtonDown(0) && AttackCount.AttackCoin >= price)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, placementLayer))
            {
                currentUnit = Instantiate(unitPrefab, hit.point, Quaternion.identity);
                AttackCount.AttackCoin -= price;
                StopPlacing();
            }
        }
    }

    public void StartPlacing()
    {
        isPlacing = true;
        spawnZone.SetActive(isPlacing);
    }

    private void StopPlacing()
    {
        isPlacing = false;
        spawnZone.SetActive(isPlacing);
    }
}