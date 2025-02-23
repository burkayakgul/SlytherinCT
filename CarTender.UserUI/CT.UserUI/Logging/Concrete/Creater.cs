﻿using CT.UserUI.Logging.Abstract;
using CT.UserUI.Logging.Concrete.Loggers;

namespace CT.UserUI.Logging.Concrete
{
    public enum LoggerTypes
    {
        DbLogger,
        FileLogger
    }
    public class Creater
    {
        public AbstractLogger FactoryMethod(LoggerTypes type)
        {
            AbstractLogger logger = null;

            switch (type)
            {
                case LoggerTypes.DbLogger:
                    logger = new DbLogger(new LoggerManager());
                    break;
                case LoggerTypes.FileLogger:
                    logger = new FileLogger("CT_Logs.txt");
                    break;
            }

            return logger;
        }
    }
}