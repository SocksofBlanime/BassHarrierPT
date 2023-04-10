using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBeat : MonoBehaviour
{
    [Header("Behaviour Settings")]
    public Transform _target;
    private float _currentPosition;
    public float _leftPosition, _rightPosition;
    [Range(0.8f, 0.99f)]
    public float _shrinkFactor;
    [Header("Beat Settings")]
    [Range(0, 3)]
    public int _onFullBeat;
    [Range(0, 7)]
    public int[] _onBeatD8;
    private int _beatCountFull;

    // Start is called before the first frame update
    void Start()
    {
        if (_target == null)
        {
            _target = this.transform;
        }
        _currentPosition = _rightPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (_currentPosition > _rightPosition)
        {
            _currentPosition *= _shrinkFactor;
        }
        else
        {
            _currentPosition = _rightPosition;
        }
        CheckBeat();
        _target.localPosition = new Vector3(_currentPosition, _target.localPosition.y, _target.localPosition.z);
    }

    void Grow()
    {
        _currentPosition = _leftPosition;
    }

    void CheckBeat()
    {
        _beatCountFull = BPeerM._beatCountFull % 4;
        for (int i = 0; i < _onBeatD8.Length; i++)
        {
            if (BPeerM._beatD8 && _beatCountFull == _onFullBeat && BPeerM._beatCountD8 % 8 == _onBeatD8[i])
            {
                Grow();
            }
        }
    }
}
