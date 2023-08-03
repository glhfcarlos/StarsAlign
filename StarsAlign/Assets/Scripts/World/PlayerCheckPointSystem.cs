using UnityEngine;

public class PlayerCheckPointSystem : MonoBehaviour
{
     private Vector3 startingPosition;
    private static Vector3 checkpointPosition;
    private bool hasReachedCheckpoint = false;

    private void Start()
    {
        startingPosition = transform.position;
        LoadCheckpoint();
    }

    private void LoadCheckpoint()
    {
        if (checkpointPosition != Vector3.zero)
        {
            transform.position = checkpointPosition;
            hasReachedCheckpoint = true;
        }
        else
        {
            transform.position = startingPosition;
        }
    }

    public void SetCheckpoint(Vector3 position)
    {
        if (!hasReachedCheckpoint)
        {
            checkpointPosition = position;
            hasReachedCheckpoint = true;
        }
    }

    public void ResetToCheckpoint()
    {
        if (hasReachedCheckpoint)
        {
            transform.position = checkpointPosition;
        }
        else
        {
            transform.position = startingPosition;
        }
    }

    public void ResetToStartingPosition()
    {
        transform.position = startingPosition;
    }
    public static void ResetCheckpointPosition()
{
    checkpointPosition = Vector3.zero; // Or you can set it to the starting position make sure to refrence it 
}

}


