using UnityEngine;

public class EvalOrder:  MonoBehaviour {
    void Awake() {
        Debug.Log("Awake");
    }

    void Start() {
        Debug.Log("Started");

    }

    //by frame
    void Update() {
        Debug.Log("Normal Update");
    }

    //by time
    void FixedUpdate() {
        Debug.Log("Fixed Update");
    }

    //Init
    //Physics
    //Input
    //Animation / State
    //Game Rendering
    
}