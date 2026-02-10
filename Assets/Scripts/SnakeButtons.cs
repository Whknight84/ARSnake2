using TMPro;
using UnityEngine;

public class SnakeButtons : MonoBehaviour
{
    MoveSnake snake;
    [SerializeField] TextMeshProUGUI textspeed; 
    void FindSnake()
    {
        if (snake == null)
            snake = FindFirstObjectByType<MoveSnake>();
    }
    public void StartGame()
    {
        FindSnake();
        snake?.StartButton(); 
    }
    public void Up()
    {
        FindSnake();
        snake.Up(); 
    }
    public void Down()
    {
        FindSnake();
        snake.Down();
    }
    public void Left()
    {
        FindSnake();
        snake.Left();
    }
    public void Right()
    {
        FindSnake();
        snake.Right();
    }
    public void speed()
    {
        textspeed.text = "Скорость" + FindFirstObjectByType<MoveSnake>().speed.ToString(); 
    }
}
