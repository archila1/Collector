using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle1;

    Vector2 paddleToBallVector;
    bool isLaunched = false;
    [SerializeField] AudioClip[] ballSounds;
    [SerializeField] float randomFactor = 0.2f;
    AudioSource myAudioSource;
    Rigidbody2D myRigidBody;
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        myRigidBody = GetComponent<Rigidbody2D>();
        paddleToBallVector = transform.position - paddle1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLaunched)
        {
            BallToPaddle();
            LaunchBall();
        }
    }

    private void LaunchBall()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isLaunched = true;
            myRigidBody.velocity = new Vector2(2f, 15f);
        }
    }

    private void BallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddleToBallVector + paddlePos;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 velocityTweak = new Vector2(Random.Range(0, randomFactor), Random.Range(0, randomFactor));
        AudioClip clip = ballSounds[UnityEngine.Random.Range(0, ballSounds.Length)];
        myAudioSource.PlayOneShot(clip);
        myRigidBody.velocity += velocityTweak;
    }

}
