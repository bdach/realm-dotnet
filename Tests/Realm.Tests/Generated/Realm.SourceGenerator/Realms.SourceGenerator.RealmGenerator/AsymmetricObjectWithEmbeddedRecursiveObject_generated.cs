﻿// <auto-generated />
#nullable enable

using Baas;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using NUnit.Framework;
using Realms;
using Realms.Dynamic;
using Realms.Exceptions;
using Realms.Schema;
using Realms.Sync;
using Realms.Tests.Sync;
using Realms.Weaving;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TestAsymmetricObject = Realms.IAsymmetricObject;

namespace Realms.Tests.Sync
{
    [Generated]
    [Woven(typeof(AsymmetricObjectWithEmbeddedRecursiveObjectObjectHelper)), Realms.Preserve(AllMembers = true)]
    public partial class AsymmetricObjectWithEmbeddedRecursiveObject : IAsymmetricObject, INotifyPropertyChanged, IReflectableType
    {

        [Realms.Preserve]
        static AsymmetricObjectWithEmbeddedRecursiveObject()
        {
            Realms.Serialization.RealmObjectSerializer.Register(new AsymmetricObjectWithEmbeddedRecursiveObjectSerializer());
        }

        /// <summary>
        /// Defines the schema for the <see cref="AsymmetricObjectWithEmbeddedRecursiveObject"/> class.
        /// </summary>
        [System.Reflection.Obfuscation]
        public static Realms.Schema.ObjectSchema RealmSchema = new Realms.Schema.ObjectSchema.Builder("AsymmetricObjectWithEmbeddedRecursiveObject", ObjectSchema.ObjectType.AsymmetricObject)
        {
            Realms.Schema.Property.Primitive("_id", Realms.RealmValueType.ObjectId, isPrimaryKey: true, indexType: IndexType.None, isNullable: false, managedName: "Id"),
            Realms.Schema.Property.Object("RecursiveObject", "EmbeddedLevel1", managedName: "RecursiveObject"),
        }.Build();

        #region IAsymmetricObject implementation

        private IAsymmetricObjectWithEmbeddedRecursiveObjectAccessor? _accessor;

        Realms.IRealmAccessor Realms.IRealmObjectBase.Accessor => Accessor;

        private IAsymmetricObjectWithEmbeddedRecursiveObjectAccessor Accessor => _accessor ??= new AsymmetricObjectWithEmbeddedRecursiveObjectUnmanagedAccessor(typeof(AsymmetricObjectWithEmbeddedRecursiveObject));

        /// <inheritdoc />
        [IgnoreDataMember, XmlIgnore]
        public bool IsManaged => Accessor.IsManaged;

        /// <inheritdoc />
        [IgnoreDataMember, XmlIgnore]
        public bool IsValid => Accessor.IsValid;

        /// <inheritdoc />
        [IgnoreDataMember, XmlIgnore]
        public bool IsFrozen => Accessor.IsFrozen;

        /// <inheritdoc />
        [IgnoreDataMember, XmlIgnore]
        public Realms.Realm? Realm => Accessor.Realm;

        /// <inheritdoc />
        [IgnoreDataMember, XmlIgnore]
        public Realms.Schema.ObjectSchema ObjectSchema => Accessor.ObjectSchema!;

        /// <inheritdoc />
        [IgnoreDataMember, XmlIgnore]
        public Realms.DynamicObjectApi DynamicApi => Accessor.DynamicApi;

        /// <inheritdoc />
        [IgnoreDataMember, XmlIgnore]
        public int BacklinksCount => Accessor.BacklinksCount;

        void ISettableManagedAccessor.SetManagedAccessor(Realms.IRealmAccessor managedAccessor, Realms.Weaving.IRealmObjectHelper? helper, bool update, bool skipDefaults)
        {
            var newAccessor = (IAsymmetricObjectWithEmbeddedRecursiveObjectAccessor)managedAccessor;
            var oldAccessor = _accessor;
            _accessor = newAccessor;

            if (helper != null && oldAccessor != null)
            {
                if (!skipDefaults || oldAccessor.Id != default(MongoDB.Bson.ObjectId))
                {
                    newAccessor.Id = oldAccessor.Id;
                }
                newAccessor.RecursiveObject = oldAccessor.RecursiveObject;
            }

            if (_propertyChanged != null)
            {
                SubscribeForNotifications();
            }

            OnManaged();
        }

        #endregion

        /// <summary>
        /// Called when the object has been managed by a Realm.
        /// </summary>
        /// <remarks>
        /// This method will be called either when a managed object is materialized or when an unmanaged object has been
        /// added to the Realm. It can be useful for providing some initialization logic as when the constructor is invoked,
        /// it is not yet clear whether the object is managed or not.
        /// </remarks>
        partial void OnManaged();

        private event PropertyChangedEventHandler? _propertyChanged;

        /// <inheritdoc />
        public event PropertyChangedEventHandler? PropertyChanged
        {
            add
            {
                if (_propertyChanged == null)
                {
                    SubscribeForNotifications();
                }

                _propertyChanged += value;
            }

            remove
            {
                _propertyChanged -= value;

                if (_propertyChanged == null)
                {
                    UnsubscribeFromNotifications();
                }
            }
        }

        /// <summary>
        /// Called when a property has changed on this class.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <remarks>
        /// For this method to be called, you need to have first subscribed to <see cref="PropertyChanged"/>.
        /// This can be used to react to changes to the current object, e.g. raising <see cref="PropertyChanged"/> for computed properties.
        /// </remarks>
        /// <example>
        /// <code>
        /// class MyClass : IRealmObject
        /// {
        ///     public int StatusCodeRaw { get; set; }
        ///     public StatusCodeEnum StatusCode => (StatusCodeEnum)StatusCodeRaw;
        ///     partial void OnPropertyChanged(string propertyName)
        ///     {
        ///         if (propertyName == nameof(StatusCodeRaw))
        ///         {
        ///             RaisePropertyChanged(nameof(StatusCode));
        ///         }
        ///     }
        /// }
        /// </code>
        /// Here, we have a computed property that depends on a persisted one. In order to notify any <see cref="PropertyChanged"/>
        /// subscribers that <c>StatusCode</c> has changed, we implement <see cref="OnPropertyChanged"/> and
        /// raise <see cref="PropertyChanged"/> manually by calling <see cref="RaisePropertyChanged"/>.
        /// </example>
        partial void OnPropertyChanged(string? propertyName);

        private void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            _propertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            OnPropertyChanged(propertyName);
        }

        private void SubscribeForNotifications()
        {
            Accessor.SubscribeForNotifications(RaisePropertyChanged);
        }

        private void UnsubscribeFromNotifications()
        {
            Accessor.UnsubscribeFromNotifications();
        }

        /// <summary>
        /// Converts a <see cref="Realms.RealmValue"/> to <see cref="AsymmetricObjectWithEmbeddedRecursiveObject"/>. Equivalent to <see cref="Realms.RealmValue.AsNullableRealmObject{T}"/>.
        /// </summary>
        /// <param name="val">The <see cref="Realms.RealmValue"/> to convert.</param>
        /// <returns>The <see cref="AsymmetricObjectWithEmbeddedRecursiveObject"/> stored in the <see cref="Realms.RealmValue"/>.</returns>
        public static explicit operator AsymmetricObjectWithEmbeddedRecursiveObject?(Realms.RealmValue val) => val.Type == Realms.RealmValueType.Null ? null : val.AsRealmObject<AsymmetricObjectWithEmbeddedRecursiveObject>();

        /// <summary>
        /// Implicitly constructs a <see cref="Realms.RealmValue"/> from <see cref="AsymmetricObjectWithEmbeddedRecursiveObject"/>.
        /// </summary>
        /// <param name="val">The value to store in the <see cref="Realms.RealmValue"/>.</param>
        /// <returns>A <see cref="Realms.RealmValue"/> containing the supplied <paramref name="val"/>.</returns>
        public static implicit operator Realms.RealmValue(AsymmetricObjectWithEmbeddedRecursiveObject? val) => val == null ? Realms.RealmValue.Null : Realms.RealmValue.Object(val);

        /// <summary>
        /// Implicitly constructs a <see cref="Realms.QueryArgument"/> from <see cref="AsymmetricObjectWithEmbeddedRecursiveObject"/>.
        /// </summary>
        /// <param name="val">The value to store in the <see cref="Realms.QueryArgument"/>.</param>
        /// <returns>A <see cref="Realms.QueryArgument"/> containing the supplied <paramref name="val"/>.</returns>
        public static implicit operator Realms.QueryArgument(AsymmetricObjectWithEmbeddedRecursiveObject? val) => (Realms.RealmValue)val;

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public TypeInfo GetTypeInfo() => Accessor.GetTypeInfo(this);

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is InvalidObject)
            {
                return !IsValid;
            }

            if (!(obj is Realms.IRealmObjectBase iro))
            {
                return false;
            }

            return Accessor.Equals(iro.Accessor);
        }

        /// <inheritdoc />
        public override int GetHashCode() => IsManaged ? Accessor.GetHashCode() : base.GetHashCode();

        /// <inheritdoc />
        public override string? ToString() => Accessor.ToString();

        [EditorBrowsable(EditorBrowsableState.Never), Realms.Preserve(AllMembers = true)]
        private class AsymmetricObjectWithEmbeddedRecursiveObjectObjectHelper : Realms.Weaving.IRealmObjectHelper
        {
            public void CopyToRealm(Realms.IRealmObjectBase instance, bool update, bool skipDefaults)
            {
                throw new InvalidOperationException("This method should not be called for source generated classes.");
            }

            public Realms.ManagedAccessor CreateAccessor() => new AsymmetricObjectWithEmbeddedRecursiveObjectManagedAccessor();

            public Realms.IRealmObjectBase CreateInstance() => new AsymmetricObjectWithEmbeddedRecursiveObject();

            public bool TryGetPrimaryKeyValue(Realms.IRealmObjectBase instance, out RealmValue value)
            {
                value = ((IAsymmetricObjectWithEmbeddedRecursiveObjectAccessor)instance.Accessor).Id;
                return true;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), Realms.Preserve(AllMembers = true)]
        internal interface IAsymmetricObjectWithEmbeddedRecursiveObjectAccessor : Realms.IRealmAccessor
        {
            MongoDB.Bson.ObjectId Id { get; set; }

            Realms.Tests.EmbeddedLevel1? RecursiveObject { get; set; }
        }

        [EditorBrowsable(EditorBrowsableState.Never), Realms.Preserve(AllMembers = true)]
        private class AsymmetricObjectWithEmbeddedRecursiveObjectManagedAccessor : Realms.ManagedAccessor, IAsymmetricObjectWithEmbeddedRecursiveObjectAccessor
        {
            public MongoDB.Bson.ObjectId Id
            {
                get => (MongoDB.Bson.ObjectId)GetValue("_id");
                set => SetValueUnique("_id", value);
            }

            public Realms.Tests.EmbeddedLevel1? RecursiveObject
            {
                get => (Realms.Tests.EmbeddedLevel1?)GetValue("RecursiveObject");
                set => SetValue("RecursiveObject", value);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), Realms.Preserve(AllMembers = true)]
        private class AsymmetricObjectWithEmbeddedRecursiveObjectUnmanagedAccessor : Realms.UnmanagedAccessor, IAsymmetricObjectWithEmbeddedRecursiveObjectAccessor
        {
            public override ObjectSchema ObjectSchema => AsymmetricObjectWithEmbeddedRecursiveObject.RealmSchema;

            private MongoDB.Bson.ObjectId _id = ObjectId.GenerateNewId();
            public MongoDB.Bson.ObjectId Id
            {
                get => _id;
                set
                {
                    _id = value;
                    RaisePropertyChanged("Id");
                }
            }

            private Realms.Tests.EmbeddedLevel1? _recursiveObject;
            public Realms.Tests.EmbeddedLevel1? RecursiveObject
            {
                get => _recursiveObject;
                set
                {
                    _recursiveObject = value;
                    RaisePropertyChanged("RecursiveObject");
                }
            }

            public AsymmetricObjectWithEmbeddedRecursiveObjectUnmanagedAccessor(Type objectType) : base(objectType)
            {
            }

            public override Realms.RealmValue GetValue(string propertyName)
            {
                return propertyName switch
                {
                    "_id" => _id,
                    "RecursiveObject" => _recursiveObject,
                    _ => throw new MissingMemberException($"The object does not have a gettable Realm property with name {propertyName}"),
                };
            }

            public override void SetValue(string propertyName, Realms.RealmValue val)
            {
                switch (propertyName)
                {
                    case "_id":
                        throw new InvalidOperationException("Cannot set the value of a primary key property with SetValue. You need to use SetValueUnique");
                    case "RecursiveObject":
                        RecursiveObject = (Realms.Tests.EmbeddedLevel1?)val;
                        return;
                    default:
                        throw new MissingMemberException($"The object does not have a settable Realm property with name {propertyName}");
                }
            }

            public override void SetValueUnique(string propertyName, Realms.RealmValue val)
            {
                if (propertyName != "_id")
                {
                    throw new InvalidOperationException($"Cannot set the value of non primary key property ({propertyName}) with SetValueUnique");
                }

                Id = (MongoDB.Bson.ObjectId)val;
            }

            public override IList<T> GetListValue<T>(string propertyName)
            {
                throw new MissingMemberException($"The object does not have a Realm list property with name {propertyName}");
            }

            public override ISet<T> GetSetValue<T>(string propertyName)
            {
                throw new MissingMemberException($"The object does not have a Realm set property with name {propertyName}");
            }

            public override IDictionary<string, TValue> GetDictionaryValue<TValue>(string propertyName)
            {
                throw new MissingMemberException($"The object does not have a Realm dictionary property with name {propertyName}");
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), Realms.Preserve(AllMembers = true)]
        private class AsymmetricObjectWithEmbeddedRecursiveObjectSerializer : Realms.Serialization.RealmObjectSerializerBase<AsymmetricObjectWithEmbeddedRecursiveObject>
        {
            public override string SchemaName => "AsymmetricObjectWithEmbeddedRecursiveObject";

            protected override void SerializeValue(MongoDB.Bson.Serialization.BsonSerializationContext context, BsonSerializationArgs args, AsymmetricObjectWithEmbeddedRecursiveObject value)
            {
                context.Writer.WriteStartDocument();

                WriteValue(context, args, "_id", value.Id);
                WriteValue(context, args, "RecursiveObject", value.RecursiveObject);

                context.Writer.WriteEndDocument();
            }

            protected override AsymmetricObjectWithEmbeddedRecursiveObject CreateInstance() => new AsymmetricObjectWithEmbeddedRecursiveObject();

            protected override void ReadValue(AsymmetricObjectWithEmbeddedRecursiveObject instance, string name, BsonDeserializationContext context)
            {
                switch (name)
                {
                    case "_id":
                        instance.Id = BsonSerializer.LookupSerializer<MongoDB.Bson.ObjectId>().Deserialize(context);
                        break;
                    case "RecursiveObject":
                        instance.RecursiveObject = BsonSerializer.LookupSerializer<Realms.Tests.EmbeddedLevel1?>().Deserialize(context);
                        break;
                    default:
                        context.Reader.SkipValue();
                        break;
                }
            }

            protected override void ReadArrayElement(AsymmetricObjectWithEmbeddedRecursiveObject instance, string name, BsonDeserializationContext context)
            {
                // No persisted list/set properties to deserialize
            }

            protected override void ReadDocumentField(AsymmetricObjectWithEmbeddedRecursiveObject instance, string name, string fieldName, BsonDeserializationContext context)
            {
                // No persisted dictionary properties to deserialize
            }
        }
    }
}
