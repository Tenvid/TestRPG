using UnityEngine;
using UnityEngine.InputSystem;

public class Test_Battle : MonoBehaviour
{
    private int _index = 0;
    [SerializeField] private int _enemyId = 0;
    private BattleMode _battleState = BattleMode.SELECT;

    [SerializeField] private GameObject _battleOptionsArrow;
    [SerializeField] private GameObject _enemyCursor;
    [SerializeField] private static Enemy[] _enemies = new Enemy[5];

    GameObject _selectedEnemy = null;

    public static Enemy[] Enemies
    {
        get
        {
            return _enemies;
        }
    }

    enum BattleMode
    {
        SELECT = 0,
        FIGHT = 1,
        ITEMS = 2,
    }

    public void OnAccept(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            switch (_index)
            {
                case 0:
                    Debug.Log("Fight");
                    _battleState = BattleMode.FIGHT;
                    _selectedEnemy = _enemies[_enemyId++].gameObject;

                    if (!_enemyCursor.activeInHierarchy)
                        _enemyCursor.SetActive(true);

                    _enemyCursor.GetComponent<ArrowEnemySelector>().Move(-1, ref _enemyId);
                    break;
                case 1:
                    Debug.Log("Items");
                    break;
                case 2:
                    Debug.Log("Run");
                    break;
                default:
                    throw new System.Exception("Unexpected index");
            }
        }
    }

    public void OnReturn(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _battleState = BattleMode.SELECT;
            _enemyCursor.SetActive(false);
        }
    }

    public void OnMoveUI(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (_battleState == BattleMode.SELECT)
            {
                _battleOptionsArrow.GetComponent<ArrowBattleOption>().Move(Mathf.Sign(context.ReadValue<float>()), ref _index);
            }
            else if (_battleState == BattleMode.FIGHT)
            {
                _enemyCursor.GetComponent<ArrowEnemySelector>().Move(Mathf.Sign(context.ReadValue<float>()), ref _enemyId);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _enemies = FindObjectsOfType<Enemy>();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
