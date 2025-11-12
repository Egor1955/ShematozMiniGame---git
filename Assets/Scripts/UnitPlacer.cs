using UnityEngine;

public class UnitPlacer : MonoBehaviour
{
    public GameObject unitPrefab;
    public LayerMask placementLayer;
    public GameObject spawnZone;
    private bool isPlacing = false;
    private GameObject currentUnit;

    void Update()
    {
        if (isPlacing && Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, placementLayer))
            {
                currentUnit = Instantiate(unitPrefab, hit.point, Quaternion.identity);
                StopPlacing();
            }
        }
    }

    public void StartPlacing()
    {
        isPlacing = true;
        spawn_zone.SetActive(isPlacing);
    }

    private void StopPlacing()
    {
        isPlacing = false;
        spawn_zone.SetActive(isPlacing);
    }
}