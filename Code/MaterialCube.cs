using UnityEngine;
using System.Collections.Generic;

public class CubeManager : MonoBehaviour
{
    public List<GameObject> cubes;

    void Start()
    {
        cubes.ForEach(MaterialFilterCube);
    }

    void MaterialFilterCube(GameObject cube)
    {
        var renderer = cube.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = Color.magenta;
        }
    }
}