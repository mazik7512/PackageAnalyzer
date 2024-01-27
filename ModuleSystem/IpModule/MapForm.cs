using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using IpPackageParser;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace IpModule
{
    public partial class MapForm : Form
    {

        private List<NMEAData> nMEA;
        private int currentIndex = 0;
        private double Latitude;
        private double Longitude;
        private GMapOverlay markers = new GMapOverlay("markers");

        public MapForm(List<NMEAData> nMEAList)
        {
            InitializeComponent();
            Icon = Resources.map_icon;
            nMEA = nMEAList;
            for (int i = 0; i < this.nMEA.Count; i++)
            {
                NMEAComboBox.Items.Add((i + 1).ToString() + " {Долгота: " + this.nMEA.ElementAt(i).Latitude + " Широта: " + this.nMEA.ElementAt(i).Longitude + "}");
            }
            NMEAComboBox.SelectedIndex = currentIndex;
        }

        private void MapControl_Load(object sender, EventArgs e)
        {
            // Настройки для компонента GMap
            MapControl.Bearing = 0;
            // Перетаскивание левой кнопки мыши
            MapControl.CanDragMap = true;
            // Перетаскивание карты левой кнопкой мыши
            MapControl.DragButton = MouseButtons.Left;
            MapControl.GrayScaleMode = true;
            // Все маркеры будут показаны
            MapControl.MarkersEnabled = true;
            // Максимальное приближение
            MapControl.MaxZoom = 12;
            // Минимальное приближение
            MapControl.MinZoom = 2;
            // Курсор мыши в центр карты
            MapControl.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;
            // Отключение нигативного режима
            MapControl.NegativeMode = false;
            // Разрешение полигонов
            MapControl.PolygonsEnabled = true;
            // Разрешение маршрутов
            MapControl.RoutesEnabled = true;
            // Скрытие внешней сетки карты
            MapControl.ShowTileGridLines = false;
            // При загрузке 10-кратное увеличение
            MapControl.Zoom = 10;
            // Убрать красный крестик по центру
            MapControl.ShowCenter = false;
            // Чья карта используется
            //gmap.CacheLocation = @"\MapData";
            MapControl.CacheLocation = Directory.GetCurrentDirectory() + @"\MapData\";
            Console.WriteLine(MapControl.CacheLocation);
            MapControl.MapProvider = GMapProviders.WikiMapiaMap;
            //GMaps.Instance.ImportFromGMDB(@"E:\DataExp.gmdb");
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
        }

        private void NMEAComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Latitude = Double.Parse(nMEA.ElementAt(currentIndex).Latitude.Remove(5, 1).Remove(nMEA.ElementAt(currentIndex).Latitude.Length - 3, 2).Replace('°', ','));
            Longitude = Double.Parse(nMEA.ElementAt(currentIndex).Longitude.Remove(6, 1).Remove(nMEA.ElementAt(currentIndex).Longitude.Length - 3, 2).Replace('°', ','));
            MapControl.Position = new PointLatLng(Latitude, Longitude);
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Latitude, Longitude), new Bitmap(Resources.ShipMarker));
            marker.ToolTipText = "Долгота: " + this.nMEA.ElementAt(NMEAComboBox.SelectedIndex).Latitude + Environment.NewLine + "Широта: " + this.nMEA.ElementAt(NMEAComboBox.SelectedIndex).Longitude.TrimStart('0');
            speedValueLabel.Text = nMEA.ElementAt(NMEAComboBox.SelectedIndex).NmeaSpeed + " узлов";
            directionValueLabel.Text = nMEA.ElementAt(NMEAComboBox.SelectedIndex).NmeaFlowDirection + " градусов";
            latitudeValueLabel.Text = nMEA.ElementAt(NMEAComboBox.SelectedIndex).Latitude;
            longtitudeValueLabel.Text = nMEA.ElementAt(NMEAComboBox.SelectedIndex).Longitude;
            dateTimeValueLabel.Text = nMEA.ElementAt(NMEAComboBox.SelectedIndex).NmeaDate + " " + nMEA.ElementAt(NMEAComboBox.SelectedIndex).NmeaTime;
            markers.Markers.Add(marker);
            MapControl.Overlays.Add(markers);
        }

        private void SaveToCache()
        {
            RectLatLng area = MapControl.SelectedArea;
            if (!area.IsEmpty)
            {
                for (int i = (int)MapControl.Zoom; i <= MapControl.MaxZoom; i++)
                {
                    DialogResult res = MessageBox.Show("Ready ripp at Zoom = " + i + " ?", "GMap.NET", MessageBoxButtons.YesNoCancel);

                    if (res == DialogResult.Yes)
                    {
                        using (TilePrefetcher obj = new TilePrefetcher())
                        {
                            obj.Overlay = markers; // set overlay if you want to see cache progress on the map
                            
                            obj.Shuffle = MapControl.Manager.Mode != AccessMode.CacheOnly;

                            obj.Owner = this;
                            obj.ShowCompleteMessage = true;
                            obj.Start(area, i, MapControl.MapProvider, MapControl.Manager.Mode == AccessMode.CacheOnly ? 0 : 100, MapControl.Manager.Mode == AccessMode.CacheOnly ? 0 : 1);
                        }
                    }
                    else if (res == DialogResult.No)
                    {
                        continue;
                    }
                    else if (res == DialogResult.Cancel)
                    {
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Select map area holding ALT", "GMap.NET", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveToCache();
            
        }
    }
}
