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
    /// The default implementation of the EnumLiteralExp class
    /// </summary>
    [XmlNamespaceAttribute("http://www.omg.org/spec/QVT/20140401/EssentialOCL")]
    [XmlNamespacePrefixAttribute("essentialocl")]
    [DebuggerDisplayAttribute("EnumLiteralExp {Name}")]
    public class EnumLiteralExp : LiteralExp, IEnumLiteralExp, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ReferredEnumLiteral property
        /// </summary>
        private IEnumerationLiteral _referredEnumLiteral;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// The referredEnumLiteral property
        /// </summary>
        [XmlElementNameAttribute("referredEnumLiteral")]
        [XmlAttributeAttribute(true)]
        public virtual IEnumerationLiteral ReferredEnumLiteral
        {
            get
            {
                return this._referredEnumLiteral;
            }
            set
            {
                if ((this._referredEnumLiteral != value))
                {
                    this.OnReferredEnumLiteralChanging(EventArgs.Empty);
                    this.OnPropertyChanging("ReferredEnumLiteral");
                    IEnumerationLiteral old = this._referredEnumLiteral;
                    this._referredEnumLiteral = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetReferredEnumLiteral;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetReferredEnumLiteral;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnReferredEnumLiteralChanged(e);
                    this.OnPropertyChanged("ReferredEnumLiteral", e);
                }
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new EnumLiteralExpReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets fired before the ReferredEnumLiteral property changes its value
        /// </summary>
        public event EventHandler ReferredEnumLiteralChanging;
        
        /// <summary>
        /// Gets fired when the ReferredEnumLiteral property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> ReferredEnumLiteralChanged;
        
        /// <summary>
        /// Raises the ReferredEnumLiteralChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReferredEnumLiteralChanging(EventArgs eventArgs)
        {
            EventHandler handler = this.ReferredEnumLiteralChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ReferredEnumLiteralChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReferredEnumLiteralChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.ReferredEnumLiteralChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ReferredEnumLiteral property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetReferredEnumLiteral(object sender, System.EventArgs eventArgs)
        {
            this.ReferredEnumLiteral = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "REFERREDENUMLITERAL"))
            {
                this.ReferredEnumLiteral = ((IEnumerationLiteral)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "REFERREDENUMLITERAL"))
            {
                return new ReferredEnumLiteralProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "REFERREDENUMLITERAL"))
            {
                return new ReferredEnumLiteralProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            throw new NotSupportedException();
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EnumLiteralExp class
        /// </summary>
        public class EnumLiteralExpReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EnumLiteralExp _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EnumLiteralExpReferencedElementsCollection(EnumLiteralExp parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.ReferredEnumLiteral != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ReferredEnumLiteralChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ReferredEnumLiteralChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ReferredEnumLiteral == null))
                {
                    IEnumerationLiteral referredEnumLiteralCasted = item.As<IEnumerationLiteral>();
                    if ((referredEnumLiteralCasted != null))
                    {
                        this._parent.ReferredEnumLiteral = referredEnumLiteralCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ReferredEnumLiteral = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ReferredEnumLiteral))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.ReferredEnumLiteral != null))
                {
                    array[arrayIndex] = this._parent.ReferredEnumLiteral;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.ReferredEnumLiteral == item))
                {
                    this._parent.ReferredEnumLiteral = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ReferredEnumLiteral).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the referredEnumLiteral property
        /// </summary>
        private sealed class ReferredEnumLiteralProxy : ModelPropertyChange<IEnumLiteralExp, IEnumerationLiteral>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ReferredEnumLiteralProxy(IEnumLiteralExp modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IEnumerationLiteral Value
            {
                get
                {
                    return this.ModelElement.ReferredEnumLiteral;
                }
                set
                {
                    this.ModelElement.ReferredEnumLiteral = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ReferredEnumLiteralChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ReferredEnumLiteralChanged -= handler;
            }
        }
    }
}

