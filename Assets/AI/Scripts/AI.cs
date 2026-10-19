using UnityEngine;

public class AI : MonoBehaviour
{   
    [SerializeField] float speed;
    [SerializeField] float force;
    public Rigidbody rb;
    void Start()

    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddRelativeForce(Vector3.forward*speed);
    }

    
 
}
