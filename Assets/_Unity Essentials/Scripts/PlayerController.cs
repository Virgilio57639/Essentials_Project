usando UnityEngine;

// Controla o movimento e a rotação do jogador.
classe pública PlayerController: MonoBehaviour
{
    public float speed = 5.0f; // Define a velocidade de movimento do jogador.
public float rotationSpeed ​​= 120.0f; // Define a velocidade de rotação do jogador.

private Rigidbody rb; // Referência ao Rigidbody do jogador.

// Start é chamado antes da atualização do primeiro quadro
privado vazio Iniciar()
    {
        rb = GetComponent<Rigidbody>(); // Acessar o Rigidbody do jogador.
    }

    // A atualização é chamada uma vez por quadro
    Atualização vazia()
{

}


// Lidar com movimento e rotação baseados em física.
privado void FixedUpdate()
    {
        // Mover o jogador com base na entrada vertical.
        float moveVertical = Entrada.GetAxis("Vertical");
Movimento Vector3 = transform.forward * moveVertical * speed * Time.fixedDeltaTime;
rb.MovePosition(rb.position + movimento);

// Girar o jogador com base na entrada horizontal.
float turn = Input.GetAxis("Horizontal") * rotaçãoSpeed ​​* Tempo.fixedDeltaTime;
Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
rb.MoveRotation(rb.rotação * turnRotation);
    }
}
