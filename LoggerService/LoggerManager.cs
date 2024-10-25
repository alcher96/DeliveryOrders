using Contracts;
using NLog;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace LoggerService;

public class LoggerManager : ILoggerManager
{
    private static Logger logger = LogManager.GetCurrentClassLogger();

    public LoggerManager()
    {
        
    }
    public void LogInfo(string message)
    {
        logger.Info(message);
    }

    public void LogWarning(string message)
    {
        logger.Warn(message);
    }

    public void LogError(string message)
    {
        logger.Error(message);
    }

    public void LogDebug(string message)
    {
        logger.Debug(message);
    }
}