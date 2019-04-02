using NLog;
using System;

namespace App.InfrastructureLayer.Common
{
    public static class StaticLogger
    {
        public static void LogInfo(Type type, string text)
        {
            LogManager.GetLogger(type.FullName).Info(text);
        }

        public static void LogWarn(Type type, string text)
        {
            LogManager.GetLogger(type.FullName).Warn(text);
        }

        public static void LogDebug(Type type, string text)
        {
            LogManager.GetLogger(type.FullName).Debug(text);
        }

        public static void LogTrace(Type type, string text)
        {
            LogManager.GetLogger(type.FullName).Trace(text);
        }

        public static void LogError(Type type, string text)
        {
            LogManager.GetLogger(type.FullName).Error(text);
        }

        public static void LogFatal(Type type, string text)
        {
            LogManager.GetLogger(type.FullName).Fatal(text);
        }
    }
}
