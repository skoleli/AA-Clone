using UnityEngine;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance { get; private set; }

    [SerializeField] private List<LevelController> levelPrefabs;

    private int _index;
    private LevelController _current;

    private void Awake()
    {
        Instance = this;
    }

    public void OnStartLevel()
    {
        if (_current)
        {
            Destroy(_current.gameObject);
        }

        if (_index >= levelPrefabs.Count) return;
        var prefab = levelPrefabs[_index];
        _current = Instantiate(prefab);
        _current.MyStart(_index);
    }

    public void OnFinishLevel()
    {
        _index++;
        _current.Stop();
        GameManager.Instance.OnSuccess();
    }

    public bool IsLevelCompleted()
    {
        return BulletManager.Instance.bulletRemain == 0;
    }
}