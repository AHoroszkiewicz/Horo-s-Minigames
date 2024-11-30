using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "GameCardSO", menuName = "Scriptable Objects/GameCardSO")]
public class GameCardSO : ScriptableObject
{
    [SerializeField] private string gameName;
    [SerializeField] private string gameDescription;
    [SerializeField] private Scene gameScene;
    [SerializeField] private int titleSize;
    [SerializeField] private int dscSize;

    public string GameName => gameName;
    public string GameDescription => gameDescription;
    public Scene GameScene => gameScene;
    public int TitleSize => titleSize;
    public int DscSize => dscSize;
}