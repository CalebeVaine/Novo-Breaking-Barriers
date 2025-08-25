using UnityEngine;

public class SpawnOnTouch : MonoBehaviour
{
    public GameObject objetoParaSpawnar; // O que ser� criado
    public Transform pontoDeSpawn;       // Onde ser� criado (opcional)

    private bool jaSpawnou = false;      // Evita m�ltiplos spawns

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!jaSpawnou && other.CompareTag("Player"))
        {
            // Define onde spawnar: no ponto indicado ou na posi��o do objeto
            Vector3 posicaoSpawn = pontoDeSpawn != null ? pontoDeSpawn.position : transform.position;

            Instantiate(objetoParaSpawnar, posicaoSpawn, Quaternion.identity);
            jaSpawnou = true;
        }
    }
}
