using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
public class CubeEditor : MonoBehaviour
{
    [SerializeField] [Range(1f, 20f) ]float gridSize = 10f;

    TextMesh coordLabel;
    Vector3 snapPos;

    void Start()
    {
        coordLabel = GetComponentInChildren<TextMesh>();
    }

    void Update()
    {
        snapCubeToGrid();
        setCoordLabel();
        setGameObjectName();
    }

    void setCoordLabel()
    {
        coordLabel.text = snapPos.x / gridSize + "," + snapPos.z / gridSize;
    }

    void setGameObjectName()
    {
        gameObject.name = "Cube: (" + snapPos.x / gridSize + "," + snapPos.z / gridSize + ")";
    }

    void snapCubeToGrid()
    {
        snapPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;
        snapPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;
        transform.position = new Vector3(snapPos.x, 0f, snapPos.z);
    }
}