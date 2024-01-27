using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace PackageAnalyzer
{
    public partial class MapForm : Form
    {
        private List<NMEAPackage> nMEA;
        private int currentIndex = 0;
        private double Latitude;
        private double Longitude;
        private GMapOverlay markers = new GMapOverlay("markers");

        public MapForm(List<NMEAPackage> nMEA)
        {
            InitializeComponent();

            ///////////////////////////////////
            //SaveMap.Visible = false; //ВОТ ЭТО ЕСЛИ ЧТО
            ///////////////////////////////////
            this.nMEA = nMEA;
            for (int i = 0; i < this.nMEA.Count; i++)
            {
                NMEAComboBox.Items.Add((i + 1).ToString() + " {Долгота: " + this.nMEA.ElementAt(i).Latitude + " Широта: " + this.nMEA.ElementAt(i).Longitude + "}");
            }
            NMEAComboBox.SelectedIndex = currentIndex;
        }

        ~MapForm()
        {
            
            //gmap.Dispose();
        }
        private void gMapControl1_Load(object sender, EventArgs e)
        {
            // Настройки для компонента GMap
            gmap.Bearing = 0;
            // Перетаскивание левой кнопки мыши
            gmap.CanDragMap = true;
            // Перетаскивание карты левой кнопкой мыши
            gmap.DragButton = MouseButtons.Left;
            gmap.GrayScaleMode = true;
            // Все маркеры будут показаны
            gmap.MarkersEnabled = true;
            // Максимальное приближение
            gmap.MaxZoom = 12;
            // Минимальное приближение
            gmap.MinZoom = 2;
            // Курсор мыши в центр карты
            gmap.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;
            // Отключение нигативного режима
            gmap.NegativeMode = false;
            // Разрешение полигонов
            gmap.PolygonsEnabled = true;
            // Разрешение маршрутов
            gmap.RoutesEnabled = true;
            // Скрытие внешней сетки карты
            gmap.ShowTileGridLines = false;
            // При загрузке 10-кратное увеличение
            gmap.Zoom = 10;
            // Убрать красный крестик по центру
            gmap.ShowCenter = false;
            // Чья карта используется
            //gmap.CacheLocation = @"\MapData";
            gmap.MapProvider = GMapProviders.YandexMap;
            GMaps.Instance.ImportFromGMDB(@"MapData\Data.gmdb");
            //GMaps.Instance.Mode = AccessMode.ServerAndCache;
            
            
        }

        private void NMEAComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Latitude = Double.Parse(nMEA.ElementAt(currentIndex).Latitude.Remove(5, 1).Remove(nMEA.ElementAt(currentIndex).Latitude.Length - 3, 2).Replace('°', ','));
            Longitude = Double.Parse(nMEA.ElementAt(currentIndex).Longitude.Remove(6, 1).Remove(nMEA.ElementAt(currentIndex).Longitude.Length - 3, 2).Replace('°', ','));
            gmap.Position = new PointLatLng(Latitude, Longitude);
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Latitude, Longitude), new Bitmap(Resources.ShipMarker));
            marker.ToolTipText = "Долгота: " + this.nMEA.ElementAt(NMEAComboBox.SelectedIndex).Latitude + Environment.NewLine + "Широта: " + this.nMEA.ElementAt(NMEAComboBox.SelectedIndex).Longitude.TrimStart('0');
            markers.Markers.Add(marker);
            gmap.Overlays.Add(markers);
        }

        private void SaveMap_Click(object sender, EventArgs e)
        {
            RectLatLng area = gmap.SelectedArea;
            if (area.IsEmpty)
            {
                MessageBox.Show("Выберите область для скачивания(ALT+ПКМ)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                
                for (int i = gmap.MinZoom; i <= gmap.MaxZoom; i++)
                {
                    TilePrefetcher tilePrefetcher = new TilePrefetcher();
                    tilePrefetcher.ShowCompleteMessage = false;
                    tilePrefetcher.Start(area, i, gmap.MapProvider, 100, 0);
                    
                    
                }
                //tilePrefetcher.Stop();
                
            }
        }
    }
}
