using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.ObjectBuilder;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Configuration;
using System.Configuration;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.ObjectBuilder2;

namespace NEXCORE.Utility
{
    /// <summary>
    /// Represents the configuration data for a <see cref="ServiceFaultHandlerData"/>.
    /// </summary>	
    [Assembler(typeof(ServiceFaultHandlerAssembler))]
    public class ServiceFaultHandlerData : ExceptionHandlerData
    {
        private const string exceptionMessageProperty = "exceptionMessage";
        private const string detailExceptionTypeProperty = "detailsExceptionType";

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceFaultHandlerData"/> class.
        /// </summary>
        public ServiceFaultHandlerData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceFaultHandlerData"/> class with a name, an exception message, and the fully qualified assembly name of the type of the wrapping exception.
        /// </summary>
        /// <param name="name">
        /// The name of the <see cref="ServiceFaultHandlerData"/>.
        /// </param>
        /// <param name="exceptionMessage">
        /// The exception message replacement.
        /// </param>
        /// <param name="detailsExceptionType">
        /// The fully qualified assembly name of type of the wrapping exception
        /// </param>
        public ServiceFaultHandlerData(string name, string exceptionMessage, Type detailsExceptionType)
            : base(name, typeof(ServiceFaultHandler))
        {
            this.ExceptionMessage = exceptionMessage;
            this.DetailExceptionType = detailsExceptionType;
        }

        /// <summary>
        /// Gets or sets the message for the replacement exception.
        /// </summary>
        [ConfigurationProperty(exceptionMessageProperty, IsRequired = true)]
        public string ExceptionMessage
        {
            get { return (string)this[exceptionMessageProperty]; }
            set { this[exceptionMessageProperty] = value; }
        }

        /// <summary>
        /// Gets or sets the fully qualified type name of the replacement exception.
        /// </summary>
        [ConfigurationProperty(detailExceptionTypeProperty, IsRequired = true)]
        [TypeConverter(typeof(AssemblyQualifiedTypeNameConverter))]
        [SubclassTypeValidator(typeof(Exception))]
        public Type DetailExceptionType
        {
            get { return (Type)this[detailExceptionTypeProperty]; }
            set { this[detailExceptionTypeProperty] = value; }
        }
    }

    /// <summary>
    /// This type supports the Enterprise Library infrastructure and is not intended to be used directly from your code.
    /// Represents the process to build a <see cref="ServiceFaultHandler"/> described by a <see cref="ServiceFaultHandlerData"/> configuration object.
    /// </summary>
    /// <remarks>This type is linked to the <see cref="ServiceFaultHandlerData"/> type and it is used by the <see cref="ExceptionHandlerCustomFactory"/> 
    /// to build the specific <see cref="IExceptionHandler"/> object represented by the configuration object.
    /// </remarks>
    public class ServiceFaultHandlerAssembler : IAssembler<IExceptionHandler, ExceptionHandlerData>
    {
        /// <summary>
        /// This method supports the Enterprise Library infrastructure and is not intended to be used directly from your code.
        /// Builds a <see cref="ServiceFaultHandler"/> based on an instance of <see cref="WrapHandlerData"/>.
        /// </summary>
        /// <seealso cref="ExceptionHandlerCustomFactory"/>
        /// <param name="context">The <see cref="IBuilderContext"/> that represents the current building process.</param>
        /// <param name="objectConfiguration">The configuration object that describes the object to build. Must be an instance of <see cref="ServiceFaultHandlerData"/>.</param>
        /// <param name="configurationSource">The source for configuration objects.</param>
        /// <param name="reflectionCache">The cache to use retrieving reflection information.</param>
        /// <returns>A fully initialized instance of <see cref="ServiceFaultHandler"/>.</returns>
        public IExceptionHandler Assemble(IBuilderContext context, ExceptionHandlerData objectConfiguration, IConfigurationSource configurationSource, ConfigurationReflectionCache reflectionCache)
        {
            ServiceFaultHandlerData castedObjectConfiguration
                = (ServiceFaultHandlerData)objectConfiguration;

            ServiceFaultHandler createdObject
                = new ServiceFaultHandler(castedObjectConfiguration.ExceptionMessage, castedObjectConfiguration.DetailExceptionType);

            return createdObject;
        }
    }
}

