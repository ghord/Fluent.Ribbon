﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Fluent
{
    /// <summary>
    /// Represents internal class to use it in 
    /// GalleryPanel as placeholder for GalleryItems
    /// </summary>
    class GalleryItemPlaceholder : FrameworkElement
    {
        #region Fields

        UIElement target;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the target of the placeholder
        /// </summary>
        public UIElement Target
        {
            get { return target; }
        }

        #endregion

        #region Initialization

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="target">Target</param>
        public GalleryItemPlaceholder(UIElement target)
        {
            this.target = target;
        }

        #endregion

        #region Methods

        /// <summary>
        /// When overridden in a derived class, measures the size in layout 
        /// required for child elements and determines a size for the derived class. 
        /// </summary>
        /// <returns>
        /// The size that this element determines it needs during layout, 
        /// based on its calculations of child element sizes.
        /// </returns>
        /// <param name="availableSize">The available size that this element can 
        /// give to child elements. Infinity can be specified as a value to 
        /// indicate that the element will size to whatever content is available.</param>
        protected override Size MeasureOverride(Size availableSize)
        {
            target.Measure(availableSize);
            return target.DesiredSize;
        }

        #endregion

        #region Debug

        /* FOR DEGUG
        protected override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.DrawRectangle(null, new Pen(Brushes.Red, 1), new Rect(RenderSize));
        }*/

        #endregion
    }
}
