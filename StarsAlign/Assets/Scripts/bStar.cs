using UnityEngine;

public class bStar : MonoBehaviour
{
    public BalanceGame balanceGame; // Reference to the BalanceGame

    private void OnMouseDown()
    {
        balanceGame.RemoveStar(gameObject);
    }
}

