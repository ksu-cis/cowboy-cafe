using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale
{
    public static class ExtensionMethods
    {
        public static T FindAncestor<T>(this DependencyObject element) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(element);

            if (parent == null)
            {
                return null;
            }
            else if (parent is T)
            {
                return parent as T;
            }
            else
            {
                return parent.FindAncestor<T>();
            }
        }
    }
}