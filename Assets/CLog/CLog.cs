using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class CLog
{
    public static ILogger logger
    {
        get { return UnityEngine.Debug.logger; }
    }

    [Conditional("ENABLE_CLOG_EXCEPTION")]
    public static void LogException(System.Exception e)
    {
        UnityEngine.Debug.LogException(e);
    } 
    [Conditional("ENABLE_CLOG_EXCEPTION")]
    public static void LogException(System.Exception e, Object obj)
    {
        UnityEngine.Debug.LogException(e, obj);
    }

    [Conditional("ENABLE_CLOG_NORMAL")]
    public static void Log(object msg)
    {
        UnityEngine.Debug.Log(msg);
    }
    [Conditional("ENABLE_CLOG_NORMAL")]
    public static void Log(object msg, Object obj)
    {
        UnityEngine.Debug.Log(msg, obj);
    }
    [Conditional("ENABLE_CLOG_ERROR")]
    public static void LogError(object msg)
    {
        UnityEngine.Debug.LogError(msg);
    }
    [Conditional("ENABLE_CLOG_ERROR")]
    public static void LogError(object msg, Object obj)
    {
        UnityEngine.Debug.LogError(msg, obj);
    }
    [Conditional("ENABLE_CLOG_WARNING")]
    public static void LogWarning(object msg)
    {
        UnityEngine.Debug.LogWarning(msg);
    }
    [Conditional("ENABLE_CLOG_WARNING")]
    public static void LogWarning(object msg, Object obj)
    {
        UnityEngine.Debug.LogWarning(msg, obj);
    }
    [Conditional("ENABLE_CLOG_ASSERTION")]
    public static void LogAssertion(object msg)
    {
        UnityEngine.Debug.LogAssertion(msg);
    }
    [Conditional("ENABLE_CLOG_ASSERTION")]
    public static void LogAssertion(object msg, Object obj)
    {
        UnityEngine.Debug.LogAssertion(msg, obj);
    }
}
