﻿// <copyright file="ImageExtensions.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp
{
    using System;
    using System.IO;

    using Formats;

    /// <summary>
    /// Extension methods for the <see cref="Image{TColor}"/> type.
    /// </summary>
    public static partial class ImageExtensions
    {
        /// <summary>
        /// Saves the image to the given stream with the png format.
        /// </summary>
        /// <typeparam name="TColor">The pixel format.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="stream">The stream to save the image to.</param>
        /// <param name="quality">The quality to save the image to representing the number of colors.
        /// Anything equal to 256 and below will cause the encoder to save the image in an indexed format.
        /// </param>
        /// <exception cref="System.ArgumentNullException">Thrown if the stream is null.</exception>
        /// <returns>
        /// The <see cref="Image{TColor}"/>.
        /// </returns>
        public static Image<TColor> SaveAsPng<TColor>(this Image<TColor> source, Stream stream, int quality = int.MaxValue)
            where TColor : struct, IPackedPixel, IEquatable<TColor>
                        => source.Save(stream, new PngEncoder { Quality = quality });
    }
}
