using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    // 変数を作る == 変数の宣言
    // 「変数」はクラスブロックの中 かつ メソッドの外に作る
    public float moveSpeedX = 0.1f;
    public float moveSpeedY = 0.0f;
    public float moveSpeedZ = 0.0f;
    public float rotateSpeedX = 0.0f;
    public float rotateSpeedY = 0.0f;
    public float rotateSpeedZ = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // このスクリプトを装備しているオブジェクトを操作する
        // transform.Translate( 動かす方向 *Vector3 )
        transform.Translate( 0.1f, 0, 0 );
    }

    // Update is called once per frame
    void Update()
    {
        // 条件分岐でのフロー制御
        if ( Keyboard.current.spaceKey.IsPressed( ) == true )
        {
            transform.Translate(moveSpeedX, moveSpeedY, moveSpeedZ);
            transform.Rotate(rotateSpeedX, rotateSpeedY, rotateSpeedZ);
        }
    }
}
