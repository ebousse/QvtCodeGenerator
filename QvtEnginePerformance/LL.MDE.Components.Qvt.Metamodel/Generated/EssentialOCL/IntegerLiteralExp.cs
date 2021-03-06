//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LL.MDE.Components.Qvt.Metamodel.EMOF;
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

namespace LL.MDE.Components.Qvt.Metamodel.EssentialOCL
{
    
    
    /// <summary>
    /// The default implementation of the IntegerLiteralExp class
    /// </summary>
    [XmlNamespaceAttribute("http://www.omg.org/spec/QVT/20140401/EssentialOCL")]
    [XmlNamespacePrefixAttribute("essentialocl")]
    [DebuggerDisplayAttribute("IntegerLiteralExp {Name}")]
    public class IntegerLiteralExp : NumericLiteralExp, IIntegerLiteralExp, IModelElement
    {
        
        /// <summary>
        /// The backing field for the IntegerSymbol property
        /// </summary>
        private Nullable<int> _integerSymbol;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// The integerSymbol property
        /// </summary>
        [XmlElementNameAttribute("integerSymbol")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<int> IntegerSymbol
        {
            get
            {
                return this._integerSymbol;
            }
            set
            {
                if ((this._integerSymbol != value))
                {
                    this.OnIntegerSymbolChanging(EventArgs.Empty);
                    this.OnPropertyChanging("IntegerSymbol");
                    Nullable<int> old = this._integerSymbol;
                    this._integerSymbol = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIntegerSymbolChanged(e);
                    this.OnPropertyChanged("IntegerSymbol", e);
                }
            }
        }
        
        /// <summary>
        /// Gets fired before the IntegerSymbol property changes its value
        /// </summary>
        public event EventHandler IntegerSymbolChanging;
        
        /// <summary>
        /// Gets fired when the IntegerSymbol property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> IntegerSymbolChanged;
        
        /// <summary>
        /// Raises the IntegerSymbolChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIntegerSymbolChanging(EventArgs eventArgs)
        {
            EventHandler handler = this.IntegerSymbolChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IntegerSymbolChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIntegerSymbolChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.IntegerSymbolChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "INTEGERSYMBOL"))
            {
                return this.IntegerSymbol;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "INTEGERSYMBOL"))
            {
                this.IntegerSymbol = ((int)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            throw new NotSupportedException();
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the integerSymbol property
        /// </summary>
        private sealed class IntegerSymbolProxy : ModelPropertyChange<IIntegerLiteralExp, Nullable<int>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IntegerSymbolProxy(IIntegerLiteralExp modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<int> Value
            {
                get
                {
                    return this.ModelElement.IntegerSymbol;
                }
                set
                {
                    this.ModelElement.IntegerSymbol = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IntegerSymbolChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IntegerSymbolChanged -= handler;
            }
        }
    }
}

