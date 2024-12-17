using UnityEngine;

public class CubeMover : MonoBehaviour
{
    public GameObject cube;

    void FixedUpdate()
    {
        //callback
        MoveCube((cube) => cube.transform.position += new Vector3(0.05f, 0, 0));
    }

    //action (function) parameter
    void MoveCube(System.Action<GameObject> move)
    {
        move(cube);
    }
}