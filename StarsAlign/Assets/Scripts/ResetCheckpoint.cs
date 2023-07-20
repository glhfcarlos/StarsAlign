using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetCheckpoint : MonoBehaviour
{
    public void ResetAllCheckpoints()
    {
        // Reset the static checkpoint position in the PlayerCheckPointSystem script
        PlayerCheckPointSystem.ResetCheckpointPosition();

        // Load the first scene of the game 
        SceneManager.LoadScene(1);
    }
}

