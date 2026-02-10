using UnityEngine;

public class SpawnApple : MonoBehaviour
{
    [SerializeField] private GameObject apple;
    [SerializeField] private float range = 0.4f;

    public void AppleSpawn()
    {
        Vector3 pos = new Vector3(Random.Range(-range, range), 0.02f, Random.Range(-range, range));
        Instantiate(apple, transform.position + pos, transform.rotation);
        FindFirstObjectByType<SnakeButtons>().speed();
    }
}
