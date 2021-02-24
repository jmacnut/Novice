using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.ASL
{
    public class ASL : MonoBehaviour
    {
       [SerializeField] private string _age;
       [SerializeField] private string _gender;
       [SerializeField] private string _location;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Age: " + _age + ", Gender: " + _gender + ", Location: " + _location);
            }
        }
    }
}
