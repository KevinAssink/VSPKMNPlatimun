using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Button;

public class OpenBagMenu : MonoBehaviour
{
    [SerializeField] private Button _Bag;
    [SerializeField] private GameObject _BagInterface;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = _Bag.GetComponent<Button>();
        btn.OnClick.AddListener(OpenBag);
    }

    void OpenBag()
    {
        instantiate(_BagInterface, new Vector3(0, 0, 0));
    }
}
