using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject prefab;
    public GameObject specialPrefab; // Objeto diferente a ser instanciado a cada 5 objetos normais
    public float maxHeight;
    public float minHeight;
    public float maxTime = 0.5f;

    private float _timer;
    private int _spawnCount = 0; // Contador de objetos instanciados

    private void Start()
    {
        InstantiateObject();
    }

    private void Update()
    {
        if (_timer > maxTime)
        {
            InstantiateObject();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    private void InstantiateObject()
    {
        GameObject instance;

        // Verifica se é o momento de instanciar o objeto diferente
        if (_spawnCount > 0 && _spawnCount % 2 == 0)
        {
            instance = Instantiate(specialPrefab);
        }
        else
        {
            instance = Instantiate(prefab);
        }

        // Incrementa o contador de objetos instanciados
        _spawnCount++;

        // Define a posição do objeto instanciado
        float y = Random.Range(minHeight, maxHeight);
        instance.transform.position = transform.position + new Vector3(0, y, 0);

        // Destrói o objeto após 10 segundos
        Destroy(instance, 10f);
    }
}
