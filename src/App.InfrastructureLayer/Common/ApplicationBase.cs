using NLog;
using System;

namespace App.InfrastructureLayer.Common
{
    public class ApplicationBase
    {
        protected Logger Log { get; private set; }

        protected ApplicationBase(Type type)
        {
            Log = LogManager.GetLogger(type.FullName);
        }


        protected void LogDebug(string text)
        {
            Log.Debug(text);
        }

        protected void LogDebug(object o)
        {
            Log.Debug(o.ToString());
        }

        protected void LogTrace(object o)
        {
            Log.Trace(o.ToString());
        }

        protected void LogWarn(string text)
        {
            Log.Warn(text);
        }

        protected void LogWarn(object o)
        {
            Log.Warn(o.ToString());
        }

        protected void LogError(string text)
        {
            Log.Error(text);
        }

        protected void LogError(object o)
        {
            Log.Error(o.ToString());
        }
    }
}
