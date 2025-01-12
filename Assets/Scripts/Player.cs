using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);

    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * _speed * Time.deltaTime;

        if (moveX != 0 || moveY != 0)
        {
            Debug.Log($"Moving: {moveX}, {moveY}");
        }

        transform.Translate(new Vector3(moveX, moveY, 0));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space pressed");
            PlantSeed();
        }
    }



    public void PlantSeed ()
    {
        if (_numSeedsLeft > 0)
        {
            Debug.Log("Planting seed...");
            Instantiate(_plantPrefab, transform.position, Quaternion.identity);
            _numSeedsLeft--;
            _numSeedsPlanted++;
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        }
        else
        {
            Debug.Log("No seeds left to plant!");
        }
    }
}

