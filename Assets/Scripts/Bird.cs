using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;
    private Rigidbody2D rb;
    //[SerializeField] bool isDead = false;

    [SerializeField] private Score score; // Reference to the Score script
    [SerializeField] private GameObject ReplayBtn; // Reference to the Replay button

    void Start()
    {
        Time.timeScale = 1; // Start the game
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component
       // score = GetComponent<Score>(); // Get the Score component     
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Check if the player taps the screen
        {
            //  rb.AddForce(Vector2.up * _speed, ForceMode2D.Impulse); // Add an upward force to the bird
            rb.linearVelocity = Vector2.up * _speed; // Set the velocity of the bird to an upward direction 
        }               
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pipes")) // Check if the bird collides with the pipes
        {
            Debug.Log("score up"+score);
            score.ScoreUp(); // Call the ScoreUp method from the Score script
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Pipes")) // Check if the bird collides with the ground or the pipes
        {
            Time.timeScale = 0; // Time.timeScale is set to 0 // Time.timeScale is a value used to add slowmotion effect to the game
            ReplayBtn.SetActive(true); // Show the Replay button        
        }

        
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reload the current scene
        
    }
}
