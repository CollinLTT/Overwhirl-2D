using UnityEngine;

public class CharControls : MonoBehaviour
{
    //sets default movement and jump force for character
    public float MovementSpeed = 700;
    public float JumpForce = 1000;
    private Rigidbody2D _rigidbody;

    //checks if its the first time spawning
    private int firstRun = 0;

    Animator anim;
    public RuntimeAnimatorController yinYang;
    public RuntimeAnimatorController peppermint;

    //grabs the rigidbody of the character and its animation
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        //checks for first run to slow down start
        if (firstRun < 3)
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
            firstRun++;
        }
        //moves the character at a constant rate to the right
        else
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * MovementSpeed;
        }

        //Jumps when pressing space
        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(_rigidbody.velocity.y) < 0.1f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

        //Checks if user has selected Peppermint pattern otherwise defaults with YinYang
        if (Singleton.instance.pattern == "Peppermint")
        {
            anim.runtimeAnimatorController = peppermint as RuntimeAnimatorController;

        }

    }

   
}


