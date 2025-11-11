using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class SpavnZoneUnit : MonoBehaviour
{
    public float xMax;
    public float zMin;
    public float zMax;

    [SerializeField] private RectTransform imRect;

    void Update()
    {
        float sizeY = zMax - zMin;
        float y = zMin + sizeY / 2f;
        imRect.localPosition = new Vector3(0f, y, 0f);

        imRect.sizeDelta = new Vector2(xMax / 2f, sizeY);
    }
}
