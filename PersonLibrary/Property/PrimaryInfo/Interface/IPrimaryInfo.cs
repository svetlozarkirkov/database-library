﻿namespace PersonLibrary.Property.PrimaryInfo.Interface
{
    using PersonLibrary.Property.Core.Interface;

    /// <summary>
    /// Interface IPrimaryInfo
    /// </summary>
    /// <seealso cref="PersonLibrary.Property.Core.Interface.IProperty" />
    public interface IPrimaryInfo : IProperty
    {
        /// <summary>
        /// Gets the first name.
        /// </summary>
        /// <value>The first name.</value>
        string FirstName { get; }

        /// <summary>
        /// Gets the middle name.
        /// </summary>
        /// <value>The middle name.</value>
        string MiddleName { get; }

        /// <summary>
        /// Gets the last name.
        /// </summary>
        /// <value>The last name.</value>
        string LastName { get; }

        /// <summary>
        /// Gets the egn.
        /// </summary>
        /// <value>The egn.</value>
        string Egn { get; }
    }
}