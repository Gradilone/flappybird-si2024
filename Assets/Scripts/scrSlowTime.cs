using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrSlowTime : MonoBehaviour
{
    //  public float slowdownFactor = 0.2f; // Fator de desaceleração (0.5 significa metade da velocidade normal)
    // public float slowdownDuration = 4f; // Duração da desaceleração em segundos

    // private void OnTriggerEnter(Collider other)
    // {
    //     Debug.Log("Colisão detectada com: " + other.name);
    //     if (other.CompareTag("time"))
    //     {
    //         Debug.Log("Slow");
    //         StartCoroutine(SlowDownTime());
    //     }
    // }

    // private IEnumerator SlowDownTime()
    // {
    //     // Desacelera o tempo
    //     Time.timeScale = slowdownFactor;
    //     // Ajusta a escala do tempo de física para manter a consistência
    //     Time.fixedDeltaTime = Time.timeScale * 0.02f;

    //     // Espera pela duração da desaceleração
    //     yield return new WaitForSecondsRealtime(slowdownDuration);

    //     // Restaura o tempo ao normal
    //     Time.timeScale = 1f;
    //     Time.fixedDeltaTime = 0.02f;
    // }
}
