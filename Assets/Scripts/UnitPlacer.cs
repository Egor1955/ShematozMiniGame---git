using UnityEngine;

public class UnitPlacer : MonoBehaviour
{
    public GameObject unitPrefab;
    public LayerMask placementLayer;

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
        Debug.Log("Выберите место для юнита");
    }

    private void StopPlacing()
    {
        isPlacing = false;
        Debug.Log("Юнит размещен");
    }
}