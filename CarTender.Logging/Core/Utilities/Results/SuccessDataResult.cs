﻿using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T> where T : class
    {
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {
        }

        public SuccessDataResult(T data) : base(data,true)
        {

        }

        public SuccessDataResult(string message) : base(data:default,true,message)
        {

        }

        public SuccessDataResult() : base(data:default,true)
        {

        }
    }
}
