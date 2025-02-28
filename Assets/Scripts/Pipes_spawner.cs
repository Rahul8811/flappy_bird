using UnityEngine;

public class Pipes_spawner : MonoBehaviour
{
    [SerializeField] private GameObject SpawnPipesPrefab;
    [SerializeField] private float Ymin;
    [SerializeField] private float Ymax;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnColumn", 2f, 4f); //repeating the function to spawn the pipes //2f is the time to wait before the first execution //4f is the time to wait before the next execution 
    }

    // Update is called once per frame
    void Update()
    {
        
    }  

    void SpawnColumn()
    {
        float RandYpos = Random.Range(Ymin, Ymax); //setting the random position of the pipes at y axis
        Vector2 SpawnPosition = new Vector2(transform.position.x, RandYpos); //setting the position of the pipes
        Instantiate(SpawnPipesPrefab, SpawnPosition, Quaternion.identity); //spawning the pipes 
    }
}
