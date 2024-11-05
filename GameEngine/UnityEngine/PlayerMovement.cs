using UnityEngine;

[RequireComponent(typeof(CharacterController))] // Assegura que o CharacterController está presente
public class PlayerMovement : MonoBehaviour
{
    public float speed = 6.0f; // Velocidade de movimento do Player
    private CharacterController controller; // Referência ao CharacterController

    void Start()
    {
        // Obtém o componente CharacterController que está anexado ao Player
        //GetComponent significa "Pegar Componente"
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Obter entrada do usuário (teclas W, A, S, D)
        float horizontalInput = Input.GetAxis("Horizontal"); // Entrada para esquerda e direita
        float verticalInput = Input.GetAxis("Vertical");     // Entrada para frente e trás

        // Cria um vetor de direção com base na entrada
        Vector3 moveDirection = transform.right * horizontalInput + transform.forward * verticalInput;

        // Move o Player com o CharacterController
        controller.SimpleMove(moveDirection * speed);
    }
}
