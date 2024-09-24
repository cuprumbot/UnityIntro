using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    // Campos públicos pueden ser editados desde la interfaz de Unity
    public GameObject prefabToSpawn;

    public int numberOfCubes = 5;

    // Vector3 es la unidad básica para posiciones
    public Vector3 spawnAreaMin = new Vector3(-4, 3, -4);
    public Vector3 spawnAreaMax = new Vector3(4, 6, 4);

    // Los scripts tienen dos métodos básicos
    //      Start() al inicio
    //      Update() en cada frame
    void Start()
    {
        for (int i = 0; i < numberOfCubes; i++)
        {
            SpawnRedBouncyCube();
        }
    }

    void SpawnRedBouncyCube()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(spawnAreaMin.x, spawnAreaMax.x),
            Random.Range(spawnAreaMin.y, spawnAreaMax.y),
            Random.Range(spawnAreaMin.z, spawnAreaMax.z)
        );

        // Instantiate( prefab, position, rotation )
        // Quaternion es la unidad básica para rotaciones
        Instantiate(prefabToSpawn, randomPosition, Quaternion.identity);
    }
}
