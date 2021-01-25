using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OpenBagMenu : MonoBehaviour
{
    [SerializeField] private Button _Bag;
    [SerializeField] private GameObject _BagInterface;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = _Bag.GetComponent<Button>();
        btn.onClick.AddListener(OpenBag);
    }

    void OpenBag()
    {
        Instantiate(_BagInterface, new Vector2(0, 0), Quaternion.identity);
    }
}
