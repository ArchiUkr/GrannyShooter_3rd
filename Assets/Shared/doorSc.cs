using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorSc : MonoBehaviour
{
    private bool _isOpened;
    [SerializeField] private Animator _animator;

    

    // Update is called once per frame
   public void OpenDoor()
    {
        _animator.SetBool("isOpened", _isOpened);
        _isOpened = !_isOpened;
    }

    


}
