﻿using System.Collections.Generic;

namespace Chart.Mvc.ComplexChart
{
    public class LineChartDataset : ComplexDataset
    {
        /// <summary>
        /// The ID of the x axis to plot this dataset on.
        /// </summary>
        public string XAxisID
        {
            get;
            set;
        }

        /// <summary>
        /// The ID of the y axis to plot this dataset on.
        /// </summary>
        public string YAxisID
        {
            get;
            set;
        }

        /// <summary>
        /// If true, fill the area under the line.
        /// </summary>
        public bool? Fill
        {
            get;
            set;
        }

        /// <summary>
        /// Bezier curve tension of the line. Set to 0 to draw straightlines. Note This was renamed from 'tension' but the old name still works.
        /// </summary>
        public double? LineTension
        {
            get;
            set;
        }

        /// <summary>
        /// The fill color under the line.
        /// </summary>
        public string BackgroundColor
        {
            get;
            set;
        }

        #region Border

        /// <summary>
        /// The width of the line in pixels.
        /// </summary>
        public double? BorderWidth
        {
            get;
            set;
        }

        /// <summary>
        /// The color of the line.
        /// </summary>
        public string BorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// Cap style of the line.
        /// </summary>
        public string BorderCapStyle
        {
            get;
            set;
        }

        /// <summary>
        /// Length and spacing of dashes.
        /// </summary>
        public List<double> BorderDash
        {
            get;
            set;
        }

        /// <summary>
        /// Offset for line dashes.
        /// </summary>
        public double? BorderDashOffset
        {
            get;
            set;
        }

        /// <summary>
        /// Line joint style.
        /// </summary>
        public string BorderJoinStyle
        {
            get;
            set;
        }

        #endregion
        
        #region Points

        /// <summary>
        /// The border color for points.
        /// </summary>
        public List<string> PointBorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// The fill color for points.
        /// </summary>
        public List<string> PointBackgroundColor
        {
            get;
            set;
        }

        /// <summary>
        /// The width of the point border in pixels.
        /// </summary>
        public List<double> PointBorderWidth
        {
            get;
            set;
        }

        /// <summary>
        /// The radius of the point shape. If set to 0, nothing is rendered.
        /// </summary>
        public List<double> PointRadius
        {
            get;
            set;
        }

        /// <summary>
        /// The radius of the point when hovered.
        /// </summary>
        public List<double> PointHoverRadius
        {
            get;
            set;
        }

        /// <summary>
        /// The pixel size of the non-displayed point that reacts to mouse events.
        /// </summary>
        public List<double> PointHitRadius
        {
            get;
            set;
        }

        /// <summary>
        /// Point background color when hovered.
        /// </summary>
        public List<string> PointHoverBackgroundColor
        {
            get;
            set;
        }

        /// <summary>
        /// Point border color when hovered.
        /// </summary>
        public List<string> PointHoverBorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// Border width of point when hovered.
        /// </summary>
        public List<double> PointHoverBorderWidth
        {
            get;
            set;
        }

        /// <summary>
        /// The style of point. Options are 'circle', 'triangle', 'rect', 'rectRot', 'cross', 'crossRot', 'star', 'line', and 'dash'.
        /// </summary>
        public List<string> PointStyle
        {
            get;
            set;
        }

        #endregion
    }
}
