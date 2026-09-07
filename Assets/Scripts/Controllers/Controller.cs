using UnityEngine;

public abstract class Controller : MonoBehaviour
{
    public Pawn pawn;
    public abstract void Start();
    public abstract void Update();
}