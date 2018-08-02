﻿using System;
using System.Collections.Generic;
using Generated.Improbable.Gdk.Tests.BlittableTypes;
using Improbable.Gdk.Core.GameObjectRepresentation;
using Improbable.Gdk.Core.MonoBehaviours;
using JetBrains.Annotations;
using NUnit.Framework;
using Unity.Entities;
using UnityEngine;
using Entity = Unity.Entities.Entity;

namespace Improbable.Gdk.Core.EditmodeTests.MonoBehaviours.Readers
{
    public abstract class ReaderWriterTestsBase
    {
        internal class SpatialOSBlittableComponentReader : BlittableReaderBase<SpatialOSBlittableComponent,
            SpatialOSBlittableComponent.Update>
        {
            internal SpatialOSBlittableComponentReader(Entity entity,
                EntityManager entityManager,
                ILogDispatcher logDispatcher)
                : base(entity, entityManager, logDispatcher)
            {
            }

            private readonly List<Action<BlittableBool>> boolFieldDelegates = new List<Action<BlittableBool>>();

            [UsedImplicitly]
            public event Action<BlittableBool> BoolFieldUpdated
            {
                add => boolFieldDelegates.Add(value);
                remove => boolFieldDelegates.Remove(value);
            }

            private readonly List<Action<int>> intFieldDelegates = new List<Action<int>>();

            [UsedImplicitly]
            public event Action<int> IntFieldUpdated
            {
                add => intFieldDelegates.Add(value);
                remove => intFieldDelegates.Remove(value);
            }

            private readonly List<Action<long>> longFieldDelegates = new List<Action<long>>();

            [UsedImplicitly]
            public event Action<long> LongFieldUpdated
            {
                add => longFieldDelegates.Add(value);
                remove => longFieldDelegates.Remove(value);
            }

            private readonly List<Action<float>> floatFieldDelegates = new List<Action<float>>();

            [UsedImplicitly]
            public event Action<float> FloatFieldUpdated
            {
                add => floatFieldDelegates.Add(value);
                remove => floatFieldDelegates.Remove(value);
            }

            private readonly List<Action<double>> doubleFieldDelegates = new List<Action<double>>();

            [UsedImplicitly]
            public event Action<double> DoubleFieldUpdated
            {
                add => doubleFieldDelegates.Add(value);
                remove => doubleFieldDelegates.Remove(value);
            }

            protected override void HandleFieldUpdates(SpatialOSBlittableComponent.Update update)
            {
                DispatchWithErrorHandling(update.BoolField, boolFieldDelegates);
                DispatchWithErrorHandling(update.IntField, intFieldDelegates);
                DispatchWithErrorHandling(update.LongField, longFieldDelegates);
                DispatchWithErrorHandling(update.FloatField, floatFieldDelegates);
                DispatchWithErrorHandling(update.DoubleField, doubleFieldDelegates);
            }
        }

        protected struct SomeOtherComponent : IComponentData
        {
        }

        private World world;
        protected EntityManager EntityManager;
        protected Entity Entity;
        internal SpatialOSBlittableComponentReader Reader;

        [SetUp]
        public void SetUp()
        {
            world = new World("test-world");

            EntityManager = world.GetOrCreateManager<EntityManager>();

            Entity = EntityManager.CreateEntity(typeof(SpatialOSBlittableComponent));

            Reader = new SpatialOSBlittableComponentReader(Entity, EntityManager, new LoggingDispatcher());
        }

        [TearDown]
        public void TearDown()
        {
            world.Dispose();
        }
    }
}
