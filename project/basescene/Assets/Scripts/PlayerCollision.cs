
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovemoent movement;
    void OnCollisionEnter(Collision collisionInfo)   //碰撞期間會觸發
    {
        if (collisionInfo.collider.tag == "Obstacle")   //如果碰撞Obstacle標籤物體
        {
            movement.enabled = false;//關閉移動
            FindObjectOfType<GameManager>().EndGame();
        }
    }
        
    
}
