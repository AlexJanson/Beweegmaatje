using UnityEngine;
using Beweegmaatje.Variables;

[CreateAssetMenu(fileName = "New trainer", menuName = "ScriptableObjects/Create new trainer")]
public class TrainerSetup : ScriptableObject
{
    [SerializeField] private string _trainerName = "Trainer Name";
    [SerializeField] private GameObject _character;
    [SerializeField] private Animator _animator;
    [SerializeField] private TextAsset _dialogue;

    public StringVariable playerName;

    public string name => _trainerName;
    public object character => _character;
    public Animator animator => _animator;
    public string dialogue => _dialogue.text
        .Replace("{name}", $"{playerName}");
}
