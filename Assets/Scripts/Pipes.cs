using UnityEngine;

public class Pipes : MonoBehaviour
{

    [SerializeField] private float _speed = 2f;
    [SerializeField] private float _Xmin = -5.4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * _speed );
        if(transform.position.x <= _Xmin)
        {
            Destroy(this.gameObject); //destroying the pipes if it goes out of the screen
        }
    }
}
