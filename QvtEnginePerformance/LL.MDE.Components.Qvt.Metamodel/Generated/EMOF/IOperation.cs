//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace LL.MDE.Components.Qvt.Metamodel.EMOF
{
    
    
    /// <summary>
    /// The public interface for Operation
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Operation))]
    [XmlDefaultImplementationTypeAttribute(typeof(Operation))]
    public interface IOperation : IModelElement, IMultiplicityElement, ITypedElement
    {
        
        /// <summary>
        /// The class property
        /// </summary>
        LL.MDE.Components.Qvt.Metamodel.EMOF.IClass Class
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ownedParameter property
        /// </summary>
        IOrderedSetExpression<IParameter> OwnedParameter
        {
            get;
        }
        
        /// <summary>
        /// The raisedException property
        /// </summary>
        ISetExpression<IType> RaisedException
        {
            get;
        }
        
        /// <summary>
        /// Gets fired when the Class property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ClassChanged;
    }
}
