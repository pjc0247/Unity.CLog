Unity.CLog
====
conditional logger

외 필요한가
----
유니티에서의 일반적인 로깅은 아래와 같은 형태를 가집니다.
```cs
Debug.Log("Player Level : " + player.level.ToString());
```
위 코드는 컴파일 될 경우 아래와 같은 바이트코드로 변환됩니다.
```MSIL
ldstr "Player Level : "
ldloc.0
ldflda int32 TestObject/Player::level
call instance string [mscorlib]System.Int32::ToString()
call string [mscorlib]System.String::Concat(string, string)
call void [UnityEngine]UnityEngine.Debug::Log(object)
```

CLog 를 사용하면
----
![a](log_enabled.png)<br>
![b](log_disabled.png)<br>
