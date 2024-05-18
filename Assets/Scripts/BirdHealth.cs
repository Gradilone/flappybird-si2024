using UnityEngine;
using System.Collections;

public class BirdHealth : MonoBehaviour
{
   public GameManager gameManager;
    public float slowdownFactor = 0.5f; // Fator de desaceleração (0.5 significa metade da velocidade normal)
    public float slowdownDuration = 8f; // Duração da desaceleração em segundos

    private void Start()
    {
        var gameController = GameObject.FindGameObjectWithTag("GameController");
        gameManager = gameController.GetComponent<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se o objeto colidido tem a tag "tempo"
        if (collision.gameObject.CompareTag("time"))
        {
            Debug.Log("Objeto com tag 'tempo' detectado."); 
            Destroy(collision.gameObject);// Mensagem de depuração para verificar a tag
            StartCoroutine(SlowDownTime());
        }
        else
        {
            // Chama o método GameOver no GameManager
            gameManager.GameOver();
        }
    }

    private IEnumerator SlowDownTime()
    {
        Debug.Log("Iniciando desaceleração do tempo."); // Mensagem de depuração para iniciar a desaceleração

        // Desacelera o tempo
        Time.timeScale = slowdownFactor;
        // Ajusta a escala do tempo de física para manter a consistência
        Time.fixedDeltaTime = Time.timeScale * 0.02f;

        // Espera pela duração da desaceleração
        yield return new WaitForSecondsRealtime(slowdownDuration);

        // Restaura o tempo ao normal
        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.02f;

        Debug.Log("Tempo restaurado ao normal."); // Mensagem de depuração para restaurar o tempo
    }
}

    

