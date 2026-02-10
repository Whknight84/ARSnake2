using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class MoveSnake : MonoBehaviour
{
    public float speed = 0.001f;
    Vector3 direction = Vector3.forward;
    bool isPlaying = false;
    [SerializeField] private ParticleSystem systemapple; 


   


    public void StartButton()
    {
        isPlaying = true;
        FindFirstObjectByType<SpawnApple>().AppleSpawn(); 
    }
    private void Update()
    {
        if (!isPlaying) return;
        transform.position += direction * speed; 
    }
    public void Up() { direction = Vector3.forward; }
    public void Down() { direction = Vector3.back; }
    public void Left() { direction = Vector3.left; }
    public void Right() { direction = Vector3.right; }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Apple"))
        {
            FindFirstObjectByType<SpawnApple>().AppleSpawn(); 
            Destroy(other.gameObject);
            speed += 0.001f;
      
        }
        if (other.CompareTag("Wall"))
        {

        }
            
    }
}

