using App.Infrastructure.Common;

namespace App.Infrastructure.Dto
{
    public class EmployeeDto
    {
        public EmployeeDto()
        {
            StaticLogger.LogInfo(GetType(), "Info created");
            StaticLogger.LogError(GetType(), "Error created");
            StaticLogger.LogWarn(GetType(), "Warn created");
            StaticLogger.LogTrace(GetType(), "Trace created");
            StaticLogger.LogFatal(GetType(), "Fatal created");
            StaticLogger.LogDebug(GetType(), "Debug created");
        }
    }
}
