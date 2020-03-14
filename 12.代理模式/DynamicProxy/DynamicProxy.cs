using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Text;

namespace DynamicProxy
{
    public class DynamicProxy<T> : RealProxy
    {
        private readonly T _targetInstance = default(T);

        public DynamicProxy(T targetInstance)
            : base(typeof(T))
        {
            _targetInstance = targetInstance;
        }

        public override IMessage Invoke(IMessage msg)
        {
            var reqMsg = msg as IMethodCallMessage;

            if (reqMsg == null)
                return new ReturnMessage(new Exception("调用失败！"), null);

            var target = _targetInstance as MarshalByRefObject;

            if (target == null)
                return new ReturnMessage(new Exception("调用失败！目标对象必须继承自 System.MarshalByRefObject"), reqMsg);

            var methodName = reqMsg.MethodName;

            Console.WriteLine($"开始代理{methodName}，可以做点其他事情");
            var result = RemotingServices.ExecuteMessage(target, reqMsg);
            Console.WriteLine($"结束代理{methodName}，可以做点其他事情");

            return result;
        }
    }
}