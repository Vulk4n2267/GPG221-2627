using UnityEngine;

public class Wander : MonoBehaviour
{
    public float torqueStrength = 1f;
    private float randomOffset;

    public Rigidbody rb;

    void Start()
    {
   
        randomOffset = Random.Range(0f, 1000f);
    }

    void FixedUpdate()
    {
        float perlin = Mathf.PerlinNoise1D(Time.time + randomOffset);

        // Convert 0–1 to -1–1
        perlin = (perlin * 2f) - 1f;

        rb.AddRelativeTorque(0f, perlin * torqueStrength, 0f);
    }
}
