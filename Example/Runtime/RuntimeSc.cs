using UnityEngine;

namespace Assets.Example.Runtime
{
    public class RuntimeSc : MonoBehaviour
    {
        private float _timer = 0f;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Game start.");
        }

        void Update()
        {
            _timer += Time.deltaTime;
            if (_timer >= 5f)
            {
                Debug.Log("Spends 5 seconds of execution");
                _timer = 0f;
            }

        }
        
    }

}