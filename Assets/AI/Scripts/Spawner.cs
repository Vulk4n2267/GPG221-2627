using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject AI;
    void Start()
    {
        StartCoroutine(SpawnAI());
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    IEnumerator SpawnAI()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(AI, transform.position, Quaternion.identity);

            yield return new WaitForSeconds(2f);
        }
    }
}
