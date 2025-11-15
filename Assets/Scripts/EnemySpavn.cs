using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpavn : MonoBehaviour
{
    public GameObject[] itemsToSpawn;
    public float spawnRadius = 10.0f;
    public int maxItems = 10;
    public float spawnInterval = 1.0f;

    private float _timeSinceLastSpawn = 0.0f;

    void Update()
    {
        // ��������� ����� � ������� ���������� ���������
        _timeSinceLastSpawn += Time.deltaTime;

        // ���� ������ ����� ������� ����� �������
        if (_timeSinceLastSpawn >= spawnInterval)
        {
            // �������� ����� � ������� ���������� ���������
            _timeSinceLastSpawn = 0.0f;

            // �������� ��������� ������� � �������� ������� ���������
            Vector3 randomPosition = transform.position + new Vector3(UnityEngine.Random.insideUnitSphere.x, 0.0f, UnityEngine.Random.insideUnitSphere.z) * spawnRadius;

            // ������� ����� ������� � ���� �������
            GameObject item = Instantiate(itemsToSpawn[UnityEngine.Random.Range(0, itemsToSpawn.Length)], randomPosition, Quaternion.identity);
        }
    }

    /*void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, spawnRadius);
    }*/
}
