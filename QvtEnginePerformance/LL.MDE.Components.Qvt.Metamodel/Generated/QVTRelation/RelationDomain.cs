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
using LL.MDE.Components.Qvt.Metamodel.EssentialOCL;
using LL.MDE.Components.Qvt.Metamodel.QVTBase;
using LL.MDE.Components.Qvt.Metamodel.QVTTemplate;
using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace LL.MDE.Components.Qvt.Metamodel.QVTRelation
{
    
    
    /// <summary>
    /// The default implementation of the RelationDomain class
    /// </summary>
    [XmlNamespaceAttribute("http://www.omg.org/spec/QVT/20140401/QVTRelation")]
    [XmlNamespacePrefixAttribute("qvtrelation")]
    [ModelRepresentationClassAttribute("http://www.omg.org/spec/QVT/20140401/QVTRelation#//RelationDomain/")]
    [DebuggerDisplayAttribute("RelationDomain {Name}")]
    public class RelationDomain : Domain, IRelationDomain, IModelElement
    {
        
        /// <summary>
        /// The backing field for the DefaultAssignment property
        /// </summary>
        private RelationDomainDefaultAssignmentCollection _defaultAssignment;
        
        /// <summary>
        /// The backing field for the Pattern property
        /// </summary>
        private IDomainPattern _pattern;
        
        /// <summary>
        /// The backing field for the RootVariable property
        /// </summary>
        private IVariable _rootVariable;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        public RelationDomain()
        {
            this._defaultAssignment = new RelationDomainDefaultAssignmentCollection(this);
            this._defaultAssignment.CollectionChanging += this.DefaultAssignmentCollectionChanging;
            this._defaultAssignment.CollectionChanged += this.DefaultAssignmentCollectionChanged;
        }
        
        /// <summary>
        /// The defaultAssignment property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("defaultAssignment")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("owner")]
        [ConstantAttribute()]
        public virtual ISetExpression<IRelationDomainAssignment> DefaultAssignment
        {
            get
            {
                return this._defaultAssignment;
            }
        }
        
        /// <summary>
        /// The pattern property
        /// </summary>
        [XmlElementNameAttribute("pattern")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("relationDomain")]
        public virtual IDomainPattern Pattern
        {
            get
            {
                return this._pattern;
            }
            set
            {
                if ((this._pattern != value))
                {
                    this.OnPatternChanging(EventArgs.Empty);
                    this.OnPropertyChanging("Pattern");
                    IDomainPattern old = this._pattern;
                    this._pattern = value;
                    if ((old != null))
                    {
                        old.RelationDomain = null;
                        old.Parent = null;
                        old.Deleted -= this.OnResetPattern;
                    }
                    if ((value != null))
                    {
                        value.RelationDomain = this;
                        value.Parent = this;
                        value.Deleted += this.OnResetPattern;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPatternChanged(e);
                    this.OnPropertyChanged("Pattern", e);
                }
            }
        }
        
        /// <summary>
        /// The rootVariable property
        /// </summary>
        [XmlElementNameAttribute("rootVariable")]
        [XmlAttributeAttribute(true)]
        public virtual IVariable RootVariable
        {
            get
            {
                return this._rootVariable;
            }
            set
            {
                if ((this._rootVariable != value))
                {
                    this.OnRootVariableChanging(EventArgs.Empty);
                    this.OnPropertyChanging("RootVariable");
                    IVariable old = this._rootVariable;
                    this._rootVariable = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetRootVariable;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetRootVariable;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRootVariableChanged(e);
                    this.OnPropertyChanged("RootVariable", e);
                }
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new RelationDomainChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new RelationDomainReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/QVTRelation#//RelationDomain/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Pattern property changes its value
        /// </summary>
        public event EventHandler PatternChanging;
        
        /// <summary>
        /// Gets fired when the Pattern property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> PatternChanged;
        
        /// <summary>
        /// Gets fired before the RootVariable property changes its value
        /// </summary>
        public event EventHandler RootVariableChanging;
        
        /// <summary>
        /// Gets fired when the RootVariable property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> RootVariableChanged;
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the DefaultAssignment property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void DefaultAssignmentCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("DefaultAssignment", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the DefaultAssignment property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void DefaultAssignmentCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("DefaultAssignment", e);
        }
        
        /// <summary>
        /// Raises the PatternChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPatternChanging(EventArgs eventArgs)
        {
            EventHandler handler = this.PatternChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PatternChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPatternChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.PatternChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Pattern property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetPattern(object sender, System.EventArgs eventArgs)
        {
            this.Pattern = null;
        }
        
        /// <summary>
        /// Raises the RootVariableChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRootVariableChanging(EventArgs eventArgs)
        {
            EventHandler handler = this.RootVariableChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RootVariableChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRootVariableChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.RootVariableChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the RootVariable property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetRootVariable(object sender, System.EventArgs eventArgs)
        {
            this.RootVariable = null;
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            if ((element == this.Pattern))
            {
                return ModelHelper.CreatePath("Pattern");
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "PATTERN"))
            {
                return this.Pattern;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "DEFAULTASSIGNMENT"))
            {
                return this._defaultAssignment;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "PATTERN"))
            {
                this.Pattern = ((IDomainPattern)(value));
                return;
            }
            if ((feature == "ROOTVARIABLE"))
            {
                this.RootVariable = ((IVariable)(value));
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
            if ((attribute == "PATTERN"))
            {
                return new PatternProxy(this);
            }
            if ((attribute == "ROOTVARIABLE"))
            {
                return new RootVariableProxy(this);
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
            if ((reference == "PATTERN"))
            {
                return new PatternProxy(this);
            }
            if ((reference == "ROOTVARIABLE"))
            {
                return new RootVariableProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/QVTRelation#//RelationDomain/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the RelationDomain class
        /// </summary>
        public class RelationDomainChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private RelationDomain _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public RelationDomainChildrenCollection(RelationDomain parent)
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
                    count = (count + this._parent.DefaultAssignment.Count);
                    if ((this._parent.Pattern != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.DefaultAssignment.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.PatternChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.DefaultAssignment.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.PatternChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IRelationDomainAssignment defaultAssignmentCasted = item.As<IRelationDomainAssignment>();
                if ((defaultAssignmentCasted != null))
                {
                    this._parent.DefaultAssignment.Add(defaultAssignmentCasted);
                }
                if ((this._parent.Pattern == null))
                {
                    IDomainPattern patternCasted = item.As<IDomainPattern>();
                    if ((patternCasted != null))
                    {
                        this._parent.Pattern = patternCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.DefaultAssignment.Clear();
                this._parent.Pattern = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.DefaultAssignment.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.Pattern))
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
                IEnumerator<IModelElement> defaultAssignmentEnumerator = this._parent.DefaultAssignment.GetEnumerator();
                try
                {
                    for (
                    ; defaultAssignmentEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = defaultAssignmentEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    defaultAssignmentEnumerator.Dispose();
                }
                if ((this._parent.Pattern != null))
                {
                    array[arrayIndex] = this._parent.Pattern;
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
                IRelationDomainAssignment relationDomainAssignmentItem = item.As<IRelationDomainAssignment>();
                if (((relationDomainAssignmentItem != null) 
                            && this._parent.DefaultAssignment.Remove(relationDomainAssignmentItem)))
                {
                    return true;
                }
                if ((this._parent.Pattern == item))
                {
                    this._parent.Pattern = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.DefaultAssignment).Concat(this._parent.Pattern).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the RelationDomain class
        /// </summary>
        public class RelationDomainReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private RelationDomain _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public RelationDomainReferencedElementsCollection(RelationDomain parent)
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
                    count = (count + this._parent.DefaultAssignment.Count);
                    if ((this._parent.Pattern != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.RootVariable != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.DefaultAssignment.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.PatternChanged += this.PropagateValueChanges;
                this._parent.RootVariableChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.DefaultAssignment.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.PatternChanged -= this.PropagateValueChanges;
                this._parent.RootVariableChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IRelationDomainAssignment defaultAssignmentCasted = item.As<IRelationDomainAssignment>();
                if ((defaultAssignmentCasted != null))
                {
                    this._parent.DefaultAssignment.Add(defaultAssignmentCasted);
                }
                if ((this._parent.Pattern == null))
                {
                    IDomainPattern patternCasted = item.As<IDomainPattern>();
                    if ((patternCasted != null))
                    {
                        this._parent.Pattern = patternCasted;
                        return;
                    }
                }
                if ((this._parent.RootVariable == null))
                {
                    IVariable rootVariableCasted = item.As<IVariable>();
                    if ((rootVariableCasted != null))
                    {
                        this._parent.RootVariable = rootVariableCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.DefaultAssignment.Clear();
                this._parent.Pattern = null;
                this._parent.RootVariable = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.DefaultAssignment.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.Pattern))
                {
                    return true;
                }
                if ((item == this._parent.RootVariable))
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
                IEnumerator<IModelElement> defaultAssignmentEnumerator = this._parent.DefaultAssignment.GetEnumerator();
                try
                {
                    for (
                    ; defaultAssignmentEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = defaultAssignmentEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    defaultAssignmentEnumerator.Dispose();
                }
                if ((this._parent.Pattern != null))
                {
                    array[arrayIndex] = this._parent.Pattern;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.RootVariable != null))
                {
                    array[arrayIndex] = this._parent.RootVariable;
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
                IRelationDomainAssignment relationDomainAssignmentItem = item.As<IRelationDomainAssignment>();
                if (((relationDomainAssignmentItem != null) 
                            && this._parent.DefaultAssignment.Remove(relationDomainAssignmentItem)))
                {
                    return true;
                }
                if ((this._parent.Pattern == item))
                {
                    this._parent.Pattern = null;
                    return true;
                }
                if ((this._parent.RootVariable == item))
                {
                    this._parent.RootVariable = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.DefaultAssignment).Concat(this._parent.Pattern).Concat(this._parent.RootVariable).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the pattern property
        /// </summary>
        private sealed class PatternProxy : ModelPropertyChange<IRelationDomain, IDomainPattern>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PatternProxy(IRelationDomain modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IDomainPattern Value
            {
                get
                {
                    return this.ModelElement.Pattern;
                }
                set
                {
                    this.ModelElement.Pattern = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.PatternChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.PatternChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the rootVariable property
        /// </summary>
        private sealed class RootVariableProxy : ModelPropertyChange<IRelationDomain, IVariable>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RootVariableProxy(IRelationDomain modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IVariable Value
            {
                get
                {
                    return this.ModelElement.RootVariable;
                }
                set
                {
                    this.ModelElement.RootVariable = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RootVariableChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RootVariableChanged -= handler;
            }
        }
    }
}

