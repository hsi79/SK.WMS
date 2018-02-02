using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using System.ServiceModel;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Configuration;
using System.Collections.Specialized;

namespace NEXCORE.Utility
{
    [ConfigurationElementType(typeof(CustomHandlerData))]
    public class ServiceFaultHandler : IExceptionHandler
    {
        private readonly string exceptionMessage;
        private readonly Type detailExceptionType;

        public ServiceFaultHandler(NameValueCollection ignore)
        {
        }

        public ServiceFaultHandler(string exceptionMessage, Type detailExceptionType)
        {
            if (detailExceptionType == null) throw new ArgumentNullException("detailExceptionType");
            if (!typeof(Exception).IsAssignableFrom(detailExceptionType))
            {
                throw new ArgumentException("This is not an exception type", "detailExceptionType");
            }

            this.exceptionMessage = exceptionMessage;
            this.detailExceptionType = detailExceptionType;
        }

        public Type DetailExceptionType
        {
            get { return detailExceptionType; }
        }

        public string DetailExceptionMessage
        {
            get { return exceptionMessage; }
        }

    
        public Exception HandleException(Exception exception, Guid handlingInstanceId)
        {
            return WrapException(
                exception,
                "");//ExceptionUtility.FormatExceptionMessage(DetailExceptionMessage, handlingInstanceId));
        }

        /// <summary>
        /// Wraps the original exception with FaultException.
        /// </summary>
        /// <param name="originalException"></param>
        /// <param name="detailsExceptionMessage"></param>
        /// <returns></returns>
        private Exception WrapException(Exception originalException, string detailsExceptionMessage)
        {
            // Create the detail exception
            object[] extraParameters = new object[] { detailsExceptionMessage };
            ServiceException se = new ServiceException();
            se.Test = "This, 이것도 가냐?";

            Exception detail = se;

            Type faultExceptionType = typeof(FaultException<>);
            Type faultBindedExceptionType = faultExceptionType.MakeGenericType(typeof(ServiceException));

            // Create a meaningful fault reason
            FaultReason reason = new FaultReason(originalException.Message);

            // Construct a new fualtException with generic type
            extraParameters = new object[] { detail, reason };
            Exception detail2 = (Exception)Activator.CreateInstance(faultBindedExceptionType, extraParameters);

            return detail2;
        }
    }
}
