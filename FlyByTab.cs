using UnityEngine;

// Base class for flying behavior
public class FlyBehavior
{
    protected float speed;

    public FlyBehavior(float speed)
    {
        this.speed = speed;
    }

    public virtual void Fly(Transform transform, Transform cameraTransform)
    {
        Vector3 direction = cameraTransform.forward;
        transform.position += direction * speed * Time.deltaTime;
    }
}

// Class to handle disabling the collider
public class DisableCollider
{
    private Collider objectCollider;

    public DisableCollider(Collider collider)
    {
        objectCollider = collider;
    }

    public void Disable()
    {
        if (objectCollider != null)
        {
            objectCollider.enabled = false;
        }
    }
}

// Main MonoBehaviour class
public class FlyByTab : MonoBehaviour
{
    public float speed = 10f; // Speed of flying
    private FlyBehavior flyBehavior;
    private DisableCollider disableCollider;

    void Start()
    {
        // Initialize the fly behavior and disable collider
        flyBehavior = new FlyBehavior(speed);
        disableCollider = new DisableCollider(GetComponent<Collider>());

        // Disable the collider on start
        disableCollider.Disable();
    }

    void Update()
    {
        // Check if the Tab key is held down
        if (Input.GetKey(KeyCode.Tab))
        {
            // Get the forward direction of the camera and fly
            flyBehavior.Fly(transform, Camera.main.transform);
        }
    }
}
