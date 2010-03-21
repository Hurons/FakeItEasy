namespace FakeItEasy.Core.Creation
{
    using System;

    /// <summary>
    /// A facade used by the public api for testability.
    /// </summary>
    internal interface IFakeCreator
    {
        /// <summary>
        /// Creates a fake object of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of fake to create.</typeparam>
        /// <param name="options">Options for the created fake object.</param>
        /// <returns>The created fake object.</returns>
        /// <exception cref="FakeCreationException">Was unable to generate the fake in the current configuration.</exception>
        T CreateFake<T>(Action<IFakeOptionsBuilder<T>> options);

        /// <summary>
        /// Creates a dummy object, this can be a fake object or an object resolved
        /// from the current IFakeObjectContainer.
        /// </summary>
        /// <typeparam name="T">The type of dummy to create.</typeparam>
        /// <returns>The created dummy.</returns>
        /// <exception cref="FakeCreationException">Was unable to generate the fake in the current configuration and
        /// no dummy was registered in the container for the specifed type..</exception>
        T CreateDummy<T>();
    }
}