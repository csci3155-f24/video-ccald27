using UnityEngine;
class DataTypes {

    public int health;
    public string text;
    public bool isGrounded;
    public enum helped {};

    public RaycastHit hit;

    public GameObject obj;

    public Collider col;

    public float speed;

    public Rigidbody rb;
    public MeshCollider mesh;
    public LayerMask mask;

    public Transform transform;
    public Vector3 position;
    public Quaternion rotation;
    public Color color;
    public Material material;
    public AudioSource audioSource;
    public Animator animator;
    public Camera camera;
    public Light light;



    IIterator it;



}



interface IIterator {
    int Health { get; set; }
}