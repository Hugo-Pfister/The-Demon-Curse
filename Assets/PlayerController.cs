using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // Vitesse de déplacement du joueur

    private Rigidbody playerRigidbody; // Référence au composant Rigidbody du joueur

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>(); // Récupération du composant Rigidbody attaché au joueur
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // Récupération de l'entrée horizontale de l'utilisateur
        float verticalInput = Input.GetAxis("Vertical"); // Récupération de l'entrée verticale de l'utilisateur

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime; // Calcul du vecteur de déplacement

        playerRigidbody.MovePosition(transform.position + movement); // Déplacement du joueur
    }

    private void Start ()
    {
        _rigidbody = GetComponent<Rigidbody>();
        -animator = GetComponent<Animator>();
    }

    private void Update()
    {
        var inputX:float = Input.GetAxisRaw("Horizontal");
        var jumpInput:bool = Input.GetButtonDown("Jump");
        var jumpInputReleased:bool = Input.GetButtonUp("Jump");

        _rigidbody.velocity = new Vector2(x:inputX * _movementVel, _rigidbody.velocity.y);

        if (jumpInput && IsGrounded())
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, y:_jumpVel);

        }

        If (jumpInputReleased && _rigidbody.velocity.y > 0);
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, y:0);
        }

        if (inputX != 0)
        {
            transform.localScale = new Vector3(x:Mathf.Sign(InputX), y:1, z:1);
        }
    } 

}
