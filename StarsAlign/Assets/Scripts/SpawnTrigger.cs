// using UnityEngine;

// public class SpawnTrigger : MonoBehaviour
// {
//     public Transform spawnPoint; // Assign the desired spawn point in the Unity Editor

//     private void OnTriggerEnter2D(Collider2D collision)
//     {
//         if (collision.CompareTag("Player"))
//         {
//             PlayerCheckPointSystem PlayerCheckPointSystem = collision.GetComponent<PlayerCheckPointSystem>();
//             if (PlayerCheckPointSystem != null)
//             {
//                 PlayerCheckPointSystem.SetSpawnPosition(spawnPoint.position);
//             }
//         }
//     }
// }

