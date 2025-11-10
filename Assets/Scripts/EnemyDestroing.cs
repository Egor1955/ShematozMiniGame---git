using UnityEngine;

public class EnemyDestroing : MonoBehaviour
{
    public string targetTagToDestroy = "Enemy";

    private void OnTriggerEnter(Collider other)
    {
        HandleCollision(other.gameObject);
    }

    private void HandleCollision(GameObject otherObject)
    {
        if (otherObject.CompareTag(targetTagToDestroy))
        {
            Destroy(otherObject);
            Destroy(gameObject);
        }
    }
}
