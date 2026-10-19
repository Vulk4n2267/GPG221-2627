using Unity.VisualScripting;
using UnityEngine;

public class Avoid : MonoBehaviour
{
    public Rigidbody rb;
    public float turn;
    public float distance;
    LayerMask Default, NPCAvoid, Ground;

    void Start()
    {   //shoot rays
        //distance = distance * rb.linearVelocity.magnitude;
        bool hitSomething = Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, distance);
    }

    
    void Update()
    {   //if hit move to the right
        
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, distance))
        {
            rb.AddRelativeTorque(0, 3, 0);
        }
    }
 
}
