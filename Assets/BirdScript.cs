using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigibody;
    public float jumpForce = 10f;

    public LogicScript logicScript;
    public bool birdIsAlive = true;

    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic")
            .GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && birdIsAlive)
        {
            myRigibody.linearVelocity = new Vector2(0, jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        logicScript.gameOver();
        birdIsAlive = false;
    }
}
